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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PortMachine = new System.IO.Ports.SerialPort(this.components);
            this.timerUpdateChar = new System.Windows.Forms.Timer(this.components);
            this.timerGetValue = new System.Windows.Forms.Timer(this.components);
            this.timerExit = new System.Windows.Forms.Timer(this.components);
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.timerCheckCom = new System.Windows.Forms.Timer(this.components);
            this.PortSwitch = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwStep = new System.Windows.Forms.DataGridView();
            this.clStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFunc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clLowValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHighValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMotor = new System.Windows.Forms.TextBox();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerMetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsccbMeterPort = new System.Windows.Forms.ToolStripComboBox();
            this.powerSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.gbStatitsis = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pBChar = new System.Windows.Forms.PictureBox();
            this.lbCounterNumberNG = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCounterNumberOK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCounterNumberTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
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
            this.lbTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStep)).BeginInit();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.timerDelay.Interval = 5000;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.22578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.06413F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.71009F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbStatitsis, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbHistory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.statusTrip, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbTime, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1593, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFinalResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(729, 183);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(475, 388);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            this.labelFinalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFinalResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalResult.ForeColor = System.Drawing.Color.White;
            this.labelFinalResult.Location = new System.Drawing.Point(3, 24);
            this.labelFinalResult.Margin = new System.Windows.Forms.Padding(0);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(469, 361);
            this.labelFinalResult.TabIndex = 17;
            this.labelFinalResult.Text = "READY";
            this.labelFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinalResult.Click += new System.EventHandler(this.labelFinalResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwStep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 183);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(687, 388);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step program";
            // 
            // dgwStep
            // 
            this.dgwStep.AllowUserToResizeColumns = false;
            this.dgwStep.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgwStep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.dgwStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwStep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStep,
            this.clFunc,
            this.clLowValue,
            this.clHighValue,
            this.clValue,
            this.clNote});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStep.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStep.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgwStep.EnableHeadersVisualStyles = false;
            this.dgwStep.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwStep.Location = new System.Drawing.Point(3, 24);
            this.dgwStep.MultiSelect = false;
            this.dgwStep.Name = "dgwStep";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStep.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwStep.RowHeadersVisible = false;
            this.dgwStep.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwStep.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwStep.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgwStep.RowTemplate.Height = 25;
            this.dgwStep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwStep.Size = new System.Drawing.Size(681, 361);
            this.dgwStep.StandardTab = true;
            this.dgwStep.TabIndex = 0;
            this.dgwStep.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStep_CellEndEdit);
            this.dgwStep.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwStep_CellMouseClick);
            this.dgwStep.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgwStep_DataError);
            // 
            // clStep
            // 
            this.clStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clStep.HeaderText = "Step";
            this.clStep.Name = "clStep";
            this.clStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clStep.Width = 53;
            // 
            // clFunc
            // 
            this.clFunc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clFunc.HeaderText = "CMD";
            this.clFunc.Name = "clFunc";
            // 
            // clLowValue
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clLowValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.clLowValue.HeaderText = "Set Low";
            this.clLowValue.Name = "clLowValue";
            this.clLowValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clHighValue
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clHighValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.clHighValue.HeaderText = "Set High";
            this.clHighValue.Name = "clHighValue";
            this.clHighValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clValue
            // 
            this.clValue.HeaderText = "Read";
            this.clValue.Name = "clValue";
            this.clValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNote
            // 
            this.clNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNote.HeaderText = "Note";
            this.clNote.Name = "clNote";
            this.clNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnTop
            // 
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTop.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.pnTop, 5);
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Controls.Add(this.pnControlBox);
            this.pnTop.Controls.Add(this.menuStripMain);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1593, 74);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbModelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMotor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 53);
            this.panel1.TabIndex = 4;
            // 
            // tbModelName
            // 
            this.tbModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.tbModelName.ForeColor = System.Drawing.Color.Coral;
            this.tbModelName.Location = new System.Drawing.Point(281, 0);
            this.tbModelName.Margin = new System.Windows.Forms.Padding(0);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.Size = new System.Drawing.Size(736, 53);
            this.tbModelName.TabIndex = 4;
            this.tbModelName.Text = "Model name";
            this.tbModelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "FCT Tester";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::FCT.Properties.Resources.Logo;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 53);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMotor
            // 
            this.tbMotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbMotor.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.tbMotor.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbMotor.Location = new System.Drawing.Point(1017, 0);
            this.tbMotor.Margin = new System.Windows.Forms.Padding(0);
            this.tbMotor.Name = "tbMotor";
            this.tbMotor.Size = new System.Drawing.Size(576, 53);
            this.tbMotor.TabIndex = 3;
            this.tbMotor.Text = "Motor name";
            this.tbMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnControlBox
            // 
            this.pnControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControlBox.Controls.Add(this.tableLayoutPanel2);
            this.pnControlBox.Location = new System.Drawing.Point(1533, 0);
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
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // menuStripMain
            // 
            this.menuStripMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ForeColor = System.Drawing.Color.White;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.portToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(1593, 24);
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
            this.editToolStripMenuItem,
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerMetterToolStripMenuItem,
            this.powerSwitchToolStripMenuItem});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // powerMetterToolStripMenuItem
            // 
            this.powerMetterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsccbMeterPort});
            this.powerMetterToolStripMenuItem.Name = "powerMetterToolStripMenuItem";
            this.powerMetterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerMetterToolStripMenuItem.Text = "Power metter";
            // 
            // tsccbMeterPort
            // 
            this.tsccbMeterPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsccbMeterPort.Items.AddRange(new object[] {
            "COM 1",
            "COM 2",
            "COM 3",
            "COM 4",
            "COM 5",
            "COM 6",
            "COM 7",
            "COM 8",
            "COM 9",
            "COM 10",
            "COM 11",
            "COM 12",
            "COM 13",
            "COM 14",
            "COM 15",
            "",
            ""});
            this.tsccbMeterPort.Name = "tsccbMeterPort";
            this.tsccbMeterPort.Size = new System.Drawing.Size(121, 23);
            this.tsccbMeterPort.SelectedIndexChanged += new System.EventHandler(this.tsccbMeterPort_SelectedIndexChanged);
            this.tsccbMeterPort.Click += new System.EventHandler(this.tsccbMeterPort_Click);
            // 
            // powerSwitchToolStripMenuItem
            // 
            this.powerSwitchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.powerSwitchToolStripMenuItem.Name = "powerSwitchToolStripMenuItem";
            this.powerSwitchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerSwitchToolStripMenuItem.Text = "Power switch";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "COM 1",
            "COM 2",
            "COM 3",
            "COM 4",
            "COM 5",
            "COM 6",
            "COM 7",
            "COM 8",
            "COM 9",
            "COM 10",
            "COM 11",
            "COM 12",
            "COM 13",
            "COM 14",
            "COM 15",
            "",
            ""});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // gbStatitsis
            // 
            this.gbStatitsis.Controls.Add(this.tableLayoutPanel4);
            this.gbStatitsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatitsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatitsis.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatitsis.ForeColor = System.Drawing.Color.White;
            this.gbStatitsis.Location = new System.Drawing.Point(1210, 183);
            this.gbStatitsis.Name = "gbStatitsis";
            this.tableLayoutPanel1.SetRowSpan(this.gbStatitsis, 2);
            this.gbStatitsis.Size = new System.Drawing.Size(319, 388);
            this.gbStatitsis.TabIndex = 2;
            this.gbStatitsis.TabStop = false;
            this.gbStatitsis.Text = "Statitics";
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 361);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // pBChar
            // 
            this.pBChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBChar.Location = new System.Drawing.Point(0, 192);
            this.pBChar.Margin = new System.Windows.Forms.Padding(0);
            this.pBChar.Name = "pBChar";
            this.pBChar.Size = new System.Drawing.Size(313, 169);
            this.pBChar.TabIndex = 9;
            this.pBChar.TabStop = false;
            // 
            // lbCounterNumberNG
            // 
            this.lbCounterNumberNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberNG.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberNG.ForeColor = System.Drawing.Color.Red;
            this.lbCounterNumberNG.Location = new System.Drawing.Point(0, 160);
            this.lbCounterNumberNG.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberNG.Name = "lbCounterNumberNG";
            this.lbCounterNumberNG.Size = new System.Drawing.Size(313, 32);
            this.lbCounterNumberNG.TabIndex = 8;
            this.lbCounterNumberNG.Text = "NG number";
            this.lbCounterNumberNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "NG";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCounterNumberOK
            // 
            this.lbCounterNumberOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberOK.ForeColor = System.Drawing.Color.Green;
            this.lbCounterNumberOK.Location = new System.Drawing.Point(0, 96);
            this.lbCounterNumberOK.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberOK.Name = "lbCounterNumberOK";
            this.lbCounterNumberOK.Size = new System.Drawing.Size(313, 32);
            this.lbCounterNumberOK.TabIndex = 6;
            this.lbCounterNumberOK.Text = "OK number";
            this.lbCounterNumberOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "OK";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCounterNumberTotal
            // 
            this.lbCounterNumberTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbCounterNumberTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCounterNumberTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCounterNumberTotal.ForeColor = System.Drawing.Color.Coral;
            this.lbCounterNumberTotal.Location = new System.Drawing.Point(0, 32);
            this.lbCounterNumberTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lbCounterNumberTotal.Name = "lbCounterNumberTotal";
            this.lbCounterNumberTotal.Size = new System.Drawing.Size(313, 32);
            this.lbCounterNumberTotal.TabIndex = 4;
            this.lbCounterNumberTotal.Text = "Total number";
            this.lbCounterNumberTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 3);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(36, 708);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1493, 14);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(36, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1493, 100);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbHz);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox6.Location = new System.Drawing.Point(1118, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 84);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Frequency (Hz)";
            // 
            // lbHz
            // 
            this.lbHz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHz.Location = new System.Drawing.Point(3, 26);
            this.lbHz.Name = "lbHz";
            this.lbHz.Size = new System.Drawing.Size(361, 55);
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
            this.gbWat.Location = new System.Drawing.Point(748, 8);
            this.gbWat.Name = "gbWat";
            this.gbWat.Size = new System.Drawing.Size(364, 84);
            this.gbWat.TabIndex = 2;
            this.gbWat.TabStop = false;
            this.gbWat.Text = "Watt (mW)";
            // 
            // lbWat
            // 
            this.lbWat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbWat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWat.Location = new System.Drawing.Point(3, 26);
            this.lbWat.Name = "lbWat";
            this.lbWat.Size = new System.Drawing.Size(358, 55);
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
            this.gbAmpe.Location = new System.Drawing.Point(378, 8);
            this.gbAmpe.Name = "gbAmpe";
            this.gbAmpe.Size = new System.Drawing.Size(364, 84);
            this.gbAmpe.TabIndex = 1;
            this.gbAmpe.TabStop = false;
            this.gbAmpe.Text = "Ampe (mA)";
            // 
            // lbAmpe
            // 
            this.lbAmpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAmpe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAmpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmpe.Location = new System.Drawing.Point(3, 26);
            this.lbAmpe.Name = "lbAmpe";
            this.lbAmpe.Size = new System.Drawing.Size(358, 55);
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
            this.groupBox3.Size = new System.Drawing.Size(364, 84);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Volt (V)";
            // 
            // lbVol
            // 
            this.lbVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbVol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol.Location = new System.Drawing.Point(3, 26);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(358, 55);
            this.lbVol.TabIndex = 0;
            this.lbVol.Text = "0.00";
            this.lbVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbHistory
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbHistory, 2);
            this.gbHistory.Controls.Add(this.textBoxHistory);
            this.gbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistory.ForeColor = System.Drawing.Color.White;
            this.gbHistory.Location = new System.Drawing.Point(36, 577);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(1168, 125);
            this.gbHistory.TabIndex = 6;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "History";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.textBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxHistory.Location = new System.Drawing.Point(3, 24);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ShortcutsEnabled = false;
            this.textBoxHistory.Size = new System.Drawing.Size(1162, 98);
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
            this.statusTrip.Location = new System.Drawing.Point(0, 734);
            this.statusTrip.Name = "statusTrip";
            this.statusTrip.Size = new System.Drawing.Size(1593, 22);
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
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(1210, 574);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(319, 131);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "00:00 AM";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FCT
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1593, 756);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbStatitsis;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbWat;
        private System.Windows.Forms.GroupBox gbAmpe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbHistory;
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
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Timer timerUpdateChar;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerMetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerSwitchToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Timer timerGetValue;
        private System.Windows.Forms.Timer timerExit;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Timer timerCheckCom;
        public System.IO.Ports.SerialPort PortSwitch;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMotor;
        private System.Windows.Forms.TextBox tbModelName;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DataGridView dgwStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripComboBox tsccbMeterPort;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStep;
        private System.Windows.Forms.DataGridViewComboBoxColumn clFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLowValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHighValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNote;
    }
}

