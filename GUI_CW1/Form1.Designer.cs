namespace GUI_CW1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.rdSorted = new System.Windows.Forms.RadioButton();
            this.rdUnsorted = new System.Windows.Forms.RadioButton();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPositionVal = new System.Windows.Forms.Label();
            this.lblProbesVal = new System.Windows.Forms.Label();
            this.lblSuccessTrueFalse = new System.Windows.Forms.Label();
            this.lblSPosition = new System.Windows.Forms.Label();
            this.lblSFound = new System.Windows.Forms.Label();
            this.lblSProbes = new System.Windows.Forms.Label();
            this.rdBinary = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdLinear = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblLastEntry = new System.Windows.Forms.Label();
            this.lblFirstEntry = new System.Windows.Forms.Label();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblMinVal = new System.Windows.Forms.Label();
            this.lblMaxVal = new System.Windows.Forms.Label();
            this.lblLastEntryVal = new System.Windows.Forms.Label();
            this.lblFirstEntryVal = new System.Windows.Forms.Label();
            this.lblCountVal = new System.Windows.Forms.Label();
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblRelease = new System.Windows.Forms.Label();
            this.btnClearSel = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblMaxEntries = new System.Windows.Forms.Label();
            this.lblMaxEntriesStat = new System.Windows.Forms.Label();
            this.grpList.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.grpStats.SuspendLayout();
            this.grpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstNumbers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstNumbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(9, 21);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(120, 251);
            this.lstNumbers.TabIndex = 0;
            this.lstNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNumbers_MouseDown);
            // 
            // rdSorted
            // 
            this.rdSorted.AutoSize = true;
            this.rdSorted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSorted.Location = new System.Drawing.Point(6, 19);
            this.rdSorted.Name = "rdSorted";
            this.rdSorted.Size = new System.Drawing.Size(56, 17);
            this.rdSorted.TabIndex = 2;
            this.rdSorted.TabStop = true;
            this.rdSorted.Text = "Sorted";
            this.rdSorted.UseVisualStyleBackColor = true;
            this.rdSorted.CheckedChanged += new System.EventHandler(this.rdSorted_CheckedChanged);
            // 
            // rdUnsorted
            // 
            this.rdUnsorted.AutoSize = true;
            this.rdUnsorted.Checked = true;
            this.rdUnsorted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdUnsorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUnsorted.Location = new System.Drawing.Point(6, 38);
            this.rdUnsorted.Name = "rdUnsorted";
            this.rdUnsorted.Size = new System.Drawing.Size(68, 17);
            this.rdUnsorted.TabIndex = 3;
            this.rdUnsorted.TabStop = true;
            this.rdUnsorted.Text = "Unsorted";
            this.rdUnsorted.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            this.grpList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpList.Controls.Add(this.rdUnsorted);
            this.grpList.Controls.Add(this.rdSorted);
            this.grpList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpList.Location = new System.Drawing.Point(135, 21);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(94, 66);
            this.grpList.TabIndex = 4;
            this.grpList.TabStop = false;
            this.grpList.Text = "List View";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSearch.Controls.Add(this.groupBox1);
            this.grpSearch.Controls.Add(this.rdBinary);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.rdLinear);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpSearch.Location = new System.Drawing.Point(266, 112);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(158, 211);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPositionVal);
            this.groupBox1.Controls.Add(this.lblProbesVal);
            this.groupBox1.Controls.Add(this.lblSuccessTrueFalse);
            this.groupBox1.Controls.Add(this.lblSPosition);
            this.groupBox1.Controls.Add(this.lblSFound);
            this.groupBox1.Controls.Add(this.lblSProbes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 81);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Search";
            // 
            // lblPositionVal
            // 
            this.lblPositionVal.AutoSize = true;
            this.lblPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionVal.Location = new System.Drawing.Point(79, 59);
            this.lblPositionVal.Name = "lblPositionVal";
            this.lblPositionVal.Size = new System.Drawing.Size(27, 13);
            this.lblPositionVal.TabIndex = 24;
            this.lblPositionVal.Text = "N/A";
            // 
            // lblProbesVal
            // 
            this.lblProbesVal.AutoSize = true;
            this.lblProbesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbesVal.Location = new System.Drawing.Point(79, 37);
            this.lblProbesVal.Name = "lblProbesVal";
            this.lblProbesVal.Size = new System.Drawing.Size(27, 13);
            this.lblProbesVal.TabIndex = 23;
            this.lblProbesVal.Text = "N/A";
            // 
            // lblSuccessTrueFalse
            // 
            this.lblSuccessTrueFalse.AutoSize = true;
            this.lblSuccessTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessTrueFalse.Location = new System.Drawing.Point(79, 16);
            this.lblSuccessTrueFalse.Name = "lblSuccessTrueFalse";
            this.lblSuccessTrueFalse.Size = new System.Drawing.Size(27, 13);
            this.lblSuccessTrueFalse.TabIndex = 22;
            this.lblSuccessTrueFalse.Text = "N/A";
            // 
            // lblSPosition
            // 
            this.lblSPosition.AutoSize = true;
            this.lblSPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSPosition.Location = new System.Drawing.Point(6, 59);
            this.lblSPosition.Name = "lblSPosition";
            this.lblSPosition.Size = new System.Drawing.Size(66, 13);
            this.lblSPosition.TabIndex = 21;
            this.lblSPosition.Text = "List Position:";
            // 
            // lblSFound
            // 
            this.lblSFound.AutoSize = true;
            this.lblSFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSFound.Location = new System.Drawing.Point(6, 16);
            this.lblSFound.Name = "lblSFound";
            this.lblSFound.Size = new System.Drawing.Size(51, 13);
            this.lblSFound.TabIndex = 19;
            this.lblSFound.Text = "Success:";
            // 
            // lblSProbes
            // 
            this.lblSProbes.AutoSize = true;
            this.lblSProbes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSProbes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSProbes.Location = new System.Drawing.Point(6, 36);
            this.lblSProbes.Name = "lblSProbes";
            this.lblSProbes.Size = new System.Drawing.Size(43, 13);
            this.lblSProbes.TabIndex = 18;
            this.lblSProbes.Text = "Probes:";
            // 
            // rdBinary
            // 
            this.rdBinary.AutoSize = true;
            this.rdBinary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdBinary.Enabled = false;
            this.rdBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBinary.Location = new System.Drawing.Point(76, 26);
            this.rdBinary.Name = "rdBinary";
            this.rdBinary.Size = new System.Drawing.Size(54, 17);
            this.rdBinary.TabIndex = 3;
            this.rdBinary.TabStop = true;
            this.rdBinary.Text = "Binary";
            this.rdBinary.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(86, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 22);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdLinear
            // 
            this.rdLinear.AutoSize = true;
            this.rdLinear.Checked = true;
            this.rdLinear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdLinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLinear.Location = new System.Drawing.Point(16, 26);
            this.rdLinear.Name = "rdLinear";
            this.rdLinear.Size = new System.Drawing.Size(54, 17);
            this.rdLinear.TabIndex = 2;
            this.rdLinear.TabStop = true;
            this.rdLinear.Text = "Linear";
            this.rdLinear.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(16, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // btnInitialise
            // 
            this.btnInitialise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInitialise.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInitialise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitialise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInitialise.Location = new System.Drawing.Point(266, 21);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 6;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = false;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(347, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShuffle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.Enabled = false;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShuffle.Location = new System.Drawing.Point(347, 51);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 8;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(266, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.Location = new System.Drawing.Point(17, 46);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(57, 13);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "List Count:";
            // 
            // lblLastEntry
            // 
            this.lblLastEntry.AutoSize = true;
            this.lblLastEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEntry.Location = new System.Drawing.Point(17, 96);
            this.lblLastEntry.Name = "lblLastEntry";
            this.lblLastEntry.Size = new System.Drawing.Size(57, 13);
            this.lblLastEntry.TabIndex = 12;
            this.lblLastEntry.Text = "Last Entry:";
            // 
            // lblFirstEntry
            // 
            this.lblFirstEntry.AutoSize = true;
            this.lblFirstEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstEntry.Location = new System.Drawing.Point(17, 71);
            this.lblFirstEntry.Name = "lblFirstEntry";
            this.lblFirstEntry.Size = new System.Drawing.Size(56, 13);
            this.lblFirstEntry.TabIndex = 13;
            this.lblFirstEntry.Text = "First Entry:";
            // 
            // picDelete
            // 
            this.picDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(40, 287);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(54, 56);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 14;
            this.picDelete.TabStop = false;
            this.picDelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDelete_DragDrop);
            this.picDelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDelete_DragEnter);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMax.Location = new System.Drawing.Point(1, 121);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(73, 13);
            this.lblMax.TabIndex = 16;
            this.lblMax.Text = "Highest Entry:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMin.Location = new System.Drawing.Point(3, 146);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(71, 13);
            this.lblMin.TabIndex = 15;
            this.lblMin.Text = "Lowest Entry:";
            // 
            // grpStats
            // 
            this.grpStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpStats.Controls.Add(this.lblMaxEntriesStat);
            this.grpStats.Controls.Add(this.lblMaxEntries);
            this.grpStats.Controls.Add(this.lblMinVal);
            this.grpStats.Controls.Add(this.lblMaxVal);
            this.grpStats.Controls.Add(this.lblLastEntryVal);
            this.grpStats.Controls.Add(this.lblFirstEntryVal);
            this.grpStats.Controls.Add(this.lblCountVal);
            this.grpStats.Controls.Add(this.lblMin);
            this.grpStats.Controls.Add(this.lblCount);
            this.grpStats.Controls.Add(this.lblMax);
            this.grpStats.Controls.Add(this.lblLastEntry);
            this.grpStats.Controls.Add(this.lblFirstEntry);
            this.grpStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStats.Location = new System.Drawing.Point(135, 192);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(122, 169);
            this.grpStats.TabIndex = 20;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Statistics";
            // 
            // lblMinVal
            // 
            this.lblMinVal.AutoSize = true;
            this.lblMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinVal.Location = new System.Drawing.Point(90, 146);
            this.lblMinVal.Name = "lblMinVal";
            this.lblMinVal.Size = new System.Drawing.Size(27, 13);
            this.lblMinVal.TabIndex = 21;
            this.lblMinVal.Text = "N/A";
            // 
            // lblMaxVal
            // 
            this.lblMaxVal.AutoSize = true;
            this.lblMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxVal.Location = new System.Drawing.Point(90, 121);
            this.lblMaxVal.Name = "lblMaxVal";
            this.lblMaxVal.Size = new System.Drawing.Size(27, 13);
            this.lblMaxVal.TabIndex = 20;
            this.lblMaxVal.Text = "N/A";
            // 
            // lblLastEntryVal
            // 
            this.lblLastEntryVal.AutoSize = true;
            this.lblLastEntryVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastEntryVal.Location = new System.Drawing.Point(90, 96);
            this.lblLastEntryVal.Name = "lblLastEntryVal";
            this.lblLastEntryVal.Size = new System.Drawing.Size(27, 13);
            this.lblLastEntryVal.TabIndex = 19;
            this.lblLastEntryVal.Text = "N/A";
            // 
            // lblFirstEntryVal
            // 
            this.lblFirstEntryVal.AutoSize = true;
            this.lblFirstEntryVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstEntryVal.Location = new System.Drawing.Point(90, 71);
            this.lblFirstEntryVal.Name = "lblFirstEntryVal";
            this.lblFirstEntryVal.Size = new System.Drawing.Size(27, 13);
            this.lblFirstEntryVal.TabIndex = 18;
            this.lblFirstEntryVal.Text = "N/A";
            // 
            // lblCountVal
            // 
            this.lblCountVal.AutoSize = true;
            this.lblCountVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountVal.Location = new System.Drawing.Point(90, 46);
            this.lblCountVal.Name = "lblCountVal";
            this.lblCountVal.Size = new System.Drawing.Size(13, 13);
            this.lblCountVal.TabIndex = 17;
            this.lblCountVal.Text = "0";
            // 
            // grpInsert
            // 
            this.grpInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpInsert.Controls.Add(this.btnInsert);
            this.grpInsert.Controls.Add(this.txtInsert);
            this.grpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInsert.Location = new System.Drawing.Point(135, 101);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(122, 80);
            this.grpInsert.TabIndex = 21;
            this.grpInsert.TabStop = false;
            this.grpInsert.Text = "Insert Entry";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(43, 48);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(60, 22);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsert.ForeColor = System.Drawing.Color.White;
            this.txtInsert.Location = new System.Drawing.Point(9, 22);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(94, 20);
            this.txtInsert.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(307, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFill.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFill.Enabled = false;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFill.Location = new System.Drawing.Point(266, 51);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 23;
            this.btnFill.Text = "Fill List";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // lblRelease
            // 
            this.lblRelease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelease.Location = new System.Drawing.Point(21, 346);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(95, 13);
            this.lblRelease.TabIndex = 24;
            this.lblRelease.Text = "Release to Delete!";
            this.lblRelease.Visible = false;
            // 
            // btnClearSel
            // 
            this.btnClearSel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearSel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSel.Enabled = false;
            this.btnClearSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearSel.Location = new System.Drawing.Point(347, 80);
            this.btnClearSel.Name = "btnClearSel";
            this.btnClearSel.Size = new System.Drawing.Size(75, 23);
            this.btnClearSel.TabIndex = 25;
            this.btnClearSel.Text = "Deselect";
            this.btnClearSel.UseVisualStyleBackColor = false;
            this.btnClearSel.Click += new System.EventHandler(this.btnClearSel_Click);
            // 
            // picHelp
            // 
            this.picHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHelp.Image = ((System.Drawing.Image)(resources.GetObject("picHelp.Image")));
            this.picHelp.Location = new System.Drawing.Point(244, 12);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(16, 16);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHelp.TabIndex = 26;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // lblMaxEntries
            // 
            this.lblMaxEntries.AutoSize = true;
            this.lblMaxEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntries.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxEntries.Location = new System.Drawing.Point(8, 21);
            this.lblMaxEntries.Name = "lblMaxEntries";
            this.lblMaxEntries.Size = new System.Drawing.Size(65, 13);
            this.lblMaxEntries.TabIndex = 22;
            this.lblMaxEntries.Text = "Max Entries:";
            // 
            // lblMaxEntriesStat
            // 
            this.lblMaxEntriesStat.AutoSize = true;
            this.lblMaxEntriesStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntriesStat.Location = new System.Drawing.Point(90, 21);
            this.lblMaxEntriesStat.Name = "lblMaxEntriesStat";
            this.lblMaxEntriesStat.Size = new System.Drawing.Size(19, 13);
            this.lblMaxEntriesStat.TabIndex = 23;
            this.lblMaxEntriesStat.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 369);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.btnClearSel);
            this.Controls.Add(this.lblRelease);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpInsert);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInitialise);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.lstNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Number List Manager";
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.RadioButton rdSorted;
        private System.Windows.Forms.RadioButton rdUnsorted;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdBinary;
        private System.Windows.Forms.RadioButton rdLinear;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblLastEntry;
        private System.Windows.Forms.Label lblFirstEntry;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label lblSPosition;
        private System.Windows.Forms.Label lblSProbes;
        private System.Windows.Forms.Label lblSFound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCountVal;
        private System.Windows.Forms.Label lblMinVal;
        private System.Windows.Forms.Label lblMaxVal;
        private System.Windows.Forms.Label lblLastEntryVal;
        private System.Windows.Forms.Label lblFirstEntryVal;
        private System.Windows.Forms.Label lblPositionVal;
        private System.Windows.Forms.Label lblProbesVal;
        private System.Windows.Forms.Label lblSuccessTrueFalse;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Button btnClearSel;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblMaxEntriesStat;
        private System.Windows.Forms.Label lblMaxEntries;
    }
}

