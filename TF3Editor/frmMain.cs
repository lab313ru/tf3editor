using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Helpers;
using PluginVideoSega;

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

            cbbEventType.Items.Clear();
            cbbEventType.Items.AddRange(Consts.eventTypes);
            for (int i = 0xA; i < 0xA0; i++)
                cbbEventType.Items.Add(String.Format("{0:X2}: {1}", i, Event.ObjectDescription((ushort)i)));

            bChanged = false;
        }

        private void ShowElements(bool Visible)
        {
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
        byte iRomChangeIndex = 0;
        bool bChanged
        {
            get { return mnuSaveROMAs.Enabled; }
            set { this.Text = String.Format("{0} [{1}]" + (value ? "*" : ""), Title, sRomFile).Replace("[]", ""); mnuSaveROMAs.Enabled = value; }
        }
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
                int checksum = 0;
                int offset = 0x200;
                for (int i = 0; i < 0xFFC0; i++, offset += 8)
                {
                    checksum += baRom.ReadWord(offset);
                    checksum += baRom.ReadWord(offset + 2);
                    checksum += baRom.ReadWord(offset + 4);
                    checksum += baRom.ReadWord(offset + 6);
                }

                baRom.WriteWord(0x18E, (ushort)checksum);

                var romWrite = new BinaryWriter(File.Open(dlgSaveRom.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
                romWrite.Write(baRom, 0, baRom.Length);
                romWrite.Close();
                sRomFile = dlgSaveRom.FileName;
            }
            bChanged = false;
        }

        private void GetLevelData()
        {
            //Events
            ReadLevelEvents();

            cbbMusicIndex.SelectedIndex = level.MusicIndex;
            cbbBossMusicIndex.SelectedIndex = level.BossMusicIndex - 8;
            pbBossFace.Image = level.BossFace();
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

            level.BossFace().Save(dlgSaveBmp.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
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
            pbBossFace.Image = level.BossFace();
            bChanged = true;
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

        private void cbbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLevelData(true);

            if (cbbLevels.SelectedIndex == -1) return;

            level.Index = (byte)cbbLevels.SelectedIndex;

            GetLevelData();
        }

        private void btnTmxExport_Click(object sender, EventArgs e)
        {
            level.TmxExport("test.tmx");
        }
    }
}
