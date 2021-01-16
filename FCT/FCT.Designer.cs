using System.Drawing;

namespace FCT
{
    partial class FCT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwStep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerMetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStatitsis = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pBChar = new System.Windows.Forms.PictureBox();
            this.lbCounterNumberNG = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCounterNumberOK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCounterNumberTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbHz = new System.Windows.Forms.Label();
            this.gbWat = new System.Windows.Forms.GroupBox();
            this.lbWat = new System.Windows.Forms.Label();
            this.gbAmpe = new System.Windows.Forms.GroupBox();
            this.lbAmpe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbVol = new System.Windows.Forms.Label();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.statusTrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.WT310PortName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SwitchPortName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbCOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PortMachine = new System.IO.Ports.SerialPort(this.components);
            this.timerUpdateChar = new System.Windows.Forms.Timer(this.components);
            this.timerGetValue = new System.Windows.Forms.Timer(this.components);
            this.timerExit = new System.Windows.Forms.Timer(this.components);
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.timerCheckCom = new System.Windows.Forms.Timer(this.components);
            this.PortSwitch = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStep)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnControlBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.gbStatitsis.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBChar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbWat.SuspendLayout();
            this.gbAmpe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.statusTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbStatitsis, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbHistory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.statusTrip, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1335, 711);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFinalResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(795, 183);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(311, 354);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(183)))), ((int)(((byte)(234)))));
            this.labelFinalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFinalResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 50F, System.Drawing.FontStyle.Bold);
            this.labelFinalResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelFinalResult.Location = new System.Drawing.Point(3, 16);
            this.labelFinalResult.Margin = new System.Windows.Forms.Padding(0);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(305, 335);
            this.labelFinalResult.TabIndex = 17;
            this.labelFinalResult.Text = "OK";
            this.labelFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinalResult.Click += new System.EventHandler(this.labelFinalResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwStep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 183);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(756, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bước kiểm tra";
            // 
            // dgwStep
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgwStep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgwStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStep.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgwStep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStep.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStep.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwStep.EnableHeadersVisualStyles = false;
            this.dgwStep.Location = new System.Drawing.Point(3, 16);
            this.dgwStep.MultiSelect = false;
            this.dgwStep.Name = "dgwStep";
            this.dgwStep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStep.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwStep.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgwStep.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwStep.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgwStep.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgwStep.RowTemplate.Height = 25;
            this.dgwStep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwStep.Size = new System.Drawing.Size(750, 335);
            this.dgwStep.TabIndex = 0;
            this.dgwStep.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStep_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Bước";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.DisplayStyleForCurrentCellOnly = true;
            this.Column2.FillWeight = 14.11139F;
            this.Column2.HeaderText = "Hành động";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.FillWeight = 21.51F;
            this.Column3.HeaderText = "Mức cận dưới";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 116;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.FillWeight = 26.04449F;
            this.Column4.HeaderText = "Mức cận trên";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 114;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.FillWeight = 483.0034F;
            this.Column5.HeaderText = "Dữ liệu thực tế";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 111;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 8.845572F;
            this.Column6.HeaderText = "Ý nghĩa";
            this.Column6.Name = "Column6";
            // 
            // pnTop
            // 
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.pnTop, 5);
            this.pnTop.Controls.Add(this.pnControlBox);
            this.pnTop.Controls.Add(this.lbHeader);
            this.pnTop.Controls.Add(this.menuStripMain);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1335, 80);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // pnControlBox
            // 
            this.pnControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControlBox.Controls.Add(this.tableLayoutPanel2);
            this.pnControlBox.Location = new System.Drawing.Point(1275, 0);
            this.pnControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.pnControlBox.Name = "pnControlBox";
            this.pnControlBox.Size = new System.Drawing.Size(60, 20);
            this.pnControlBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMaximize, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMinimize, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(60, 20);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.BackgroundImage = global::FCT.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(40, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMaximize.BackgroundImage = global::FCT.Properties.Resources.masinize;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(20, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = " ";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimize.BackgroundImage = global::FCT.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = " ";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Coral;
            this.lbHeader.Location = new System.Drawing.Point(0, 20);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(1335, 60);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "OLAAAAAA";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.UseCompatibleTextRendering = true;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // menuStripMain
            // 
            this.menuStripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ForeColor = System.Drawing.Color.White;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.portToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(1335, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.readToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.readToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.readToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordsToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // changePasswordsToolStripMenuItem
            // 
            this.changePasswordsToolStripMenuItem.Name = "changePasswordsToolStripMenuItem";
            this.changePasswordsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.changePasswordsToolStripMenuItem.Text = "Passwords";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerMetterToolStripMenuItem,
            this.scandToolStripMenuItem,
            this.powerSwitchToolStripMenuItem});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // powerMetterToolStripMenuItem
            // 
            this.powerMetterToolStripMenuItem.Name = "powerMetterToolStripMenuItem";
            this.powerMetterToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.powerMetterToolStripMenuItem.Text = "Power metter";
            // 
            // scandToolStripMenuItem
            // 
            this.scandToolStripMenuItem.Name = "scandToolStripMenuItem";
            this.scandToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.scandToolStripMenuItem.Text = "Scand";
            // 
            // powerSwitchToolStripMenuItem
            // 
            this.powerSwitchToolStripMenuItem.Name = "powerSwitchToolStripMenuItem";
            this.powerSwitchToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.powerSwitchToolStripMenuItem.Text = "Power switch";
            // 
            // gbStatitsis
            // 
            this.gbStatitsis.Controls.Add(this.tableLayoutPanel4);
            this.gbStatitsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatitsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatitsis.ForeColor = System.Drawing.Color.White;
            this.gbStatitsis.Location = new System.Drawing.Point(1112, 183);
            this.gbStatitsis.Name = "gbStatitsis";
            this.tableLayoutPanel1.SetRowSpan(this.gbStatitsis, 2);
            this.gbStatitsis.Size = new System.Drawing.Size(184, 354);
            this.gbStatitsis.TabIndex = 2;
            this.gbStatitsis.TabStop = false;
            this.gbStatitsis.Text = "Thống kê";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.pBChar, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbCounterNumberNG, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbCounterNumberOK, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbCounterNumberTotal, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(178, 335);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // pBChar
            // 
            this.pBChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBChar.Location = new System.Drawing.Point(0, 180);
            this.pBChar.Margin = new System.Windows.Forms.Padding(0);
            this.pBChar.Name = "pBChar";
            this.pBChar.Size = new System.Drawing.Size(178, 155);
            this.pBChar.TabIndex = 9;
            this.pBChar.TabStop = false;
            // 
            // lbCounterNumberNG
            // 
            this.lbCounterNumberNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberNG.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberNG.ForeColor = System.Drawing.Color.Red;
            this.lbCounterNumberNG.Location = new System.Drawing.Point(0, 150);
            this.lbCounterNumberNG.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberNG.Name = "lbCounterNumberNG";
            this.lbCounterNumberNG.Size = new System.Drawing.Size(178, 30);
            this.lbCounterNumberNG.TabIndex = 8;
            this.lbCounterNumberNG.Text = "NG number";
            this.lbCounterNumberNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 27);
            this.label13.TabIndex = 7;
            this.label13.Text = "Số lượng NG";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCounterNumberOK
            // 
            this.lbCounterNumberOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCounterNumberOK.Location = new System.Drawing.Point(0, 90);
            this.lbCounterNumberOK.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberOK.Name = "lbCounterNumberOK";
            this.lbCounterNumberOK.Size = new System.Drawing.Size(178, 30);
            this.lbCounterNumberOK.TabIndex = 6;
            this.lbCounterNumberOK.Text = "OK number";
            this.lbCounterNumberOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng OK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCounterNumberTotal
            // 
            this.lbCounterNumberTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbCounterNumberTotal.Location = new System.Drawing.Point(0, 30);
            this.lbCounterNumberTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberTotal.Name = "lbCounterNumberTotal";
            this.lbCounterNumberTotal.Size = new System.Drawing.Size(178, 30);
            this.lbCounterNumberTotal.TabIndex = 4;
            this.lbCounterNumberTotal.Text = "Total number";
            this.lbCounterNumberTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 3);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(33, 663);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1263, 14);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbWat, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbAmpe, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Blue;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(33, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1263, 94);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbHz);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox6.Location = new System.Drawing.Point(947, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(308, 78);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tần số (Hz)";
            // 
            // lbHz
            // 
            this.lbHz.BackColor = System.Drawing.Color.Black;
            this.lbHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHz.Location = new System.Drawing.Point(3, 26);
            this.lbHz.Name = "lbHz";
            this.lbHz.Size = new System.Drawing.Size(302, 49);
            this.lbHz.TabIndex = 1;
            this.lbHz.Text = "50 Hz";
            this.lbHz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbWat
            // 
            this.gbWat.Controls.Add(this.lbWat);
            this.gbWat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWat.ForeColor = System.Drawing.Color.Yellow;
            this.gbWat.Location = new System.Drawing.Point(634, 8);
            this.gbWat.Name = "gbWat";
            this.gbWat.Size = new System.Drawing.Size(307, 78);
            this.gbWat.TabIndex = 2;
            this.gbWat.TabStop = false;
            this.gbWat.Text = "Công suất (mW)";
            // 
            // lbWat
            // 
            this.lbWat.BackColor = System.Drawing.Color.Black;
            this.lbWat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWat.Location = new System.Drawing.Point(3, 26);
            this.lbWat.Name = "lbWat";
            this.lbWat.Size = new System.Drawing.Size(301, 49);
            this.lbWat.TabIndex = 1;
            this.lbWat.Text = "0.00";
            this.lbWat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAmpe
            // 
            this.gbAmpe.Controls.Add(this.lbAmpe);
            this.gbAmpe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAmpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAmpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAmpe.ForeColor = System.Drawing.Color.Green;
            this.gbAmpe.Location = new System.Drawing.Point(321, 8);
            this.gbAmpe.Name = "gbAmpe";
            this.gbAmpe.Size = new System.Drawing.Size(307, 78);
            this.gbAmpe.TabIndex = 1;
            this.gbAmpe.TabStop = false;
            this.gbAmpe.Text = "Dòng điện (mA)";
            // 
            // lbAmpe
            // 
            this.lbAmpe.BackColor = System.Drawing.Color.Black;
            this.lbAmpe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAmpe.Location = new System.Drawing.Point(3, 26);
            this.lbAmpe.Name = "lbAmpe";
            this.lbAmpe.Size = new System.Drawing.Size(301, 49);
            this.lbAmpe.TabIndex = 1;
            this.lbAmpe.Text = "0.00";
            this.lbAmpe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbVol);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điện áp (V)";
            // 
            // lbVol
            // 
            this.lbVol.BackColor = System.Drawing.Color.Black;
            this.lbVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVol.Location = new System.Drawing.Point(3, 26);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(301, 49);
            this.lbVol.TabIndex = 0;
            this.lbVol.Text = "0.00";
            this.lbVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbHistory
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbHistory, 3);
            this.gbHistory.Controls.Add(this.textBoxHistory);
            this.gbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistory.ForeColor = System.Drawing.Color.White;
            this.gbHistory.Location = new System.Drawing.Point(33, 543);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(1263, 114);
            this.gbHistory.TabIndex = 6;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "Lịch sử";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHistory.ForeColor = System.Drawing.Color.White;
            this.textBoxHistory.Location = new System.Drawing.Point(3, 17);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ShortcutsEnabled = false;
            this.textBoxHistory.Size = new System.Drawing.Size(1257, 94);
            this.textBoxHistory.TabIndex = 0;
            // 
            // statusTrip
            // 
            this.statusTrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.statusTrip, 5);
            this.statusTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.WT310PortName,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel8,
            this.SwitchPortName,
            this.tsslbCOM,
            this.toolStripStatusLabel3});
            this.statusTrip.Location = new System.Drawing.Point(0, 689);
            this.statusTrip.Name = "statusTrip";
            this.statusTrip.Size = new System.Drawing.Size(1335, 22);
            this.statusTrip.TabIndex = 7;
            this.statusTrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "WT310T port: ";
            // 
            // WT310PortName
            // 
            this.WT310PortName.ForeColor = System.Drawing.Color.White;
            this.WT310PortName.Name = "WT310PortName";
            this.WT310PortName.Size = new System.Drawing.Size(44, 17);
            this.WT310PortName.Text = "COM 1";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel9.Text = "          ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 17);
            // 
            // SwitchPortName
            // 
            this.SwitchPortName.ForeColor = System.Drawing.Color.White;
            this.SwitchPortName.Name = "SwitchPortName";
            this.SwitchPortName.Size = new System.Drawing.Size(76, 17);
            this.SwitchPortName.Text = "Switch COM:";
            // 
            // tsslbCOM
            // 
            this.tsslbCOM.ForeColor = System.Drawing.Color.White;
            this.tsslbCOM.Name = "tsslbCOM";
            this.tsslbCOM.Size = new System.Drawing.Size(44, 17);
            this.tsslbCOM.Text = "COM 2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // timerUpdateChar
            // 
            this.timerUpdateChar.Interval = 5;
            this.timerUpdateChar.Tick += new System.EventHandler(this.timerUpdateChar_Tick);
            // 
            // timerGetValue
            // 
            this.timerGetValue.Interval = 250;
            this.timerGetValue.Tick += new System.EventHandler(this.timerGetValue_Tick);
            // 
            // timerExit
            // 
            this.timerExit.Interval = 1000;
            this.timerExit.Tick += new System.EventHandler(this.timerExit_Tick);
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 1000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // timerCheckCom
            // 
            this.timerCheckCom.Interval = 500;
            this.timerCheckCom.Tick += new System.EventHandler(this.timerCheckCom_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // FCT
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1335, 711);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FCT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStep)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnControlBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.gbStatitsis.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBChar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.gbWat.ResumeLayout(false);
            this.gbAmpe.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.statusTrip.ResumeLayout(false);
            this.statusTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnControlBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbStatitsis;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbWat;
        private System.Windows.Forms.GroupBox gbAmpe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.DataGridView dgwStep;
        private System.Windows.Forms.Label labelFinalResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pBChar;
        private System.Windows.Forms.Label lbCounterNumberNG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCounterNumberOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCounterNumberTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusTrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel WT310PortName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel SwitchPortName;
        private System.Windows.Forms.ToolStripStatusLabel tsslbCOM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label lbHz;
        private System.Windows.Forms.Label lbWat;
        private System.Windows.Forms.Label lbAmpe;
        private System.Windows.Forms.Label lbVol;
        private System.IO.Ports.SerialPort PortMachine;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdateChar;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerMetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerSwitchToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Timer timerGetValue;
        private System.Windows.Forms.Timer timerExit;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Timer timerCheckCom;
        private System.IO.Ports.SerialPort PortSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

