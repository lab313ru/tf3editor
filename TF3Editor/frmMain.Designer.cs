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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Normal");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Hard");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Mania");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlEditorTop = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tpCompression = new System.Windows.Forms.TabPage();
            this.tcCompression = new System.Windows.Forms.TabControl();
            this.tpRleCompression = new System.Windows.Forms.TabPage();
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
            this.tpLzhufCompression = new System.Windows.Forms.TabPage();
            this.dlgOpenBmp = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveBmp = new System.Windows.Forms.SaveFileDialog();
            this.tblEditorButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportTmx = new System.Windows.Forms.Button();
            this.btnTmxExport = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
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
            this.tblEditorButtons.SuspendLayout();
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
            this.pbBossFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            this.lvDifficulty.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
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
            this.tpEditor.Controls.Add(this.tblEditorButtons);
            this.tpEditor.Controls.Add(this.pnlEditorTop);
            this.tpEditor.Location = new System.Drawing.Point(4, 23);
            this.tpEditor.Name = "tpEditor";
            this.tpEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditor.Size = new System.Drawing.Size(967, 490);
            this.tpEditor.TabIndex = 0;
            this.tpEditor.Text = "Level Editor";
            // 
            // pnlEditorTop
            // 
            this.pnlEditorTop.AutoSize = true;
            this.pnlEditorTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEditorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditorTop.Location = new System.Drawing.Point(3, 3);
            this.pnlEditorTop.Name = "pnlEditorTop";
            this.pnlEditorTop.Size = new System.Drawing.Size(961, 0);
            this.pnlEditorTop.TabIndex = 5;
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
            // tblRleData
            // 
            this.tblRleData.AllowUserToAddRows = false;
            this.tblRleData.AllowUserToDeleteRows = false;
            this.tblRleData.AllowUserToResizeColumns = false;
            this.tblRleData.AllowUserToResizeRows = false;
            this.tblRleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tblRleData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblRleData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRleData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblRleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRleData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRleIdx,
            this.clRleTableOffset,
            this.clRleOffset,
            this.clRleDestOffset,
            this.clRleCmpSize,
            this.clRleUnpSize,
            this.clRleDescr});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRleData.DefaultCellStyle = dataGridViewCellStyle8;
            this.tblRleData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRleData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblRleData.GridColor = System.Drawing.SystemColors.Control;
            this.tblRleData.Location = new System.Drawing.Point(3, 42);
            this.tblRleData.Margin = new System.Windows.Forms.Padding(4);
            this.tblRleData.MultiSelect = false;
            this.tblRleData.Name = "tblRleData";
            this.tblRleData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRleData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            // tblEditorButtons
            // 
            this.tblEditorButtons.ColumnCount = 2;
            this.tblEditorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEditorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEditorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblEditorButtons.Controls.Add(this.btnImportTmx, 1, 0);
            this.tblEditorButtons.Controls.Add(this.btnTmxExport, 0, 0);
            this.tblEditorButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblEditorButtons.Location = new System.Drawing.Point(3, 3);
            this.tblEditorButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblEditorButtons.Name = "tblEditorButtons";
            this.tblEditorButtons.RowCount = 1;
            this.tblEditorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditorButtons.Size = new System.Drawing.Size(961, 39);
            this.tblEditorButtons.TabIndex = 6;
            // 
            // btnImportTmx
            // 
            this.btnImportTmx.AutoSize = true;
            this.btnImportTmx.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportTmx.Location = new System.Drawing.Point(120, 4);
            this.btnImportTmx.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportTmx.Name = "btnImportTmx";
            this.btnImportTmx.Size = new System.Drawing.Size(122, 31);
            this.btnImportTmx.TabIndex = 1;
            this.btnImportTmx.Text = "Import from TMX";
            this.btnImportTmx.UseVisualStyleBackColor = true;
            // 
            // btnTmxExport
            // 
            this.btnTmxExport.AutoSize = true;
            this.btnTmxExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTmxExport.Location = new System.Drawing.Point(4, 4);
            this.btnTmxExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnTmxExport.Name = "btnTmxExport";
            this.btnTmxExport.Size = new System.Drawing.Size(108, 31);
            this.btnTmxExport.TabIndex = 0;
            this.btnTmxExport.Text = "Export to TMX";
            this.btnTmxExport.UseVisualStyleBackColor = true;
            this.btnTmxExport.Click += new System.EventHandler(this.btnTmxExport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 563);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.cbbLevels);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
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
            this.tblEditorButtons.ResumeLayout(false);
            this.tblEditorButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuROM;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenROM;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.OpenFileDialog dlgOpenRom;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseROM;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.SaveFileDialog dlgSaveRom;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolTip ttTooltip;
        private System.Windows.Forms.ToolStripSeparator mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveROMAs;
        private System.Windows.Forms.TabControl tcMain;
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
        private System.Windows.Forms.TabPage tpEditor;
        private System.Windows.Forms.FlowLayoutPanel pnlEditorTop;
        private System.Windows.Forms.TableLayoutPanel tblEditorButtons;
        private System.Windows.Forms.Button btnImportTmx;
        private System.Windows.Forms.Button btnTmxExport;
    }
}

