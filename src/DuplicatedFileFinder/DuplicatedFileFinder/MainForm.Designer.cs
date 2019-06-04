namespace DuplicatedFileFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HorizontalSplitter = new System.Windows.Forms.SplitContainer();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.chbSizeFilter = new System.Windows.Forms.CheckBox();
            this.cbbSizeUnits = new System.Windows.Forms.ComboBox();
            this.txtSizeValue = new System.Windows.Forms.TextBox();
            this.cbbSizeCondition = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAttrSystem = new System.Windows.Forms.CheckBox();
            this.chbAttrHidden = new System.Windows.Forms.CheckBox();
            this.chbAttrReadonnly = new System.Windows.Forms.CheckBox();
            this.chbAttrTemp = new System.Windows.Forms.CheckBox();
            this.chbAttrArchive = new System.Windows.Forms.CheckBox();
            this.chbAttrNormal = new System.Windows.Forms.CheckBox();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.chbModifyDate = new System.Windows.Forms.CheckBox();
            this.chbAttributes = new System.Windows.Forms.CheckBox();
            this.chbContent = new System.Windows.Forms.CheckBox();
            this.chbSize = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwSourceFolders = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.ResultSplitter = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwItems = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colFileNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).BeginInit();
            this.HorizontalSplitter.Panel1.SuspendLayout();
            this.HorizontalSplitter.Panel2.SuspendLayout();
            this.HorizontalSplitter.SuspendLayout();
            this.grbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSplitter)).BeginInit();
            this.ResultSplitter.Panel1.SuspendLayout();
            this.ResultSplitter.Panel2.SuspendLayout();
            this.ResultSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // HorizontalSplitter
            // 
            this.HorizontalSplitter.BackColor = System.Drawing.Color.Silver;
            this.HorizontalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HorizontalSplitter.Location = new System.Drawing.Point(0, 0);
            this.HorizontalSplitter.Name = "HorizontalSplitter";
            this.HorizontalSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSplitter.Panel1
            // 
            this.HorizontalSplitter.Panel1.BackColor = System.Drawing.Color.White;
            this.HorizontalSplitter.Panel1.Controls.Add(this.btnAddFolder);
            this.HorizontalSplitter.Panel1.Controls.Add(this.grbFilter);
            this.HorizontalSplitter.Panel1.Controls.Add(this.grbSearchCriteria);
            this.HorizontalSplitter.Panel1.Controls.Add(this.label1);
            this.HorizontalSplitter.Panel1.Controls.Add(this.lvwSourceFolders);
            this.HorizontalSplitter.Panel1MinSize = 150;
            // 
            // HorizontalSplitter.Panel2
            // 
            this.HorizontalSplitter.Panel2.BackColor = System.Drawing.Color.White;
            this.HorizontalSplitter.Panel2.Controls.Add(this.progressBar);
            this.HorizontalSplitter.Panel2.Controls.Add(this.btnStop);
            this.HorizontalSplitter.Panel2.Controls.Add(this.btnStart);
            this.HorizontalSplitter.Panel2.Controls.Add(this.ResultSplitter);
            this.HorizontalSplitter.Panel2MinSize = 300;
            this.HorizontalSplitter.Size = new System.Drawing.Size(808, 521);
            this.HorizontalSplitter.SplitterDistance = 160;
            this.HorizontalSplitter.SplitterWidth = 6;
            this.HorizontalSplitter.TabIndex = 0;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.Location = new System.Drawing.Point(361, 24);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(24, 24);
            this.btnAddFolder.TabIndex = 6;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.BtnAddFolder_Click);
            // 
            // grbFilter
            // 
            this.grbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFilter.Controls.Add(this.chbSizeFilter);
            this.grbFilter.Controls.Add(this.cbbSizeUnits);
            this.grbFilter.Controls.Add(this.txtSizeValue);
            this.grbFilter.Controls.Add(this.cbbSizeCondition);
            this.grbFilter.Controls.Add(this.groupBox1);
            this.grbFilter.Controls.Add(this.txtExtensions);
            this.grbFilter.Controls.Add(this.label2);
            this.grbFilter.Location = new System.Drawing.Point(391, 5);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(280, 153);
            this.grbFilter.TabIndex = 5;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // chbSizeFilter
            // 
            this.chbSizeFilter.AutoSize = true;
            this.chbSizeFilter.Location = new System.Drawing.Point(21, 127);
            this.chbSizeFilter.Name = "chbSizeFilter";
            this.chbSizeFilter.Size = new System.Drawing.Size(46, 17);
            this.chbSizeFilter.TabIndex = 7;
            this.chbSizeFilter.Text = "Size";
            this.chbSizeFilter.UseVisualStyleBackColor = true;
            this.chbSizeFilter.CheckedChanged += new System.EventHandler(this.ChbSizeFilter_CheckedChanged);
            // 
            // cbbSizeUnits
            // 
            this.cbbSizeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSizeUnits.FormattingEnabled = true;
            this.cbbSizeUnits.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB"});
            this.cbbSizeUnits.Location = new System.Drawing.Point(204, 125);
            this.cbbSizeUnits.Name = "cbbSizeUnits";
            this.cbbSizeUnits.Size = new System.Drawing.Size(69, 21);
            this.cbbSizeUnits.TabIndex = 6;
            this.cbbSizeUnits.SelectedIndexChanged += new System.EventHandler(this.CbbSizeUnits_SelectedIndexChanged);
            // 
            // txtSizeValue
            // 
            this.txtSizeValue.Location = new System.Drawing.Point(108, 125);
            this.txtSizeValue.MaxLength = 12;
            this.txtSizeValue.Name = "txtSizeValue";
            this.txtSizeValue.Size = new System.Drawing.Size(96, 20);
            this.txtSizeValue.TabIndex = 5;
            this.txtSizeValue.Text = "0";
            this.txtSizeValue.TextChanged += new System.EventHandler(this.TxtSizeValue_TextChanged);
            this.txtSizeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSizeValue_KeyPress);
            // 
            // cbbSizeCondition
            // 
            this.cbbSizeCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSizeCondition.FormattingEnabled = true;
            this.cbbSizeCondition.Items.AddRange(new object[] {
            "<",
            "=",
            ">"});
            this.cbbSizeCondition.Location = new System.Drawing.Point(68, 125);
            this.cbbSizeCondition.Name = "cbbSizeCondition";
            this.cbbSizeCondition.Size = new System.Drawing.Size(40, 21);
            this.cbbSizeCondition.TabIndex = 4;
            this.cbbSizeCondition.SelectedIndexChanged += new System.EventHandler(this.CbbSizeCondition_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAttrSystem);
            this.groupBox1.Controls.Add(this.chbAttrHidden);
            this.groupBox1.Controls.Add(this.chbAttrReadonnly);
            this.groupBox1.Controls.Add(this.chbAttrTemp);
            this.groupBox1.Controls.Add(this.chbAttrArchive);
            this.groupBox1.Controls.Add(this.chbAttrNormal);
            this.groupBox1.Location = new System.Drawing.Point(19, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // chbAttrSystem
            // 
            this.chbAttrSystem.AutoSize = true;
            this.chbAttrSystem.Checked = true;
            this.chbAttrSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrSystem.Location = new System.Drawing.Point(170, 44);
            this.chbAttrSystem.Name = "chbAttrSystem";
            this.chbAttrSystem.Size = new System.Drawing.Size(60, 17);
            this.chbAttrSystem.TabIndex = 5;
            this.chbAttrSystem.Text = "System";
            this.chbAttrSystem.UseVisualStyleBackColor = true;
            this.chbAttrSystem.CheckedChanged += new System.EventHandler(this.ChbAttrSystem_CheckedChanged);
            // 
            // chbAttrHidden
            // 
            this.chbAttrHidden.AutoSize = true;
            this.chbAttrHidden.Checked = true;
            this.chbAttrHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrHidden.Location = new System.Drawing.Point(100, 44);
            this.chbAttrHidden.Name = "chbAttrHidden";
            this.chbAttrHidden.Size = new System.Drawing.Size(60, 17);
            this.chbAttrHidden.TabIndex = 4;
            this.chbAttrHidden.Text = "Hidden";
            this.chbAttrHidden.UseVisualStyleBackColor = true;
            this.chbAttrHidden.CheckedChanged += new System.EventHandler(this.ChbAttrHidden_CheckedChanged);
            // 
            // chbAttrReadonnly
            // 
            this.chbAttrReadonnly.AutoSize = true;
            this.chbAttrReadonnly.Checked = true;
            this.chbAttrReadonnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrReadonnly.Location = new System.Drawing.Point(15, 44);
            this.chbAttrReadonnly.Name = "chbAttrReadonnly";
            this.chbAttrReadonnly.Size = new System.Drawing.Size(74, 17);
            this.chbAttrReadonnly.TabIndex = 3;
            this.chbAttrReadonnly.Text = "Read-only";
            this.chbAttrReadonnly.UseVisualStyleBackColor = true;
            this.chbAttrReadonnly.CheckedChanged += new System.EventHandler(this.ChbAttrReadonnly_CheckedChanged);
            // 
            // chbAttrTemp
            // 
            this.chbAttrTemp.AutoSize = true;
            this.chbAttrTemp.Checked = true;
            this.chbAttrTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrTemp.Location = new System.Drawing.Point(170, 20);
            this.chbAttrTemp.Name = "chbAttrTemp";
            this.chbAttrTemp.Size = new System.Drawing.Size(76, 17);
            this.chbAttrTemp.TabIndex = 2;
            this.chbAttrTemp.Text = "Temporary";
            this.chbAttrTemp.UseVisualStyleBackColor = true;
            this.chbAttrTemp.CheckedChanged += new System.EventHandler(this.ChbAttrTemp_CheckedChanged);
            // 
            // chbAttrArchive
            // 
            this.chbAttrArchive.AutoSize = true;
            this.chbAttrArchive.Checked = true;
            this.chbAttrArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrArchive.Location = new System.Drawing.Point(100, 20);
            this.chbAttrArchive.Name = "chbAttrArchive";
            this.chbAttrArchive.Size = new System.Drawing.Size(62, 17);
            this.chbAttrArchive.TabIndex = 1;
            this.chbAttrArchive.Text = "Archive";
            this.chbAttrArchive.UseVisualStyleBackColor = true;
            this.chbAttrArchive.CheckedChanged += new System.EventHandler(this.ChbAttrArchive_CheckedChanged);
            // 
            // chbAttrNormal
            // 
            this.chbAttrNormal.AutoSize = true;
            this.chbAttrNormal.Checked = true;
            this.chbAttrNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAttrNormal.Location = new System.Drawing.Point(15, 20);
            this.chbAttrNormal.Name = "chbAttrNormal";
            this.chbAttrNormal.Size = new System.Drawing.Size(59, 17);
            this.chbAttrNormal.TabIndex = 0;
            this.chbAttrNormal.Text = "Normal";
            this.chbAttrNormal.UseVisualStyleBackColor = true;
            this.chbAttrNormal.CheckedChanged += new System.EventHandler(this.ChbAttrNormal_CheckedChanged);
            // 
            // txtExtensions
            // 
            this.txtExtensions.Location = new System.Drawing.Point(83, 16);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(191, 20);
            this.txtExtensions.TabIndex = 1;
            this.txtExtensions.TextChanged += new System.EventHandler(this.TxtExtensions_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Extensions:";
            // 
            // grbSearchCriteria
            // 
            this.grbSearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearchCriteria.Controls.Add(this.chbModifyDate);
            this.grbSearchCriteria.Controls.Add(this.chbAttributes);
            this.grbSearchCriteria.Controls.Add(this.chbContent);
            this.grbSearchCriteria.Controls.Add(this.chbSize);
            this.grbSearchCriteria.Controls.Add(this.chbName);
            this.grbSearchCriteria.Location = new System.Drawing.Point(677, 5);
            this.grbSearchCriteria.Name = "grbSearchCriteria";
            this.grbSearchCriteria.Size = new System.Drawing.Size(124, 153);
            this.grbSearchCriteria.TabIndex = 2;
            this.grbSearchCriteria.TabStop = false;
            this.grbSearchCriteria.Text = "Duplicated Criteria";
            // 
            // chbModifyDate
            // 
            this.chbModifyDate.AutoSize = true;
            this.chbModifyDate.Location = new System.Drawing.Point(20, 118);
            this.chbModifyDate.Name = "chbModifyDate";
            this.chbModifyDate.Size = new System.Drawing.Size(92, 17);
            this.chbModifyDate.TabIndex = 4;
            this.chbModifyDate.Text = "Modified Date";
            this.chbModifyDate.UseVisualStyleBackColor = true;
            this.chbModifyDate.CheckedChanged += new System.EventHandler(this.ChbModifyDate_CheckedChanged);
            // 
            // chbAttributes
            // 
            this.chbAttributes.AutoSize = true;
            this.chbAttributes.Location = new System.Drawing.Point(20, 94);
            this.chbAttributes.Name = "chbAttributes";
            this.chbAttributes.Size = new System.Drawing.Size(70, 17);
            this.chbAttributes.TabIndex = 3;
            this.chbAttributes.Text = "Attributes";
            this.chbAttributes.UseVisualStyleBackColor = true;
            this.chbAttributes.CheckedChanged += new System.EventHandler(this.ChbAttributes_CheckedChanged);
            // 
            // chbContent
            // 
            this.chbContent.AutoSize = true;
            this.chbContent.Checked = true;
            this.chbContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbContent.Location = new System.Drawing.Point(20, 24);
            this.chbContent.Name = "chbContent";
            this.chbContent.Size = new System.Drawing.Size(63, 17);
            this.chbContent.TabIndex = 2;
            this.chbContent.Text = "Content";
            this.chbContent.UseVisualStyleBackColor = true;
            this.chbContent.CheckedChanged += new System.EventHandler(this.ChbContent_CheckedChanged);
            // 
            // chbSize
            // 
            this.chbSize.AutoSize = true;
            this.chbSize.Location = new System.Drawing.Point(20, 70);
            this.chbSize.Name = "chbSize";
            this.chbSize.Size = new System.Drawing.Size(46, 17);
            this.chbSize.TabIndex = 1;
            this.chbSize.Text = "Size";
            this.chbSize.UseVisualStyleBackColor = true;
            this.chbSize.CheckedChanged += new System.EventHandler(this.ChbSize_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(20, 47);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(54, 17);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.ChbName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Directories:";
            // 
            // lvwSourceFolders
            // 
            this.lvwSourceFolders.AllowDrop = true;
            this.lvwSourceFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSourceFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colPath});
            this.lvwSourceFolders.FullRowSelect = true;
            this.lvwSourceFolders.GridLines = true;
            this.lvwSourceFolders.HideSelection = false;
            this.lvwSourceFolders.Location = new System.Drawing.Point(3, 24);
            this.lvwSourceFolders.Name = "lvwSourceFolders";
            this.lvwSourceFolders.ShowGroups = false;
            this.lvwSourceFolders.ShowItemToolTips = true;
            this.lvwSourceFolders.Size = new System.Drawing.Size(357, 133);
            this.lvwSourceFolders.TabIndex = 3;
            this.lvwSourceFolders.UseCompatibleStateImageBehavior = false;
            this.lvwSourceFolders.View = System.Windows.Forms.View.Details;
            this.lvwSourceFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.LvwSourceFolders_DragDrop);
            this.lvwSourceFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.LvwSourceFolders_DragEnter);
            this.lvwSourceFolders.DoubleClick += new System.EventHandler(this.LvwSourceFolders_DoubleClick);
            this.lvwSourceFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvwSourceFolders_KeyDown);
            // 
            // colNo
            // 
            this.colNo.Text = "#";
            this.colNo.Width = 40;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 300;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 336);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(730, 10);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(737, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(68, 41);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(737, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ResultSplitter
            // 
            this.ResultSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultSplitter.BackColor = System.Drawing.Color.Silver;
            this.ResultSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ResultSplitter.Location = new System.Drawing.Point(3, 0);
            this.ResultSplitter.Name = "ResultSplitter";
            this.ResultSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ResultSplitter.Panel1
            // 
            this.ResultSplitter.Panel1.BackColor = System.Drawing.Color.White;
            this.ResultSplitter.Panel1.Controls.Add(this.label4);
            this.ResultSplitter.Panel1.Controls.Add(this.lvwItems);
            this.ResultSplitter.Panel1MinSize = 120;
            // 
            // ResultSplitter.Panel2
            // 
            this.ResultSplitter.Panel2.BackColor = System.Drawing.Color.White;
            this.ResultSplitter.Panel2.Controls.Add(this.label5);
            this.ResultSplitter.Panel2.Controls.Add(this.lvwFiles);
            this.ResultSplitter.Panel2MinSize = 120;
            this.ResultSplitter.Size = new System.Drawing.Size(730, 334);
            this.ResultSplitter.SplitterDistance = 121;
            this.ResultSplitter.SplitterWidth = 6;
            this.ResultSplitter.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Duplicated Items:";
            // 
            // lvwItems
            // 
            this.lvwItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.GridLines = true;
            this.lvwItems.HideSelection = false;
            this.lvwItems.Location = new System.Drawing.Point(0, 23);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.ShowItemToolTips = true;
            this.lvwItems.Size = new System.Drawing.Size(729, 97);
            this.lvwItems.TabIndex = 0;
            this.lvwItems.UseCompatibleStateImageBehavior = false;
            this.lvwItems.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Duplicated Details:";
            // 
            // lvwFiles
            // 
            this.lvwFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileNo,
            this.colFilePath});
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.GridLines = true;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.Location = new System.Drawing.Point(0, 23);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.ShowItemToolTips = true;
            this.lvwFiles.Size = new System.Drawing.Size(729, 178);
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // colFileNo
            // 
            this.colFileNo.Text = "#";
            this.colFileNo.Width = 33;
            // 
            // colFilePath
            // 
            this.colFilePath.Width = 660;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 521);
            this.Controls.Add(this.HorizontalSplitter);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuplicatedFileFinder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HorizontalSplitter.Panel1.ResumeLayout(false);
            this.HorizontalSplitter.Panel1.PerformLayout();
            this.HorizontalSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitter)).EndInit();
            this.HorizontalSplitter.ResumeLayout(false);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSearchCriteria.ResumeLayout(false);
            this.grbSearchCriteria.PerformLayout();
            this.ResultSplitter.Panel1.ResumeLayout(false);
            this.ResultSplitter.Panel1.PerformLayout();
            this.ResultSplitter.Panel2.ResumeLayout(false);
            this.ResultSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSplitter)).EndInit();
            this.ResultSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer HorizontalSplitter;
        private System.Windows.Forms.GroupBox grbSearchCriteria;
        private System.Windows.Forms.CheckBox chbAttributes;
        private System.Windows.Forms.CheckBox chbContent;
        private System.Windows.Forms.CheckBox chbSize;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwSourceFolders;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbAttrSystem;
        private System.Windows.Forms.CheckBox chbAttrHidden;
        private System.Windows.Forms.CheckBox chbAttrReadonnly;
        private System.Windows.Forms.CheckBox chbAttrTemp;
        private System.Windows.Forms.CheckBox chbAttrArchive;
        private System.Windows.Forms.CheckBox chbAttrNormal;
        private System.Windows.Forms.ComboBox cbbSizeUnits;
        private System.Windows.Forms.TextBox txtSizeValue;
        private System.Windows.Forms.ComboBox cbbSizeCondition;
        private System.Windows.Forms.CheckBox chbModifyDate;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.SplitContainer ResultSplitter;
        private System.Windows.Forms.ListView lvwItems;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colFileNo;
        private System.Windows.Forms.ColumnHeader colFilePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbSizeFilter;
    }
}

