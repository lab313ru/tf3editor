namespace TF3Editor
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Normal");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Hard");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Mania");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuROM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenROM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveROMAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseROM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenRom = new System.Windows.Forms.OpenFileDialog();
            this.pnlEditorTop = new System.Windows.Forms.FlowLayoutPanel();
            this.rbPlaneA = new System.Windows.Forms.RadioButton();
            this.rbPlaneB = new System.Windows.Forms.RadioButton();
            this.pnlMain = new System.Windows.Forms.SplitContainer();
            this.pnlBlocks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBlockInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCurrentBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTile1 = new System.Windows.Forms.Button();
            this.btnTile2 = new System.Windows.Forms.Button();
            this.btnTile3 = new System.Windows.Forms.Button();
            this.btnTile4 = new System.Windows.Forms.Button();
            this.btnTile5 = new System.Windows.Forms.Button();
            this.btnTile6 = new System.Windows.Forms.Button();
            this.btnTile7 = new System.Windows.Forms.Button();
            this.btnTile8 = new System.Windows.Forms.Button();
            this.btnTile9 = new System.Windows.Forms.Button();
            this.btnTile10 = new System.Windows.Forms.Button();
            this.btnTile11 = new System.Windows.Forms.Button();
            this.btnTile12 = new System.Windows.Forms.Button();
            this.btnTile13 = new System.Windows.Forms.Button();
            this.btnTile14 = new System.Windows.Forms.Button();
            this.btnTile15 = new System.Windows.Forms.Button();
            this.btnTile16 = new System.Windows.Forms.Button();
            this.chkVFlip = new System.Windows.Forms.CheckBox();
            this.cbbPalIndex = new ImageComboBox.ImageComboBox();
            this.cbbTileIndex = new ImageComboBox.ImageComboBox();
            this.chkHFlip = new System.Windows.Forms.CheckBox();
            this.btnCurrentTile = new System.Windows.Forms.Button();
            this.gridLevel = new System.Windows.Forms.DataGridView();
            this.dlgSaveRom = new System.Windows.Forms.SaveFileDialog();
            this.ttTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cbbLevels = new System.Windows.Forms.ComboBox();
            this.pbBossFace = new System.Windows.Forms.PictureBox();
            this.mnuBossFace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSaveFaceAsBmp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadFaceFromBmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.cbbEventType = new System.Windows.Forms.ComboBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lvDifficulty = new System.Windows.Forms.ListView();
            this.chNormal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbParams = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpInitParams = new System.Windows.Forms.TabPage();
            this.tblLevelParams = new System.Windows.Forms.TableLayoutPanel();
            this.cbbBossMusicIndex = new System.Windows.Forms.ComboBox();
            this.lbBossMusicIndex = new System.Windows.Forms.Label();
            this.tbWeakPointName = new System.Windows.Forms.TextBox();
            this.lbWeakPointName = new System.Windows.Forms.Label();
            this.tbTargetName = new System.Windows.Forms.TextBox();
            this.lbTargetName = new System.Windows.Forms.Label();
            this.lbStageName = new System.Windows.Forms.Label();
            this.lbBossFace = new System.Windows.Forms.Label();
            this.lbMusicIndex = new System.Windows.Forms.Label();
            this.cbbMusicIndex = new System.Windows.Forms.ComboBox();
            this.tbStageName = new System.Windows.Forms.TextBox();
            this.tpEditor = new System.Windows.Forms.TabPage();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.lvEvents = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chXCoord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYCoord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDifficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chParams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlEvent = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnReplaceEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tbEventDescription = new System.Windows.Forms.TextBox();
            this.btnClearEvents = new System.Windows.Forms.Button();
            this.dlgOpenBmp = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveBmp = new System.Windows.Forms.SaveFileDialog();
            this.tpCompression = new System.Windows.Forms.TabPage();
            this.tcCompression = new System.Windows.Forms.TabControl();
            this.tpRleCompression = new System.Windows.Forms.TabPage();
            this.tpLzhufCompression = new System.Windows.Forms.TabPage();
            this.tblRleData = new System.Windows.Forms.DataGridView();
            this.clRleIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleTableOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleDestOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleCmpSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleUnpSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRleDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRleButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRleImport = new System.Windows.Forms.Button();
            this.btnRleExtract = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.pnlEditorTop.SuspendLayout();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBlockInfo.SuspendLayout();
            this.pnlCurrentBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBossFace)).BeginInit();
            this.mnuBossFace.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpInitParams.SuspendLayout();
            this.tblLevelParams.SuspendLayout();
            this.tpEditor.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.pnlEvent.SuspendLayout();
            this.tpCompression.SuspendLayout();
            this.tcCompression.SuspendLayout();
            this.tpRleCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRleData)).BeginInit();
            this.pnlRleButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuROM,
            this.mnuEdit,
            this.mnuHelp});
            this.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(975, 24);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuROM
            // 
            this.mnuROM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenROM,
            this.mnuSaveROMAs,
            this.mnuCloseROM,
            this.mnuSeparator,
            this.mnuExit});
            this.mnuROM.Name = "mnuROM";
            this.mnuROM.Size = new System.Drawing.Size(40, 20);
            this.mnuROM.Text = "&ROM";
            // 
            // mnuOpenROM
            // 
            this.mnuOpenROM.Name = "mnuOpenROM";
            this.mnuOpenROM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenROM.Size = new System.Drawing.Size(228, 22);
            this.mnuOpenROM.Text = "&Open TF3 ROM...";
            this.mnuOpenROM.Click += new System.EventHandler(this.mnuOpenROM_Click);
            // 
            // mnuSaveROMAs
            // 
            this.mnuSaveROMAs.Name = "mnuSaveROMAs";
            this.mnuSaveROMAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveROMAs.Size = new System.Drawing.Size(228, 22);
            this.mnuSaveROMAs.Text = "&Save ROM As...";
            this.mnuSaveROMAs.Click += new System.EventHandler(this.mnuSaveROMAs_Click);
            // 
            // mnuCloseROM
            // 
            this.mnuCloseROM.Enabled = false;
            this.mnuCloseROM.Name = "mnuCloseROM";
            this.mnuCloseROM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuCloseROM.Size = new System.Drawing.Size(228, 22);
            this.mnuCloseROM.Text = "&Close ROM";
            this.mnuCloseROM.Click += new System.EventHandler(this.mnuCloseROM_Click);
            // 
            // mnuSeparator
            // 
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(228, 22);
            this.mnuExit.Text = "&Exit...";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(47, 20);
            this.mnuEdit.Text = "&Edit";
            this.mnuEdit.Visible = false;
            // 
            // mnuUndo
            // 
            this.mnuUndo.Enabled = false;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuUndo.Size = new System.Drawing.Size(151, 22);
            this.mnuUndo.Text = "&Undo";
            // 
            // mnuRedo
            // 
            this.mnuRedo.Enabled = false;
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuRedo.Size = new System.Drawing.Size(151, 22);
            this.mnuRedo.Text = "&Redo";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(47, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(130, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // dlgOpenRom
            // 
            this.dlgOpenRom.DefaultExt = "bin";
            this.dlgOpenRom.Filter = "Genesis ROM Files (*.bin, *.gen)|*.bin;*.gen|All Files (*.*)|*.*";
            this.dlgOpenRom.ReadOnlyChecked = true;
            this.dlgOpenRom.RestoreDirectory = true;
            this.dlgOpenRom.Title = "Please, select TF3 ROM file...";
            // 
            // pnlEditorTop
            // 
            this.pnlEditorTop.AutoSize = true;
            this.pnlEditorTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEditorTop.Controls.Add(this.rbPlaneA);
            this.pnlEditorTop.Controls.Add(this.rbPlaneB);
            this.pnlEditorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditorTop.Location = new System.Drawing.Point(3, 3);
            this.pnlEditorTop.Name = "pnlEditorTop";
            this.pnlEditorTop.Size = new System.Drawing.Size(961, 30);
            this.pnlEditorTop.TabIndex = 5;
            // 
            // rbPlaneA
            // 
            this.rbPlaneA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlaneA.AutoSize = true;
            this.rbPlaneA.Checked = true;
            this.rbPlaneA.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPlaneA.Location = new System.Drawing.Point(3, 3);
            this.rbPlaneA.Name = "rbPlaneA";
            this.rbPlaneA.Size = new System.Drawing.Size(59, 24);
            this.rbPlaneA.TabIndex = 2;
            this.rbPlaneA.TabStop = true;
            this.rbPlaneA.Text = "PlaneA";
            this.ttTooltip.SetToolTip(this.rbPlaneA, "Show PlaneA");
            this.rbPlaneA.UseVisualStyleBackColor = true;
            this.rbPlaneA.CheckedChanged += new System.EventHandler(this.rbPlaneA_CheckedChanged);
            // 
            // rbPlaneB
            // 
            this.rbPlaneB.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlaneB.AutoSize = true;
            this.rbPlaneB.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPlaneB.Location = new System.Drawing.Point(68, 3);
            this.rbPlaneB.Name = "rbPlaneB";
            this.rbPlaneB.Size = new System.Drawing.Size(59, 24);
            this.rbPlaneB.TabIndex = 3;
            this.rbPlaneB.TabStop = true;
            this.rbPlaneB.Text = "PlaneB";
            this.ttTooltip.SetToolTip(this.rbPlaneB, "Show PlaneB");
            this.rbPlaneB.UseVisualStyleBackColor = true;
            this.rbPlaneB.CheckedChanged += new System.EventHandler(this.rbPlaneB_CheckedChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnlMain.IsSplitterFixed = true;
            this.pnlMain.Location = new System.Drawing.Point(3, 33);
            this.pnlMain.Name = "pnlMain";
            // 
            // pnlMain.Panel1
            // 
            this.pnlMain.Panel1.Controls.Add(this.pnlBlocks);
            this.pnlMain.Panel1.Controls.Add(this.pnlBlockInfo);
            // 
            // pnlMain.Panel2
            // 
            this.pnlMain.Panel2.Controls.Add(this.gridLevel);
            this.pnlMain.Size = new System.Drawing.Size(961, 454);
            this.pnlMain.SplitterDistance = 277;
            this.pnlMain.TabIndex = 6;
            // 
            // pnlBlocks
            // 
            this.pnlBlocks.AutoScroll = true;
            this.pnlBlocks.AutoScrollMargin = new System.Drawing.Size(2, 0);
            this.pnlBlocks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBlocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBlocks.Location = new System.Drawing.Point(0, 0);
            this.pnlBlocks.Name = "pnlBlocks";
            this.pnlBlocks.Size = new System.Drawing.Size(277, 278);
            this.pnlBlocks.TabIndex = 11;
            // 
            // pnlBlockInfo
            // 
            this.pnlBlockInfo.AutoScroll = true;
            this.pnlBlockInfo.AutoSize = true;
            this.pnlBlockInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBlockInfo.ColumnCount = 3;
            this.pnlBlockInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlBlockInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlBlockInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlBlockInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlBlockInfo.Controls.Add(this.pnlCurrentBlock, 0, 0);
            this.pnlBlockInfo.Controls.Add(this.chkVFlip, 2, 1);
            this.pnlBlockInfo.Controls.Add(this.cbbPalIndex, 1, 1);
            this.pnlBlockInfo.Controls.Add(this.cbbTileIndex, 0, 1);
            this.pnlBlockInfo.Controls.Add(this.chkHFlip, 2, 0);
            this.pnlBlockInfo.Controls.Add(this.btnCurrentTile, 1, 0);
            this.pnlBlockInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBlockInfo.Location = new System.Drawing.Point(0, 278);
            this.pnlBlockInfo.Name = "pnlBlockInfo";
            this.pnlBlockInfo.RowCount = 2;
            this.pnlBlockInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlBlockInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlBlockInfo.Size = new System.Drawing.Size(277, 176);
            this.pnlBlockInfo.TabIndex = 9;
            // 
            // pnlCurrentBlock
            // 
            this.pnlCurrentBlock.AutoSize = true;
            this.pnlCurrentBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrentBlock.Controls.Add(this.btnTile1);
            this.pnlCurrentBlock.Controls.Add(this.btnTile2);
            this.pnlCurrentBlock.Controls.Add(this.btnTile3);
            this.pnlCurrentBlock.Controls.Add(this.btnTile4);
            this.pnlCurrentBlock.Controls.Add(this.btnTile5);
            this.pnlCurrentBlock.Controls.Add(this.btnTile6);
            this.pnlCurrentBlock.Controls.Add(this.btnTile7);
            this.pnlCurrentBlock.Controls.Add(this.btnTile8);
            this.pnlCurrentBlock.Controls.Add(this.btnTile9);
            this.pnlCurrentBlock.Controls.Add(this.btnTile10);
            this.pnlCurrentBlock.Controls.Add(this.btnTile11);
            this.pnlCurrentBlock.Controls.Add(this.btnTile12);
            this.pnlCurrentBlock.Controls.Add(this.btnTile13);
            this.pnlCurrentBlock.Controls.Add(this.btnTile14);
            this.pnlCurrentBlock.Controls.Add(this.btnTile15);
            this.pnlCurrentBlock.Controls.Add(this.btnTile16);
            this.pnlCurrentBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrentBlock.Location = new System.Drawing.Point(3, 3);
            this.pnlCurrentBlock.Name = "pnlCurrentBlock";
            this.pnlCurrentBlock.Size = new System.Drawing.Size(134, 134);
            this.pnlCurrentBlock.TabIndex = 29;
            // 
            // btnTile1
            // 
            this.btnTile1.AutoSize = true;
            this.btnTile1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile1.Location = new System.Drawing.Point(0, 0);
            this.btnTile1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile1.Name = "btnTile1";
            this.btnTile1.Size = new System.Drawing.Size(32, 32);
            this.btnTile1.TabIndex = 0;
            this.btnTile1.Tag = "";
            this.btnTile1.UseVisualStyleBackColor = true;
            this.btnTile1.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile2
            // 
            this.btnTile2.AutoSize = true;
            this.btnTile2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile2.Location = new System.Drawing.Point(33, 0);
            this.btnTile2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile2.Name = "btnTile2";
            this.btnTile2.Size = new System.Drawing.Size(32, 32);
            this.btnTile2.TabIndex = 1;
            this.btnTile2.Tag = "";
            this.btnTile2.UseVisualStyleBackColor = true;
            this.btnTile2.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile3
            // 
            this.btnTile3.AutoSize = true;
            this.btnTile3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile3.Location = new System.Drawing.Point(66, 0);
            this.btnTile3.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile3.Name = "btnTile3";
            this.btnTile3.Size = new System.Drawing.Size(32, 32);
            this.btnTile3.TabIndex = 2;
            this.btnTile3.Tag = "";
            this.btnTile3.UseVisualStyleBackColor = true;
            this.btnTile3.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile4
            // 
            this.btnTile4.AutoSize = true;
            this.btnTile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTile4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnlCurrentBlock.SetFlowBreak(this.btnTile4, true);
            this.btnTile4.Location = new System.Drawing.Point(99, 0);
            this.btnTile4.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile4.Name = "btnTile4";
            this.btnTile4.Size = new System.Drawing.Size(32, 32);
            this.btnTile4.TabIndex = 3;
            this.btnTile4.Tag = "";
            this.btnTile4.UseVisualStyleBackColor = true;
            this.btnTile4.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile5
            // 
            this.btnTile5.AutoSize = true;
            this.btnTile5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile5.Location = new System.Drawing.Point(0, 33);
            this.btnTile5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile5.Name = "btnTile5";
            this.btnTile5.Size = new System.Drawing.Size(32, 32);
            this.btnTile5.TabIndex = 4;
            this.btnTile5.Tag = "";
            this.btnTile5.UseVisualStyleBackColor = true;
            this.btnTile5.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile6
            // 
            this.btnTile6.AutoSize = true;
            this.btnTile6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile6.Location = new System.Drawing.Point(33, 33);
            this.btnTile6.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile6.Name = "btnTile6";
            this.btnTile6.Size = new System.Drawing.Size(32, 32);
            this.btnTile6.TabIndex = 5;
            this.btnTile6.Tag = "";
            this.btnTile6.UseVisualStyleBackColor = true;
            this.btnTile6.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile7
            // 
            this.btnTile7.AutoSize = true;
            this.btnTile7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile7.Location = new System.Drawing.Point(66, 33);
            this.btnTile7.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile7.Name = "btnTile7";
            this.btnTile7.Size = new System.Drawing.Size(32, 32);
            this.btnTile7.TabIndex = 6;
            this.btnTile7.Tag = "";
            this.btnTile7.UseVisualStyleBackColor = true;
            this.btnTile7.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile8
            // 
            this.btnTile8.AutoSize = true;
            this.btnTile8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnlCurrentBlock.SetFlowBreak(this.btnTile8, true);
            this.btnTile8.Location = new System.Drawing.Point(99, 33);
            this.btnTile8.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile8.Name = "btnTile8";
            this.btnTile8.Size = new System.Drawing.Size(32, 32);
            this.btnTile8.TabIndex = 7;
            this.btnTile8.Tag = "";
            this.btnTile8.UseVisualStyleBackColor = true;
            this.btnTile8.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile9
            // 
            this.btnTile9.AutoSize = true;
            this.btnTile9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile9.Location = new System.Drawing.Point(0, 66);
            this.btnTile9.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile9.Name = "btnTile9";
            this.btnTile9.Size = new System.Drawing.Size(32, 32);
            this.btnTile9.TabIndex = 8;
            this.btnTile9.Tag = "";
            this.btnTile9.UseVisualStyleBackColor = true;
            this.btnTile9.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile10
            // 
            this.btnTile10.AutoSize = true;
            this.btnTile10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile10.Location = new System.Drawing.Point(33, 66);
            this.btnTile10.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile10.Name = "btnTile10";
            this.btnTile10.Size = new System.Drawing.Size(32, 32);
            this.btnTile10.TabIndex = 9;
            this.btnTile10.Tag = "";
            this.btnTile10.UseVisualStyleBackColor = true;
            this.btnTile10.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile11
            // 
            this.btnTile11.AutoSize = true;
            this.btnTile11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile11.Location = new System.Drawing.Point(66, 66);
            this.btnTile11.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile11.Name = "btnTile11";
            this.btnTile11.Size = new System.Drawing.Size(32, 32);
            this.btnTile11.TabIndex = 10;
            this.btnTile11.Tag = "";
            this.btnTile11.UseVisualStyleBackColor = true;
            this.btnTile11.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile12
            // 
            this.btnTile12.AutoSize = true;
            this.btnTile12.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnlCurrentBlock.SetFlowBreak(this.btnTile12, true);
            this.btnTile12.Location = new System.Drawing.Point(99, 66);
            this.btnTile12.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile12.Name = "btnTile12";
            this.btnTile12.Size = new System.Drawing.Size(32, 32);
            this.btnTile12.TabIndex = 11;
            this.btnTile12.Tag = "";
            this.btnTile12.UseVisualStyleBackColor = true;
            this.btnTile12.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile13
            // 
            this.btnTile13.AutoSize = true;
            this.btnTile13.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile13.Location = new System.Drawing.Point(0, 99);
            this.btnTile13.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile13.Name = "btnTile13";
            this.btnTile13.Size = new System.Drawing.Size(32, 32);
            this.btnTile13.TabIndex = 12;
            this.btnTile13.Tag = "";
            this.btnTile13.UseVisualStyleBackColor = true;
            this.btnTile13.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile14
            // 
            this.btnTile14.AutoSize = true;
            this.btnTile14.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile14.Location = new System.Drawing.Point(33, 99);
            this.btnTile14.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile14.Name = "btnTile14";
            this.btnTile14.Size = new System.Drawing.Size(32, 32);
            this.btnTile14.TabIndex = 15;
            this.btnTile14.Tag = "";
            this.btnTile14.UseVisualStyleBackColor = true;
            this.btnTile14.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile15
            // 
            this.btnTile15.AutoSize = true;
            this.btnTile15.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile15.Location = new System.Drawing.Point(66, 99);
            this.btnTile15.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile15.Name = "btnTile15";
            this.btnTile15.Size = new System.Drawing.Size(32, 32);
            this.btnTile15.TabIndex = 13;
            this.btnTile15.Tag = "";
            this.btnTile15.UseVisualStyleBackColor = true;
            this.btnTile15.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // btnTile16
            // 
            this.btnTile16.AutoSize = true;
            this.btnTile16.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnTile16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnlCurrentBlock.SetFlowBreak(this.btnTile16, true);
            this.btnTile16.Location = new System.Drawing.Point(99, 99);
            this.btnTile16.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnTile16.Name = "btnTile16";
            this.btnTile16.Size = new System.Drawing.Size(32, 32);
            this.btnTile16.TabIndex = 14;
            this.btnTile16.Tag = "";
            this.btnTile16.UseVisualStyleBackColor = true;
            this.btnTile16.Click += new System.EventHandler(this.CurrentBlockTiles_Click);
            // 
            // chkVFlip
            // 
            this.chkVFlip.AutoSize = true;
            this.chkVFlip.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkVFlip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVFlip.Location = new System.Drawing.Point(213, 143);
            this.chkVFlip.Name = "chkVFlip";
            this.chkVFlip.Size = new System.Drawing.Size(61, 18);
            this.chkVFlip.TabIndex = 23;
            this.chkVFlip.Text = "VFlip";
            this.ttTooltip.SetToolTip(this.chkVFlip, "Flip Vertically");
            this.chkVFlip.UseVisualStyleBackColor = true;
            this.chkVFlip.Click += new System.EventHandler(this.cbbTileIndex_SelectionChangeCommitted);
            // 
            // cbbPalIndex
            // 
            this.cbbPalIndex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbPalIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbPalIndex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPalIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPalIndex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPalIndex.ImageList = null;
            this.cbbPalIndex.Indent = 0;
            this.cbbPalIndex.ItemHeight = 24;
            this.cbbPalIndex.Location = new System.Drawing.Point(143, 143);
            this.cbbPalIndex.Name = "cbbPalIndex";
            this.cbbPalIndex.Size = new System.Drawing.Size(64, 30);
            this.cbbPalIndex.TabIndex = 18;
            this.ttTooltip.SetToolTip(this.cbbPalIndex, "Palette selection");
            this.cbbPalIndex.SelectionChangeCommitted += new System.EventHandler(this.cbbPalIndex_SelectionChangeCommitted);
            // 
            // cbbTileIndex
            // 
            this.cbbTileIndex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbTileIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbTileIndex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTileIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTileIndex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTileIndex.ImageList = null;
            this.cbbTileIndex.Indent = 0;
            this.cbbTileIndex.ItemHeight = 24;
            this.cbbTileIndex.Location = new System.Drawing.Point(3, 143);
            this.cbbTileIndex.Name = "cbbTileIndex";
            this.cbbTileIndex.Size = new System.Drawing.Size(134, 30);
            this.cbbTileIndex.TabIndex = 17;
            this.ttTooltip.SetToolTip(this.cbbTileIndex, "Tile selection");
            this.cbbTileIndex.SelectionChangeCommitted += new System.EventHandler(this.cbbTileIndex_SelectionChangeCommitted);
            // 
            // chkHFlip
            // 
            this.chkHFlip.AutoSize = true;
            this.chkHFlip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkHFlip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHFlip.Location = new System.Drawing.Point(213, 119);
            this.chkHFlip.Name = "chkHFlip";
            this.chkHFlip.Size = new System.Drawing.Size(61, 18);
            this.chkHFlip.TabIndex = 19;
            this.chkHFlip.Text = "HFlip";
            this.ttTooltip.SetToolTip(this.chkHFlip, "Flip horizontally");
            this.chkHFlip.UseVisualStyleBackColor = true;
            this.chkHFlip.Click += new System.EventHandler(this.cbbTileIndex_SelectionChangeCommitted);
            // 
            // btnCurrentTile
            // 
            this.btnCurrentTile.AutoSize = true;
            this.btnCurrentTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCurrentTile.Enabled = false;
            this.btnCurrentTile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCurrentTile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentTile.Location = new System.Drawing.Point(143, 107);
            this.btnCurrentTile.Name = "btnCurrentTile";
            this.btnCurrentTile.Size = new System.Drawing.Size(64, 30);
            this.btnCurrentTile.TabIndex = 25;
            this.btnCurrentTile.UseVisualStyleBackColor = true;
            // 
            // gridLevel
            // 
            this.gridLevel.AllowUserToAddRows = false;
            this.gridLevel.AllowUserToDeleteRows = false;
            this.gridLevel.AllowUserToResizeColumns = false;
            this.gridLevel.AllowUserToResizeRows = false;
            this.gridLevel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridLevel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLevel.ColumnHeadersVisible = false;
            this.gridLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLevel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLevel.Location = new System.Drawing.Point(0, 0);
            this.gridLevel.MultiSelect = false;
            this.gridLevel.Name = "gridLevel";
            this.gridLevel.ReadOnly = true;
            this.gridLevel.RowHeadersVisible = false;
            this.gridLevel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridLevel.ShowEditingIcon = false;
            this.gridLevel.Size = new System.Drawing.Size(680, 454);
            this.gridLevel.StandardTab = true;
            this.gridLevel.TabIndex = 0;
            this.gridLevel.VirtualMode = true;
            this.gridLevel.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLevel_CellMouseDown);
            this.gridLevel.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLevel_CellMouseEnter);
            this.gridLevel.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLevel_CellMouseLeave);
            this.gridLevel.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLevel_CellMouseMove);
            this.gridLevel.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLevel_CellMouseUp);
            this.gridLevel.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridLevel_CellPainting);
            this.gridLevel.SelectionChanged += new System.EventHandler(this.gridLevel_SelectionChanged);
            // 
            // dlgSaveRom
            // 
            this.dlgSaveRom.DefaultExt = "bin";
            this.dlgSaveRom.Filter = "Genesis ROM Files (*.bin)|*.bin|All Files (*.*)|*.*";
            this.dlgSaveRom.RestoreDirectory = true;
            this.dlgSaveRom.Title = "Where to save changed file?";
            // 
            // ttTooltip
            // 
            this.ttTooltip.AutoPopDelay = 10000;
            this.ttTooltip.InitialDelay = 5;
            this.ttTooltip.ReshowDelay = 100;
            // 
            // cbbLevels
            // 
            this.cbbLevels.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevels.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLevels.FormattingEnabled = true;
            this.cbbLevels.Location = new System.Drawing.Point(0, 24);
            this.cbbLevels.Name = "cbbLevels";
            this.cbbLevels.Size = new System.Drawing.Size(975, 22);
            this.cbbLevels.TabIndex = 8;
            this.ttTooltip.SetToolTip(this.cbbLevels, "Game levels");
            this.cbbLevels.SelectedIndexChanged += new System.EventHandler(this.cbbLevels_SelectedIndexChanged);
            // 
            // pbBossFace
            // 
            this.pbBossFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBossFace.ContextMenuStrip = this.mnuBossFace;
            this.pbBossFace.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBossFace.Location = new System.Drawing.Point(142, 3);
            this.pbBossFace.Name = "pbBossFace";
            this.pbBossFace.Size = new System.Drawing.Size(160, 112);
            this.pbBossFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBossFace.TabIndex = 3;
            this.pbBossFace.TabStop = false;
            this.ttTooltip.SetToolTip(this.pbBossFace, "Right Click to select new Boss Face or save as Bitmap");
            // 
            // mnuBossFace
            // 
            this.mnuBossFace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveFaceAsBmp,
            this.mnuLoadFaceFromBmp});
            this.mnuBossFace.Name = "mnuBossFace";
            this.mnuBossFace.Size = new System.Drawing.Size(192, 48);
            // 
            // mnuSaveFaceAsBmp
            // 
            this.mnuSaveFaceAsBmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuSaveFaceAsBmp.Name = "mnuSaveFaceAsBmp";
            this.mnuSaveFaceAsBmp.Size = new System.Drawing.Size(191, 22);
            this.mnuSaveFaceAsBmp.Text = "Save to Bitmap...";
            this.mnuSaveFaceAsBmp.Click += new System.EventHandler(this.mnuSaveFaceAsBmp_Click);
            // 
            // mnuLoadFaceFromBmp
            // 
            this.mnuLoadFaceFromBmp.Name = "mnuLoadFaceFromBmp";
            this.mnuLoadFaceFromBmp.Size = new System.Drawing.Size(191, 22);
            this.mnuLoadFaceFromBmp.Text = "Replace with Bitmap...";
            this.mnuLoadFaceFromBmp.Click += new System.EventHandler(this.mnuLoadFaceFromBmp_Click);
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbY.Location = new System.Drawing.Point(698, 24);
            this.tbY.Margin = new System.Windows.Forms.Padding(0);
            this.tbY.MaxLength = 4;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(60, 22);
            this.tbY.TabIndex = 3;
            this.ttTooltip.SetToolTip(this.tbY, "Y-Position for Current Screen (0 to 63)");
            this.tbY.TextChanged += new System.EventHandler(this.tbXY_TextChanged);
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXY_KeyPress);
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.Location = new System.Drawing.Point(0, 0);
            this.tbTime.Margin = new System.Windows.Forms.Padding(0);
            this.tbTime.MaxLength = 4;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(80, 22);
            this.tbTime.TabIndex = 0;
            this.ttTooltip.SetToolTip(this.tbTime, "Timer value (0 to 0x2000)");
            this.tbTime.TextChanged += new System.EventHandler(this.tbTime_TextChanged);
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // cbbEventType
            // 
            this.cbbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEventType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEventType.FormattingEnabled = true;
            this.cbbEventType.Location = new System.Drawing.Point(80, 0);
            this.cbbEventType.Margin = new System.Windows.Forms.Padding(0);
            this.cbbEventType.Name = "cbbEventType";
            this.cbbEventType.Size = new System.Drawing.Size(618, 22);
            this.cbbEventType.TabIndex = 1;
            this.ttTooltip.SetToolTip(this.cbbEventType, "Event type");
            this.cbbEventType.SelectedIndexChanged += new System.EventHandler(this.cbbEventType_SelectedIndexChanged);
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbX.Location = new System.Drawing.Point(698, 0);
            this.tbX.Margin = new System.Windows.Forms.Padding(0);
            this.tbX.MaxLength = 4;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(60, 22);
            this.tbX.TabIndex = 2;
            this.ttTooltip.SetToolTip(this.tbX, "X-Position for Current Screen (0 to 63)");
            this.tbX.TextChanged += new System.EventHandler(this.tbXY_TextChanged);
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXY_KeyPress);
            // 
            // lvDifficulty
            // 
            this.lvDifficulty.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvDifficulty.BackColor = System.Drawing.SystemColors.Control;
            this.lvDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDifficulty.CheckBoxes = true;
            this.lvDifficulty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNormal,
            this.chHard,
            this.chMania});
            this.lvDifficulty.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDifficulty.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lvDifficulty.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvDifficulty.LabelWrap = false;
            this.lvDifficulty.Location = new System.Drawing.Point(761, 3);
            this.lvDifficulty.Name = "lvDifficulty";
            this.pnlEvent.SetRowSpan(this.lvDifficulty, 3);
            this.lvDifficulty.Scrollable = false;
            this.lvDifficulty.ShowGroups = false;
            this.lvDifficulty.Size = new System.Drawing.Size(76, 60);
            this.lvDifficulty.TabIndex = 4;
            this.ttTooltip.SetToolTip(this.lvDifficulty, "Difficulty Mode in which this event will be executed");
            this.lvDifficulty.UseCompatibleStateImageBehavior = false;
            this.lvDifficulty.View = System.Windows.Forms.View.SmallIcon;
            // 
            // chNormal
            // 
            this.chNormal.Text = "";
            this.chNormal.Width = 40;
            // 
            // chHard
            // 
            this.chHard.Text = "";
            this.chHard.Width = 40;
            // 
            // chMania
            // 
            this.chMania.Text = "";
            this.chMania.Width = 40;
            // 
            // tbParams
            // 
            this.tbParams.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParams.Location = new System.Drawing.Point(698, 72);
            this.tbParams.Margin = new System.Windows.Forms.Padding(0);
            this.tbParams.MaxLength = 4;
            this.tbParams.Name = "tbParams";
            this.tbParams.Size = new System.Drawing.Size(60, 22);
            this.tbParams.TabIndex = 5;
            this.ttTooltip.SetToolTip(this.tbParams, "Additional parameter for this event.\r\n(Depends of event type)");
            this.tbParams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbParams_KeyPress);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpInitParams);
            this.tcMain.Controls.Add(this.tpEditor);
            this.tcMain.Controls.Add(this.tpEvents);
            this.tcMain.Controls.Add(this.tpCompression);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(0, 46);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(975, 517);
            this.tcMain.TabIndex = 7;
            // 
            // tpInitParams
            // 
            this.tpInitParams.BackColor = System.Drawing.SystemColors.Control;
            this.tpInitParams.Controls.Add(this.tblLevelParams);
            this.tpInitParams.Location = new System.Drawing.Point(4, 23);
            this.tpInitParams.Name = "tpInitParams";
            this.tpInitParams.Padding = new System.Windows.Forms.Padding(3);
            this.tpInitParams.Size = new System.Drawing.Size(967, 490);
            this.tpInitParams.TabIndex = 1;
            this.tpInitParams.Text = "Init Params";
            // 
            // tblLevelParams
            // 
            this.tblLevelParams.ColumnCount = 3;
            this.tblLevelParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLevelParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLevelParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLevelParams.Controls.Add(this.cbbBossMusicIndex, 1, 2);
            this.tblLevelParams.Controls.Add(this.lbBossMusicIndex, 0, 2);
            this.tblLevelParams.Controls.Add(this.tbWeakPointName, 1, 5);
            this.tblLevelParams.Controls.Add(this.lbWeakPointName, 0, 5);
            this.tblLevelParams.Controls.Add(this.tbTargetName, 1, 4);
            this.tblLevelParams.Controls.Add(this.lbTargetName, 0, 4);
            this.tblLevelParams.Controls.Add(this.lbStageName, 0, 3);
            this.tblLevelParams.Controls.Add(this.lbBossFace, 0, 0);
            this.tblLevelParams.Controls.Add(this.lbMusicIndex, 0, 1);
            this.tblLevelParams.Controls.Add(this.cbbMusicIndex, 1, 1);
            this.tblLevelParams.Controls.Add(this.pbBossFace, 1, 0);
            this.tblLevelParams.Controls.Add(this.tbStageName, 1, 3);
            this.tblLevelParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLevelParams.Location = new System.Drawing.Point(3, 3);
            this.tblLevelParams.Name = "tblLevelParams";
            this.tblLevelParams.RowCount = 7;
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLevelParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLevelParams.Size = new System.Drawing.Size(961, 484);
            this.tblLevelParams.TabIndex = 0;
            // 
            // cbbBossMusicIndex
            // 
            this.cbbBossMusicIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbBossMusicIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBossMusicIndex.FormattingEnabled = true;
            this.cbbBossMusicIndex.Items.AddRange(new object[] {
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cbbBossMusicIndex.Location = new System.Drawing.Point(142, 149);
            this.cbbBossMusicIndex.Name = "cbbBossMusicIndex";
            this.cbbBossMusicIndex.Size = new System.Drawing.Size(65, 22);
            this.cbbBossMusicIndex.TabIndex = 11;
            this.cbbBossMusicIndex.SelectionChangeCommitted += new System.EventHandler(this.cbbBossMusicIndex_SelectionChangeCommitted);
            // 
            // lbBossMusicIndex
            // 
            this.lbBossMusicIndex.AutoSize = true;
            this.lbBossMusicIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBossMusicIndex.Location = new System.Drawing.Point(3, 146);
            this.lbBossMusicIndex.Name = "lbBossMusicIndex";
            this.lbBossMusicIndex.Size = new System.Drawing.Size(133, 28);
            this.lbBossMusicIndex.TabIndex = 10;
            this.lbBossMusicIndex.Text = "Boss Music Number:";
            this.lbBossMusicIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWeakPointName
            // 
            this.tbWeakPointName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLevelParams.SetColumnSpan(this.tbWeakPointName, 2);
            this.tbWeakPointName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbWeakPointName.Location = new System.Drawing.Point(142, 233);
            this.tbWeakPointName.MaxLength = 12;
            this.tbWeakPointName.Name = "tbWeakPointName";
            this.tbWeakPointName.Size = new System.Drawing.Size(160, 22);
            this.tbWeakPointName.TabIndex = 9;
            this.tbWeakPointName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWeakPointName.TextChanged += new System.EventHandler(this.tbWeakPointName_TextChanged);
            this.tbWeakPointName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadingScreenTextBox_KeyPress);
            // 
            // lbWeakPointName
            // 
            this.lbWeakPointName.AutoSize = true;
            this.lbWeakPointName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWeakPointName.Location = new System.Drawing.Point(3, 230);
            this.lbWeakPointName.Name = "lbWeakPointName";
            this.lbWeakPointName.Size = new System.Drawing.Size(133, 28);
            this.lbWeakPointName.TabIndex = 8;
            this.lbWeakPointName.Text = "Weak Point Name:";
            this.lbWeakPointName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTargetName
            // 
            this.tbTargetName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLevelParams.SetColumnSpan(this.tbTargetName, 2);
            this.tbTargetName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTargetName.Location = new System.Drawing.Point(142, 205);
            this.tbTargetName.MaxLength = 12;
            this.tbTargetName.Name = "tbTargetName";
            this.tbTargetName.Size = new System.Drawing.Size(160, 22);
            this.tbTargetName.TabIndex = 7;
            this.tbTargetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTargetName.TextChanged += new System.EventHandler(this.tbTargetName_TextChanged);
            this.tbTargetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadingScreenTextBox_KeyPress);
            // 
            // lbTargetName
            // 
            this.lbTargetName.AutoSize = true;
            this.lbTargetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTargetName.Location = new System.Drawing.Point(3, 202);
            this.lbTargetName.Name = "lbTargetName";
            this.lbTargetName.Size = new System.Drawing.Size(133, 28);
            this.lbTargetName.TabIndex = 6;
            this.lbTargetName.Text = "Target Name:";
            this.lbTargetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStageName
            // 
            this.lbStageName.AutoSize = true;
            this.lbStageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStageName.Location = new System.Drawing.Point(3, 174);
            this.lbStageName.Name = "lbStageName";
            this.lbStageName.Size = new System.Drawing.Size(133, 28);
            this.lbStageName.TabIndex = 4;
            this.lbStageName.Text = "Stage Name:";
            this.lbStageName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBossFace
            // 
            this.lbBossFace.AutoSize = true;
            this.lbBossFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBossFace.Location = new System.Drawing.Point(3, 0);
            this.lbBossFace.Name = "lbBossFace";
            this.lbBossFace.Size = new System.Drawing.Size(133, 118);
            this.lbBossFace.TabIndex = 2;
            this.lbBossFace.Text = "Boss Face:";
            this.lbBossFace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMusicIndex
            // 
            this.lbMusicIndex.AutoSize = true;
            this.lbMusicIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMusicIndex.Location = new System.Drawing.Point(3, 118);
            this.lbMusicIndex.Name = "lbMusicIndex";
            this.lbMusicIndex.Size = new System.Drawing.Size(133, 28);
            this.lbMusicIndex.TabIndex = 0;
            this.lbMusicIndex.Text = "Music Number:";
            this.lbMusicIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbMusicIndex
            // 
            this.cbbMusicIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbMusicIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMusicIndex.FormattingEnabled = true;
            this.cbbMusicIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbbMusicIndex.Location = new System.Drawing.Point(142, 121);
            this.cbbMusicIndex.Name = "cbbMusicIndex";
            this.cbbMusicIndex.Size = new System.Drawing.Size(65, 22);
            this.cbbMusicIndex.TabIndex = 1;
            this.cbbMusicIndex.SelectionChangeCommitted += new System.EventHandler(this.cbbMusicIndex_SelectionChangeCommitted);
            // 
            // tbStageName
            // 
            this.tbStageName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tblLevelParams.SetColumnSpan(this.tbStageName, 2);
            this.tbStageName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbStageName.Location = new System.Drawing.Point(142, 177);
            this.tbStageName.MaxLength = 12;
            this.tbStageName.Name = "tbStageName";
            this.tbStageName.Size = new System.Drawing.Size(160, 22);
            this.tbStageName.TabIndex = 5;
            this.tbStageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStageName.TextChanged += new System.EventHandler(this.tbStageName_TextChanged);
            this.tbStageName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadingScreenTextBox_KeyPress);
            // 
            // tpEditor
            // 
            this.tpEditor.BackColor = System.Drawing.SystemColors.Control;
            this.tpEditor.Controls.Add(this.pnlMain);
            this.tpEditor.Controls.Add(this.pnlEditorTop);
            this.tpEditor.Location = new System.Drawing.Point(4, 23);
            this.tpEditor.Name = "tpEditor";
            this.tpEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditor.Size = new System.Drawing.Size(967, 490);
            this.tpEditor.TabIndex = 0;
            this.tpEditor.Text = "Level Editor";
            // 
            // tpEvents
            // 
            this.tpEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tpEvents.Controls.Add(this.lvEvents);
            this.tpEvents.Controls.Add(this.pnlEvent);
            this.tpEvents.Location = new System.Drawing.Point(4, 23);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(967, 490);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chID,
            this.chXCoord,
            this.chYCoord,
            this.chDifficulty,
            this.chParams,
            this.chDescription});
            this.lvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEvents.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new System.Drawing.Point(3, 3);
            this.lvEvents.MultiSelect = false;
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(961, 388);
            this.lvEvents.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEvents.TabIndex = 0;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            this.lvEvents.SelectedIndexChanged += new System.EventHandler(this.lvEvents_SelectedIndexChanged);
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 71;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chID.Width = 49;
            // 
            // chXCoord
            // 
            this.chXCoord.Text = "X";
            this.chXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chXCoord.Width = 50;
            // 
            // chYCoord
            // 
            this.chYCoord.Text = "Y";
            this.chYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chYCoord.Width = 50;
            // 
            // chDifficulty
            // 
            this.chDifficulty.Text = "Difficulty";
            this.chDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDifficulty.Width = 91;
            // 
            // chParams
            // 
            this.chParams.Text = "Parameters";
            this.chParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chParams.Width = 96;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 396;
            // 
            // pnlEvent
            // 
            this.pnlEvent.AutoSize = true;
            this.pnlEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEvent.ColumnCount = 6;
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlEvent.Controls.Add(this.btnDeleteEvent, 0, 3);
            this.pnlEvent.Controls.Add(this.btnReplaceEvent, 0, 2);
            this.pnlEvent.Controls.Add(this.tbTime, 0, 0);
            this.pnlEvent.Controls.Add(this.cbbEventType, 1, 0);
            this.pnlEvent.Controls.Add(this.tbX, 2, 0);
            this.pnlEvent.Controls.Add(this.lvDifficulty, 4, 0);
            this.pnlEvent.Controls.Add(this.btnAddEvent, 0, 1);
            this.pnlEvent.Controls.Add(this.tbEventDescription, 1, 1);
            this.pnlEvent.Controls.Add(this.tbY, 2, 1);
            this.pnlEvent.Controls.Add(this.tbParams, 2, 3);
            this.pnlEvent.Controls.Add(this.btnClearEvents, 5, 0);
            this.pnlEvent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEvent.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.pnlEvent.Location = new System.Drawing.Point(3, 391);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.RowCount = 5;
            this.pnlEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlEvent.Size = new System.Drawing.Size(961, 96);
            this.pnlEvent.TabIndex = 2;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.AutoSize = true;
            this.btnDeleteEvent.Location = new System.Drawing.Point(0, 72);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(80, 24);
            this.btnDeleteEvent.TabIndex = 8;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnReplaceEvent
            // 
            this.btnReplaceEvent.AutoSize = true;
            this.btnReplaceEvent.Location = new System.Drawing.Point(0, 48);
            this.btnReplaceEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnReplaceEvent.Name = "btnReplaceEvent";
            this.btnReplaceEvent.Size = new System.Drawing.Size(80, 24);
            this.btnReplaceEvent.TabIndex = 7;
            this.btnReplaceEvent.Text = "Replace";
            this.btnReplaceEvent.UseVisualStyleBackColor = true;
            this.btnReplaceEvent.Click += new System.EventHandler(this.btnReplaceEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.AutoSize = true;
            this.btnAddEvent.Location = new System.Drawing.Point(0, 24);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(80, 24);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // tbEventDescription
            // 
            this.tbEventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEventDescription.Location = new System.Drawing.Point(80, 24);
            this.tbEventDescription.Margin = new System.Windows.Forms.Padding(0);
            this.tbEventDescription.Multiline = true;
            this.tbEventDescription.Name = "tbEventDescription";
            this.tbEventDescription.ReadOnly = true;
            this.pnlEvent.SetRowSpan(this.tbEventDescription, 3);
            this.tbEventDescription.Size = new System.Drawing.Size(618, 72);
            this.tbEventDescription.TabIndex = 10;
            // 
            // btnClearEvents
            // 
            this.btnClearEvents.AutoSize = true;
            this.btnClearEvents.Location = new System.Drawing.Point(840, 0);
            this.btnClearEvents.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearEvents.Name = "btnClearEvents";
            this.btnClearEvents.Size = new System.Drawing.Size(87, 24);
            this.btnClearEvents.TabIndex = 9;
            this.btnClearEvents.Text = "Clear List";
            this.btnClearEvents.UseVisualStyleBackColor = true;
            this.btnClearEvents.Click += new System.EventHandler(this.btnClearEvents_Click);
            // 
            // dlgOpenBmp
            // 
            this.dlgOpenBmp.DefaultExt = "bmp";
            this.dlgOpenBmp.Filter = "BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            this.dlgOpenBmp.RestoreDirectory = true;
            this.dlgOpenBmp.Title = "Please, choose your 80x56 bitmap...";
            // 
            // dlgSaveBmp
            // 
            this.dlgSaveBmp.DefaultExt = "bmp";
            this.dlgSaveBmp.Filter = "BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            this.dlgSaveBmp.RestoreDirectory = true;
            this.dlgSaveBmp.Title = "Where to save your Bitmap...";
            // 
            // tpCompression
            // 
            this.tpCompression.Controls.Add(this.tcCompression);
            this.tpCompression.Location = new System.Drawing.Point(4, 23);
            this.tpCompression.Name = "tpCompression";
            this.tpCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompression.Size = new System.Drawing.Size(967, 490);
            this.tpCompression.TabIndex = 3;
            this.tpCompression.Text = "Compression";
            this.tpCompression.UseVisualStyleBackColor = true;
            // 
            // tcCompression
            // 
            this.tcCompression.Controls.Add(this.tpRleCompression);
            this.tcCompression.Controls.Add(this.tpLzhufCompression);
            this.tcCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCompression.Location = new System.Drawing.Point(3, 3);
            this.tcCompression.Name = "tcCompression";
            this.tcCompression.SelectedIndex = 0;
            this.tcCompression.Size = new System.Drawing.Size(961, 484);
            this.tcCompression.TabIndex = 0;
            // 
            // tpRleCompression
            // 
            this.tpRleCompression.Controls.Add(this.tblRleData);
            this.tpRleCompression.Controls.Add(this.pnlRleButtons);
            this.tpRleCompression.Location = new System.Drawing.Point(4, 23);
            this.tpRleCompression.Name = "tpRleCompression";
            this.tpRleCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tpRleCompression.Size = new System.Drawing.Size(953, 457);
            this.tpRleCompression.TabIndex = 0;
            this.tpRleCompression.Text = "RLE";
            this.tpRleCompression.UseVisualStyleBackColor = true;
            // 
            // tpLzhufCompression
            // 
            this.tpLzhufCompression.Location = new System.Drawing.Point(4, 23);
            this.tpLzhufCompression.Name = "tpLzhufCompression";
            this.tpLzhufCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tpLzhufCompression.Size = new System.Drawing.Size(953, 457);
            this.tpLzhufCompression.TabIndex = 1;
            this.tpLzhufCompression.Text = "LZHUFF";
            this.tpLzhufCompression.UseVisualStyleBackColor = true;
            // 
            // tblRleData
            // 
            this.tblRleData.AllowUserToAddRows = false;
            this.tblRleData.AllowUserToDeleteRows = false;
            this.tblRleData.AllowUserToResizeColumns = false;
            this.tblRleData.AllowUserToResizeRows = false;
            this.tblRleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblRleData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblRleData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRleData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRleData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRleIdx,
            this.clRleTableOffset,
            this.clRleOffset,
            this.clRleDestOffset,
            this.clRleCmpSize,
            this.clRleUnpSize,
            this.clRleDescr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRleData.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRleData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRleData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblRleData.GridColor = System.Drawing.SystemColors.Control;
            this.tblRleData.Location = new System.Drawing.Point(3, 42);
            this.tblRleData.Margin = new System.Windows.Forms.Padding(4);
            this.tblRleData.MultiSelect = false;
            this.tblRleData.Name = "tblRleData";
            this.tblRleData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRleData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblRleData.RowHeadersVisible = false;
            this.tblRleData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRleData.ShowCellErrors = false;
            this.tblRleData.ShowEditingIcon = false;
            this.tblRleData.ShowRowErrors = false;
            this.tblRleData.Size = new System.Drawing.Size(947, 412);
            this.tblRleData.TabIndex = 2;
            // 
            // clRleIdx
            // 
            this.clRleIdx.HeaderText = "#";
            this.clRleIdx.Name = "clRleIdx";
            this.clRleIdx.ReadOnly = true;
            this.clRleIdx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clRleIdx.Width = 39;
            // 
            // clRleTableOffset
            // 
            this.clRleTableOffset.HeaderText = "Table Offset";
            this.clRleTableOffset.Name = "clRleTableOffset";
            this.clRleTableOffset.ReadOnly = true;
            this.clRleTableOffset.Width = 106;
            // 
            // clRleOffset
            // 
            this.clRleOffset.HeaderText = "Data Offset";
            this.clRleOffset.Name = "clRleOffset";
            this.clRleOffset.ReadOnly = true;
            // 
            // clRleDestOffset
            // 
            this.clRleDestOffset.HeaderText = "Dest Offset";
            this.clRleDestOffset.Name = "clRleDestOffset";
            this.clRleDestOffset.ReadOnly = true;
            // 
            // clRleCmpSize
            // 
            this.clRleCmpSize.HeaderText = "Compressed Size";
            this.clRleCmpSize.Name = "clRleCmpSize";
            this.clRleCmpSize.ReadOnly = true;
            this.clRleCmpSize.Width = 125;
            // 
            // clRleUnpSize
            // 
            this.clRleUnpSize.HeaderText = "Unpacked Size";
            this.clRleUnpSize.Name = "clRleUnpSize";
            this.clRleUnpSize.ReadOnly = true;
            this.clRleUnpSize.Width = 113;
            // 
            // clRleDescr
            // 
            this.clRleDescr.HeaderText = "Description";
            this.clRleDescr.Name = "clRleDescr";
            this.clRleDescr.ReadOnly = true;
            this.clRleDescr.Width = 109;
            // 
            // pnlRleButtons
            // 
            this.pnlRleButtons.ColumnCount = 2;
            this.pnlRleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlRleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.pnlRleButtons.Controls.Add(this.btnRleImport, 1, 0);
            this.pnlRleButtons.Controls.Add(this.btnRleExtract, 0, 0);
            this.pnlRleButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRleButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlRleButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRleButtons.Name = "pnlRleButtons";
            this.pnlRleButtons.RowCount = 1;
            this.pnlRleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRleButtons.Size = new System.Drawing.Size(947, 39);
            this.pnlRleButtons.TabIndex = 3;
            // 
            // btnRleImport
            // 
            this.btnRleImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRleImport.Location = new System.Drawing.Point(100, 4);
            this.btnRleImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnRleImport.Name = "btnRleImport";
            this.btnRleImport.Size = new System.Drawing.Size(88, 31);
            this.btnRleImport.TabIndex = 1;
            this.btnRleImport.Text = "Import";
            this.btnRleImport.UseVisualStyleBackColor = true;
            // 
            // btnRleExtract
            // 
            this.btnRleExtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRleExtract.Location = new System.Drawing.Point(4, 4);
            this.btnRleExtract.Margin = new System.Windows.Forms.Padding(4);
            this.btnRleExtract.Name = "btnRleExtract";
            this.btnRleExtract.Size = new System.Drawing.Size(88, 31);
            this.btnRleExtract.TabIndex = 0;
            this.btnRleExtract.Text = "Extract";
            this.btnRleExtract.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 563);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.cbbLevels);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlEditorTop.ResumeLayout(false);
            this.pnlEditorTop.PerformLayout();
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel1.PerformLayout();
            this.pnlMain.Panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlBlockInfo.ResumeLayout(false);
            this.pnlBlockInfo.PerformLayout();
            this.pnlCurrentBlock.ResumeLayout(false);
            this.pnlCurrentBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBossFace)).EndInit();
            this.mnuBossFace.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpInitParams.ResumeLayout(false);
            this.tblLevelParams.ResumeLayout(false);
            this.tblLevelParams.PerformLayout();
            this.tpEditor.ResumeLayout(false);
            this.tpEditor.PerformLayout();
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.pnlEvent.ResumeLayout(false);
            this.pnlEvent.PerformLayout();
            this.tpCompression.ResumeLayout(false);
            this.tcCompression.ResumeLayout(false);
            this.tpRleCompression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRleData)).EndInit();
            this.pnlRleButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuROM;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenROM;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.OpenFileDialog dlgOpenRom;
        private System.Windows.Forms.FlowLayoutPanel pnlEditorTop;
        private System.Windows.Forms.SplitContainer pnlMain;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseROM;
        private System.Windows.Forms.RadioButton rbPlaneA;
        private System.Windows.Forms.RadioButton rbPlaneB;
        private System.Windows.Forms.DataGridView gridLevel;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.SaveFileDialog dlgSaveRom;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.TableLayoutPanel pnlBlockInfo;
        private ImageComboBox.ImageComboBox cbbTileIndex;
        private ImageComboBox.ImageComboBox cbbPalIndex;
        private System.Windows.Forms.CheckBox chkHFlip;
        private System.Windows.Forms.CheckBox chkVFlip;
        private System.Windows.Forms.ToolTip ttTooltip;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveROMAs;
        private System.Windows.Forms.Button btnCurrentTile;
        private System.Windows.Forms.FlowLayoutPanel pnlBlocks;
        private System.Windows.Forms.FlowLayoutPanel pnlCurrentBlock;
        private System.Windows.Forms.Button btnTile1;
        private System.Windows.Forms.Button btnTile2;
        private System.Windows.Forms.Button btnTile3;
        private System.Windows.Forms.Button btnTile4;
        private System.Windows.Forms.Button btnTile5;
        private System.Windows.Forms.Button btnTile6;
        private System.Windows.Forms.Button btnTile7;
        private System.Windows.Forms.Button btnTile8;
        private System.Windows.Forms.Button btnTile9;
        private System.Windows.Forms.Button btnTile10;
        private System.Windows.Forms.Button btnTile11;
        private System.Windows.Forms.Button btnTile12;
        private System.Windows.Forms.Button btnTile13;
        private System.Windows.Forms.Button btnTile14;
        private System.Windows.Forms.Button btnTile15;
        private System.Windows.Forms.Button btnTile16;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEditor;
        private System.Windows.Forms.TabPage tpInitParams;
        private System.Windows.Forms.TableLayoutPanel tblLevelParams;
        private System.Windows.Forms.Label lbMusicIndex;
        private System.Windows.Forms.ComboBox cbbMusicIndex;
        private System.Windows.Forms.Label lbBossFace;
        private System.Windows.Forms.TextBox tbWeakPointName;
        private System.Windows.Forms.Label lbWeakPointName;
        private System.Windows.Forms.TextBox tbTargetName;
        private System.Windows.Forms.Label lbTargetName;
        private System.Windows.Forms.Label lbStageName;
        private System.Windows.Forms.PictureBox pbBossFace;
        private System.Windows.Forms.TextBox tbStageName;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.ComboBox cbbLevels;
        private System.Windows.Forms.OpenFileDialog dlgOpenBmp;
        private System.Windows.Forms.ContextMenuStrip mnuBossFace;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveFaceAsBmp;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadFaceFromBmp;
        private System.Windows.Forms.SaveFileDialog dlgSaveBmp;
        private System.Windows.Forms.ComboBox cbbBossMusicIndex;
        private System.Windows.Forms.Label lbBossMusicIndex;
        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chXCoord;
        private System.Windows.Forms.ColumnHeader chYCoord;
        private System.Windows.Forms.ColumnHeader chDifficulty;
        private System.Windows.Forms.ColumnHeader chParams;
        private System.Windows.Forms.TableLayoutPanel pnlEvent;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.ComboBox cbbEventType;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.ListView lvDifficulty;
        private System.Windows.Forms.ColumnHeader chNormal;
        private System.Windows.Forms.ColumnHeader chHard;
        private System.Windows.Forms.ColumnHeader chMania;
        private System.Windows.Forms.TextBox tbParams;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnReplaceEvent;
        private System.Windows.Forms.Button btnClearEvents;
        private System.Windows.Forms.TextBox tbEventDescription;
        private System.Windows.Forms.TabPage tpCompression;
        private System.Windows.Forms.TabControl tcCompression;
        private System.Windows.Forms.TabPage tpRleCompression;
        private System.Windows.Forms.TabPage tpLzhufCompression;
        private System.Windows.Forms.DataGridView tblRleData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleTableOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleDestOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleCmpSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleUnpSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRleDescr;
        private System.Windows.Forms.TableLayoutPanel pnlRleButtons;
        private System.Windows.Forms.Button btnRleImport;
        private System.Windows.Forms.Button btnRleExtract;
    }
}

