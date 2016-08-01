using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TF3Editor
{
    public partial class frmMain : Form
    {
        #region MainForm Elements
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            ShowElements(false);
            gridLevel.MakeDoubleBuffered(true);
            cbbTileIndex.MakeDoubleBuffered(true);
            pnlMain.Panel1MinSize = 32 + SystemInformation.VerticalScrollBarWidth;
            pnlMain.Panel2MinSize = 32 + SystemInformation.VerticalScrollBarWidth;
            cbbTileIndex.ImageList = ilTiles;
            cbbPalIndex.ImageList = ilPalettes;

            ilTiles.ColorDepth = ColorDepth.Depth16Bit;
            ilPalettes.ColorDepth = ColorDepth.Depth16Bit;
            ilBlocks.ColorDepth = ColorDepth.Depth16Bit;
            ilTiles.ImageSize = new Size(16, 16);
            ilPalettes.ImageSize = new Size(16, 16);
            ilBlocks.ImageSize = new System.Drawing.Size(32, 32);

            PrepareTables();

            cbbEventType.Items.Clear();
            cbbEventType.Items.AddRange(Consts.eventTypes);
            for (int i = 0xA; i < 0xA0; i++)
                cbbEventType.Items.Add(String.Format("{0:X2}: {1}", i, Event.ObjectDescription((ushort)i)));

            bChanged = false;
        }

        private void ShowElements(bool Visible)
        {
            pnlMain.Visible = Visible;
            pnlEditorTop.Visible = Visible;
            mnuCloseROM.Enabled = Visible;
            cbbLevels.Visible = Visible;
            tcMain.Visible = Visible;
        }
        #endregion

        #region Consts
        const string Title = "TF3ED v1.1";
        #endregion

        #region Variables
        bool bRomOpened = false;
        string sRomFile = "";
        byte[] baRom = null;

        Level level = null;
        byte bCurrentBlock = 0;
        byte bCurrentTile = 0;
        byte iRomChangeIndex = 0;
        bool bChanged
        {
            get { return mnuSaveROMAs.Enabled; }
            set { this.Text = String.Format("{0} [{1}]" + (value ? "*" : ""), Title, sRomFile).Replace("[]", ""); mnuSaveROMAs.Enabled = value; }
        }
        ImageList ilBlocks = new ImageList();
        ImageList ilTiles = new ImageList();
        ImageList ilPalettes = new ImageList();
        byte[] baLevelMapping = null;
        ushort[] baMapping = null;
        Color[] caPalette = null;
        byte[] baTiles = null;
        byte[] baSprites = null;
        bool mouseDown = false;
        bool isPlaneA = true;
        Bitmap overBlock = null;
        DataGridViewCell overIndex = null;
        #endregion

        #region Get and Set Level Data
        private void SaveLevelData(bool showQestion)
        {
            if (!bChanged) return;

            if (showQestion && MessageBox.Show("Current plane data was changed. Do you want to save it?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                bChanged = false;
                return;
            }
            
            iRomChangeIndex++;
            dlgSaveRom.FileName = "tf3_edit" + iRomChangeIndex.ToString();
            if (dlgSaveRom.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Mapper.ApplyMapping(ref baLevelMapping, baMapping, isPlaneA);

                byte[] baRomCopy = (byte[])baRom.Clone();

                uint tableSize = (baRomCopy.ReadUInt32BE(Consts.tblLevelsMain + 2) - 2) / 12;

                uint shift = 0;
                for (int i = 0; i < tableSize; i++)
                {
                    uint dataOffset = baRomCopy.ReadUInt32BE(Consts.tblLevelsMain + i * 0xC + 2);
                    uint decodedSize = baRomCopy.ReadUInt32BE(Consts.tblLevelsMain + i * 0xC + 6);
                    uint encodedSize = baRomCopy.ReadUInt32BE(Consts.tblLevelsMain + i * 0xC + 0xA);                    

                    if (i == level.Index + 0x10)
                    {
                        shift = encodedSize;
                        
                        byte[] baLZH = new byte[baLevelMapping.Length];
                        encodedSize = (uint)Compression.EncodeLZH(baLevelMapping, baLZH, baLZH.Length);
                        shift = encodedSize - shift;

                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 2, dataOffset);
                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 6, decodedSize);
                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 0xA, encodedSize);

                        Array.Copy(baLZH, 0, baRom, Consts.tblLevelsMain + dataOffset, encodedSize);
                    }
                    else
                    {
                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 2, dataOffset + shift);
                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 6, decodedSize);
                        baRom.WriteUInt32BE(Consts.tblLevelsMain + i * 0xC + 0xA, encodedSize);

                        byte[] temp = new byte[encodedSize];
                        Array.Copy(baRomCopy, Consts.tblLevelsMain + dataOffset, temp, 0, encodedSize);

                        Array.Copy(temp, 0, baRom, Consts.tblLevelsMain + dataOffset + shift, encodedSize);
                    }
                }

                int checksum = 0;
                int offset = 0x200;
                for (int i = 0; i < 0xFFC0; i++, offset += 8)
                {
                    checksum += baRom.ReadUInt16BE(offset);
                    checksum += baRom.ReadUInt16BE(offset + 2);
                    checksum += baRom.ReadUInt16BE(offset + 4);
                    checksum += baRom.ReadUInt16BE(offset + 6);
                }

                baRom.WriteUInt16BE(0x18E, (ushort)checksum);

                var romWrite = new BinaryWriter(File.Open(dlgSaveRom.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
                romWrite.Write(baRom, 0, baRom.Length);
                romWrite.Close();
                sRomFile = dlgSaveRom.FileName;
            }
            bChanged = false;
        }

        private void GetLevelData()
        {
            baTiles = level.GetTiles();

            baLevelMapping = level.GetMapping();
            baMapping = Mapper.LoadMapping(baLevelMapping, isPlaneA);

            baSprites = level.GetSprites();

            ilPalettes.Images.Clear();
            caPalette = level.GetPalette();
            Graphics gr = null;

            for (int y = 0; y < 2; y++)
            {
                Bitmap bmp = new Bitmap(8, 8);
                for (int x = 0; x < 16; x++)
                    using (gr = Graphics.FromImage(bmp))
                        gr.FillRectangle(new SolidBrush(caPalette[y * 16 + x]), x, 0, 1, 8);

                Bitmap image = new Bitmap(ilPalettes.ImageSize.Width, ilPalettes.ImageSize.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
                gr = Graphics.FromImage(image);
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                gr.DrawImage(bmp, new Rectangle(0, 0, image.Width, image.Height));
                gr.Dispose();

                ilPalettes.Images.Add(bmp);
            }

            //Events
            ReadLevelEvents();

            cbbMusicIndex.SelectedIndex = level.MusicIndex;
            cbbBossMusicIndex.SelectedIndex = level.BossMusicIndex - 8;
            pbBossFace.Image = level.BossFace(2);
            tbStageName.Text = level.LoadingScreen.Stage;
            tbTargetName.Text = level.LoadingScreen.Target;
            tbWeakPointName.Text = level.LoadingScreen.WeakPoint;
        }

        private void ReadLevelEvents()
        {
            lvEvents.Items.Clear();
            for (int i = 0; i < level.EventsCount(); i++) EventToList(level.GetEvent(i), i);

            if (lvEvents.Items.Count == 0) return;
            lvEvents.Items[0].Selected = true;
            lvEvents.Items[0].Focused = true;
        }

        private void EventToList(Event Event, int Index)
        {
            ListViewItem time = new ListViewItem();
            time.Text = Event.Time.ToString("D4");

            ListViewItem.ListViewSubItem id = new ListViewItem.ListViewSubItem();
            id.Text = Event.ID.ToString("X2");
            time.SubItems.Add(id);

            ListViewItem.ListViewSubItem x = new ListViewItem.ListViewSubItem();
            x.Text = Event.X.ToString("D");
            time.SubItems.Add(x);

            ListViewItem.ListViewSubItem y = new ListViewItem.ListViewSubItem();
            y.Text = Event.Y.ToString("D");
            time.SubItems.Add(y);

            ListViewItem.ListViewSubItem diffs = new ListViewItem.ListViewSubItem();
            string text = "NHM";
            if (!Event.DifficultyMask[0]) text = text.Replace("N", "");
            if (!Event.DifficultyMask[1]) text = text.Replace("H", "");
            if (!Event.DifficultyMask[2]) text = text.Replace("M", "");
            if (text == "") text = "Unspecified";
            diffs.Text = text;
            time.SubItems.Add(diffs);

            ListViewItem.ListViewSubItem param = new ListViewItem.ListViewSubItem();
            param.Text = Event.Params.ToString("X4");
            time.SubItems.Add(param);

            ListViewItem.ListViewSubItem description = new ListViewItem.ListViewSubItem();
            description.Text = Event.Description();
            time.SubItems.Add(description);

            if (Index == lvEvents.Items.Count)
                lvEvents.Items.Add(time);
            else
                lvEvents.Items[Index] = time;
        }

        private void cbbMusicIndex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            level.MusicIndex = (byte)cbbMusicIndex.SelectedIndex;
            this.Text = String.Format("{0} [{1}]*", Title, sRomFile);
            bChanged = true;
        }

        private void cbbBossMusicIndex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            level.BossMusicIndex = (byte)(cbbBossMusicIndex.SelectedIndex + 8);
            bChanged = true;
        }

        private void LoadingScreenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string allowed = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 :.?\x8\x2E";

            if (allowed.IndexOf(e.KeyChar.ToString().ToUpper()) == -1)
            {
                e.KeyChar = '\0';
                e.Handled = true;
            }
        }

        private void tbStageName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == level.LoadingScreen.Stage) return;

            level.LoadingScreen.Stage = (sender as TextBox).Text;
            bChanged = true;
        }

        private void tbTargetName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == level.LoadingScreen.Target) return;

            level.LoadingScreen.Target = (sender as TextBox).Text;
            bChanged = true;
        }

        private void tbWeakPointName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == level.LoadingScreen.WeakPoint) return;

            level.LoadingScreen.WeakPoint = (sender as TextBox).Text;
            bChanged = true;
        }
        #endregion

        #region Tiles Get Data
        private void GetCurrentTileInfo()
        {
            int selectedTileIdx = bCurrentBlock * 0x10 + bCurrentTile;

            cbbPalIndex.SelectedIndex = Mapper.PalIdx(baMapping[selectedTileIdx]);
            chkHFlip.Checked = Mapper.HF(baMapping[selectedTileIdx]);
            chkVFlip.Checked = Mapper.VF(baMapping[selectedTileIdx]);
            cbbTileIndex.SelectedIndex = Mapper.TileIdx(baMapping[selectedTileIdx]);

            btnCurrentTile.Text = String.Format("[{0:D}x{1:D}]", bCurrentTile / 4, bCurrentTile % 4);
        }
        #endregion

        #region Prepare Tables
        private void RedrawLevelTable()
        {
            gridLevel.Columns.Clear();
            gridLevel.Rows.Clear();
            for (int x = 0; x < 0x200; x++)
            {
                DataGridViewButtonColumn img = new DataGridViewButtonColumn();
                img.FillWeight = 1;
                img.FlatStyle = FlatStyle.Flat;
                img.MinimumWidth = 32;
                img.Width = 32;
                gridLevel.Columns.Add(img);
            }

            for (int y = 0; y < (isPlaneA ? 16 : 8); y++)
            {
                gridLevel.Rows.Add();
                gridLevel.Rows[y].Height = 32;
            }
        }

        private void PrepareTables()
        {
            //Tiles
            cbbTileIndex.ItemHeight = 24;
            for (int i = 0; i < 0x200; i++)
            {
                ImageComboBox.ImageComboBoxItem item = new ImageComboBox.ImageComboBoxItem(i, String.Format("{0:X3}", i), 0);
                cbbTileIndex.Items.Add(item);
            }

            //Palettes
            cbbPalIndex.ItemHeight = 24;
            for (int i = 0; i < 2; i++)
            {
                ImageComboBox.ImageComboBoxItem item = new ImageComboBox.ImageComboBoxItem(i, String.Format("{0:X}", i), 0);
                cbbPalIndex.Items.Add(item);
            }

            //Blocks
            pnlBlocks.SuspendLayout();
            for (int x = 0; x < 0x100; x++)
            {
                Button btn = new Button();
                btn.Size = new Size(32, 32);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Padding = new System.Windows.Forms.Padding(0);
                btn.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
                btn.ImageList = ilBlocks;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.ImageIndex = x;
                btn.Tag = (byte)x;
                btn.Click += new EventHandler(pnlBlocks_CheckBlockClick);
                
                pnlBlocks.Controls.Add(btn);
                if ((x + 1) % 7 == 0) pnlBlocks.SetFlowBreak(btn, true);
            }
            pnlBlocks.ResumeLayout();
        }

        private void RedrawTables()
        {
            ilTiles.Images.Clear();
            for (ushort i = 0; i < 0x200; i++) ilTiles.Images.Add(Graph.GetZoomTile(baTiles, i, caPalette, 0, false, false, 2));

            ilBlocks.Images.Clear();
            for (int x = 0; x < 0x100; x++) ilBlocks.Images.Add(Graph.GetZoomBlock(baMapping, baTiles, caPalette, (byte)x, 1));

            pnlBlocks.Invalidate(pnlBlocks.ClientRectangle, true);

            RedrawLevelTable();
            gridLevel.Invalidate(gridLevel.ClientRectangle);

            pnlBlocks_CheckBlockClick(pnlBlocks.Controls[0] as Button, new EventArgs());
        }
        #endregion

        #region Menus Work
        private void mnuSaveROMAs_Click(object sender, EventArgs e)
        {
            SaveLevelData(false);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}\n\r\n\r{1}\r\n\r\n{2}\r\n{3}\r\n{4}\r\n\r\n{5}",
                Title,
                "Thunder Force III Editor v1.1 (01/17/2014).",
                "Idea and Programming by: Dr. MefistO [Lab 313];",
                "My HERO (King of TF3 Reversing): El Styx;",
                "The Invaluable Help in code-writing: Spiiin.",
                "If you have any questions about TF3 Game or Editor, please, write a message here: \"meffi@lab313.ru,\" or here: \"http://lab313.ru/\"."),
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuOpenROM_Click(object sender, EventArgs e)
        {
            if (bRomOpened) mnuCloseROM_Click(sender, e);
            bRomOpened = dlgOpenRom.ShowDialog() == DialogResult.OK;

            if (!bRomOpened) return;

            sRomFile = dlgOpenRom.FileName;
            BinaryReader brRom = new BinaryReader(File.OpenRead(sRomFile));
            baRom = brRom.ReadBytes((int)brRom.BaseStream.Length);
            brRom.Close();
            bChanged = false;

            level = new Level(ref baRom, 0);
            cbbLevels.Items.Clear();
            cbbLevels.Items.AddRange(level.Names);
            cbbLevels.SelectedIndex = 0;
            ShowElements(true);
        }

        private void mnuCloseROM_Click(object sender, EventArgs e)
        {
            cbbLevels.SelectedIndex = -1;
            bRomOpened = false;
            sRomFile = "";
            this.Text = Title;
            bChanged = false;
            iRomChangeIndex = 0;
            
            ShowElements(false);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            mnuCloseROM_Click(sender, e);
            Application.Exit();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            CloseApp(sender, e);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseApp(sender, e);
        }

        private void mnuSaveFaceAsBmp_Click(object sender, EventArgs e)
        {
            dlgSaveBmp.FileName = "BossFace_" + level.Name();
            bool show = dlgSaveBmp.ShowDialog() == System.Windows.Forms.DialogResult.OK;
            if (!show) return;

            level.BossFace(1).Save(dlgSaveBmp.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void mnuLoadFaceFromBmp_Click(object sender, EventArgs e)
        {
            dlgOpenBmp.FileName = "BossFace_" + level.Name();
            bool show = dlgOpenBmp.ShowDialog() == System.Windows.Forms.DialogResult.OK;
            if (!show) return;

            Bitmap test = (Bitmap)Bitmap.FromFile(dlgOpenBmp.FileName);
            if (test.Width != 80 || test.Height != 56)
            {
                MessageBox.Show("Error loading this BMP!\r\nCheck this Params: [Width=80; Height=56].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            level.ApplyBossFace(test);
            pbBossFace.Image = level.BossFace(2);
            bChanged = true;
        }
        #endregion

        #region Level Change
        private void rbPlaneA_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked) return;

            isPlaneA = true;
            if (bChanged) Mapper.ApplyMapping(ref baLevelMapping, baMapping, false);
            baMapping = Mapper.LoadMapping(baLevelMapping, true);

            RedrawTables();
        }

        private void rbPlaneB_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked) return;

            isPlaneA = false;
            if (bChanged) Mapper.ApplyMapping(ref baLevelMapping, baMapping, true);
            baMapping = Mapper.LoadMapping(baLevelMapping, false);

            RedrawTables();
        }

        private void cbbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLevelData(true);
            
            if (cbbLevels.SelectedIndex == -1) return;

            level.Index = (byte)cbbLevels.SelectedIndex;

            GetLevelData();
            RedrawTables();
        }
        #endregion

        #region Cells painting
        private void gridLevel_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.CellStyle.Padding = new System.Windows.Forms.Padding(0);

            e.Graphics.DrawImage(ilBlocks.Images[baLevelMapping[(isPlaneA ? 0x4000 : 0x6000) + e.ColumnIndex * gridLevel.RowCount + e.RowIndex]], e.CellBounds);
            e.PaintContent(e.CellBounds);

            if (overBlock != null && overIndex == gridLevel[e.ColumnIndex, e.RowIndex])
            {
                Pen pen = new Pen(Color.White);
                e.Graphics.DrawImage(overBlock, e.CellBounds);

                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);

                e.Graphics.DrawRectangle(pen, e.CellBounds);
            }
            
            e.Handled = true;
        }
        #endregion

        #region Cells Clicking
        private void gridLevel_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            overBlock = Graph.GetZoomBlock(baMapping, baTiles, caPalette, (byte)bCurrentBlock, 1);
            overIndex = gridLevel[e.ColumnIndex, e.RowIndex];
            gridLevel.InvalidateCell(e.ColumnIndex, e.RowIndex);
        }

        private void gridLevel_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            overBlock = null;
            overIndex = null;
            gridLevel.InvalidateCell(e.ColumnIndex, e.RowIndex);
        }

        private void gridLevel_SelectionChanged(object sender, EventArgs e)
        {
            gridLevel.ClearSelection();
        }

        private void gridLevel_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            mouseDown = (e.Button == System.Windows.Forms.MouseButtons.Left);
            if (!mouseDown) return;
            updateLevelCell(e.ColumnIndex, e.RowIndex);
        }

        private void gridLevel_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            mouseDown = false;
        }

        private void gridLevel_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (mouseDown)
                updateLevelCell(e.ColumnIndex, e.RowIndex);
        }

        private void pnlBlocks_CheckBlockClick(object sender, EventArgs e)
        {
            bCurrentBlock = (byte)((sender as Button).Tag);

            redrawCurrentBlock();
            CurrentBlockTiles_Click(pnlCurrentBlock.Controls[0] as Button, new EventArgs());
        }
        #endregion

        #region Tile Info Updating
        private void CurrentBlockTiles_Click(object sender, EventArgs e)
        {
            bCurrentTile = (byte)(sender as Button).Tag;
            GetCurrentTileInfo();
        }

        private void redrawCurrentBlock()
        {
            pnlCurrentBlock.SuspendLayout();
            for (int i = 0; i < 0x10; i++)
            {
                ushort Word = baMapping[bCurrentBlock * 0x10 + (i / 4) * 4 + (i % 4)];
                byte palIndex = Mapper.PalIdx(Word);
                bool HF = Mapper.HF(Word);
                bool VF = Mapper.VF(Word);

                pnlCurrentBlock.Controls[i].BackgroundImage = Graph.GetZoomTile(baTiles, Word, caPalette, palIndex, HF, VF, 4);
                pnlCurrentBlock.Controls[i].BackgroundImageLayout = ImageLayout.Center;
                pnlCurrentBlock.Controls[i].Tag = (byte)i;
            }
            pnlCurrentBlock.ResumeLayout();
            ilBlocks.Images[bCurrentBlock] = Graph.GetZoomBlock(baMapping, baTiles, caPalette, (byte)bCurrentBlock, 1);
            pnlBlocks.Controls[bCurrentBlock].Invalidate();
        }

        private void updateSelectedTile()
        {
            ushort idx = (ushort)cbbTileIndex.SelectedIndex;
            bool hf = chkHFlip.Checked;
            bool vf = chkVFlip.Checked;
            byte PalIndex = (byte)cbbPalIndex.SelectedIndex;

            baMapping[bCurrentBlock * 0x10 + bCurrentTile] = Mapper.EncodeTileInfo(idx, hf, vf, PalIndex);
            Mapper.ApplyMapping(ref baLevelMapping, baMapping, isPlaneA);
            bChanged = true;

            redrawCurrentBlock();
            gridLevel.Invalidate(gridLevel.ClientRectangle);
        }

        private void updateLevelCell(int cellX, int cellY)
        {
            var currentCell = gridLevel.Rows[cellY].Cells[cellX];
            baLevelMapping[(isPlaneA ? 0x4000 : 0x6000) + currentCell.ColumnIndex * gridLevel.RowCount + currentCell.RowIndex] = bCurrentBlock;
            Mapper.ApplyMapping(ref baLevelMapping, baMapping, isPlaneA);
            bChanged = true;

            gridLevel.InvalidateCell(currentCell);
        }

        private void cbbTileIndex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateSelectedTile();
        }

        private void cbbPalIndex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateSelectedTile();
        }
        #endregion        

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string allowed = "0123456789\x8\x2E";

            if (allowed.IndexOf(e.KeyChar.ToString()) == -1)
            {
                e.KeyChar = '\0';
                e.Handled = true;
            }
        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
            if (tbTime.Text == "") return;
            if (Convert.ToInt16(tbTime.Text) > 2000) tbTime.Text = "0";
        }

        private void tbXY_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string allowed = "-0123456789\x8\x2E";

            if (allowed.IndexOf(e.KeyChar.ToString()) == -1 || ((sender as TextBox).Text.Length > 1 && e.KeyChar == '-'))
            {
                e.KeyChar = '\0';
                e.Handled = true;
            }
        }

        private void tbXY_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "") return;

            sbyte value;
            SByte.TryParse((sender as TextBox).Text, out value);
            if (value > 64 || value < -64) (sender as TextBox).Text = "0";
        }

        private void tbParams_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string allowed = "ABCDEF0123456789\x8\x2E";

            if (allowed.IndexOf(e.KeyChar.ToString().ToUpper()) == -1)
            {
                e.KeyChar = '\0';
                e.Handled = true;
            }
        }

        private void lvEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count == 0) return;

            var item = lvEvents.SelectedItems[0];

            tbTime.Text = item.SubItems[0].Text;
            
            byte id = Convert.ToByte(item.SubItems[1].Text, 16);
            cbbEventType.SelectedIndex = id;

            tbX.Text = item.SubItems[2].Text;
            tbY.Text = item.SubItems[3].Text;

            lvDifficulty.Items[0].Checked = item.SubItems[4].Text.IndexOf('N') != -1;
            lvDifficulty.Items[1].Checked = item.SubItems[4].Text.IndexOf('H') != -1;
            lvDifficulty.Items[2].Checked = item.SubItems[4].Text.IndexOf('M') != -1;

            tbParams.Text = item.SubItems[5].Text;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ushort time;
            ushort.TryParse(tbTime.Text, out time);
            sbyte x;
            SByte.TryParse(tbX.Text, out x);
            sbyte y;
            SByte.TryParse(tbY.Text, out y);

            Event evnt = new Event(time, x, y, new bool[3] { lvDifficulty.Items[0].Checked, lvDifficulty.Items[1].Checked, lvDifficulty.Items[2].Checked },
                Convert.ToByte(cbbEventType.SelectedIndex), Convert.ToUInt16(tbParams.Text, 16));

            level.SetEvent(lvEvents.Items.Count, evnt);
            ReadLevelEvents();
            lvEvents.Items[lvEvents.Items.Count - 1].Selected = true;
            lvEvents.Items[lvEvents.Items.Count - 1].Focused = true;
            lvEvents.Focus();
            bChanged = true;
        }

        private void btnReplaceEvent_Click(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count == 0) return;

            ushort time;
            ushort.TryParse(tbTime.Text, out time);
            sbyte x;
            SByte.TryParse(tbX.Text, out x);
            sbyte y;
            SByte.TryParse(tbY.Text, out y);
            Event evnt = new Event(time, x, y, new bool[3] { lvDifficulty.Items[0].Checked, lvDifficulty.Items[1].Checked, lvDifficulty.Items[2].Checked },
                Convert.ToByte(cbbEventType.SelectedIndex), Convert.ToUInt16(tbParams.Text, 16));

            int idx = lvEvents.SelectedItems[0].Index;
            level.SetEvent(idx, evnt);
            ReadLevelEvents();
            lvEvents.Items[idx].Selected = true;
            lvEvents.Items[idx].Focused = true;
            lvEvents.Focus();
            bChanged = true;
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count == 0) return;

            int idx = lvEvents.SelectedItems[0].Index;
            level.DelEvent(idx);
            ReadLevelEvents();

            if (lvEvents.Items.Count > 0)
            {
                if (idx == level.EventsCount()) idx--;
                
                lvEvents.Items[idx].Selected = true;
                lvEvents.Items[idx].Focused = true;
            }

            lvEvents.Focus();
            bChanged = true;
        }

        private void btnClearEvents_Click(object sender, EventArgs e)
        {
            do level.DelEvent(0);
            while (level.EventsCount() > 0);
            ReadLevelEvents();

            bChanged = true;
        }

        private void cbbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEventType.SelectedIndex == -1) return;

            string text = "";
            switch (cbbEventType.SelectedIndex)
            {
                case 0: text = "X = PlaneA Scrolling Vector.X; Y = PlaneA Scrolling Vector.Y;" +
                    "\r\nParameter Byte1 = PlaneB Scrolling Vector.X; Parameter Byte2 = PlaneB Scrolling Vector.Y."; break;
                case 1: text = "If Timer value is 0, then Parameter = PlaneB Scrolling Type, else Parameter = Level Speed Multiplier." +
                    "\r\nLevel Speed Multiplier: 1 = Ultra Speedup; 3 = Moderate Speedup; 2 = Normal speed."; break;
                case 2: text = "Parameter = PlaneA Priority Mask."; break;
                case 3: text = "Parameter = Greater value means slower animation speed of animated parts of level (waterfall, fires, etc.)."; break;
                case 4: text = "if Parameter Byte1 is 0, then Parameter Byte2 is Music Number to play;" +
                    "\r\nIf Parameter Byte1 is 1, then Parameter Byte2 is Music fadeout timer;" +
                    "\r\nIf Parameter Byte1 is 2, then Parameter Byte2 is Sound Number to play."; break;
                case 6: text = "if Parameter values is 0, then call Boss preparing routine, else Parameter = Boss number."; break;
                case 7:
                case 9: text = "Parameter value is:"+
                    "\r\n0: Sever weapon; 1: Lancer weapon; 2: Weavegun weapon; 3: Fire weapon; 4: Hunter weapon; 5: Shield; 6: 1 Life; 7: Claws Helper."; break;
                case 0x49: text = "X = X-Position of Hidden item. Y = Y-Position if Hidden item.\r\n" + "Parameter Byte1 value is:" +
                    "\r\n0: Sever weapon; 1: Lancer weapon; 2: Weavegun weapon; 3: Fire weapon; 4: Hunter weapon; 5: Shield; 6: 1 Life; 7: Claws Helper."+
                    "\r\nParameter Byte2 value means minimum damage for this item to show it."; break;
            }

            tbEventDescription.Text = text;
        }
    }
}
