namespace MTH_MonitorSystem
{
    partial class FrmVariableConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new zj.UserDefinedControl.PanelEx();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkNegAlarm = new zj.UserDefinedControl.CheckBoxExt();
            this.chkPosAlarm = new zj.UserDefinedControl.CheckBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.cmbGroupName = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnModifyVar = new System.Windows.Forms.Button();
            this.btnDelVar = new System.Windows.Forms.Button();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numOffsetOrLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffsetOrLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NegAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetOrLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.BackColor = System.Drawing.Color.Transparent;
            this.panelEx1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.panelEx1.BorderWidth = 2;
            this.panelEx1.BottomGap = 1;
            this.panelEx1.Controls.Add(this.numOffset);
            this.panelEx1.Controls.Add(this.label8);
            this.panelEx1.Controls.Add(this.numScale);
            this.panelEx1.Controls.Add(this.label6);
            this.panelEx1.Controls.Add(this.chkNegAlarm);
            this.panelEx1.Controls.Add(this.chkPosAlarm);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.txtVarName);
            this.panelEx1.Controls.Add(this.cmbGroupName);
            this.panelEx1.Controls.Add(this.dgvMain);
            this.panelEx1.Controls.Add(this.btnModifyVar);
            this.panelEx1.Controls.Add(this.btnDelVar);
            this.panelEx1.Controls.Add(this.btnAddVar);
            this.panelEx1.Controls.Add(this.txtRemark);
            this.panelEx1.Controls.Add(this.label7);
            this.panelEx1.Controls.Add(this.cmbDataType);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.numOffsetOrLength);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.numStart);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.pnlTop);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.LeftGap = 1;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.RightGap = 1;
            this.panelEx1.Size = new System.Drawing.Size(1185, 714);
            this.panelEx1.TabIndex = 0;
            this.panelEx1.TopGap = 1;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseDown);
            this.panelEx1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseMove);
            // 
            // numOffset
            // 
            this.numOffset.DecimalPlaces = 1;
            this.numOffset.Location = new System.Drawing.Point(663, 159);
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(101, 34);
            this.numOffset.TabIndex = 23;
            this.numOffset.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(545, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "偏移系数：";
            // 
            // numScale
            // 
            this.numScale.DecimalPlaces = 1;
            this.numScale.Location = new System.Drawing.Point(389, 161);
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(101, 34);
            this.numScale.TabIndex = 21;
            this.numScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(289, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "比例系数：";
            // 
            // chkNegAlarm
            // 
            this.chkNegAlarm.BoxBackColor = System.Drawing.Color.White;
            this.chkNegAlarm.BoxWidth = 20;
            this.chkNegAlarm.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkNegAlarm.ForeColor = System.Drawing.Color.White;
            this.chkNegAlarm.Location = new System.Drawing.Point(1009, 158);
            this.chkNegAlarm.Name = "chkNegAlarm";
            this.chkNegAlarm.Size = new System.Drawing.Size(139, 44);
            this.chkNegAlarm.TabIndex = 19;
            this.chkNegAlarm.Text = "下降沿报警";
            this.chkNegAlarm.UseVisualStyleBackColor = true;
            // 
            // chkPosAlarm
            // 
            this.chkPosAlarm.BoxBackColor = System.Drawing.Color.White;
            this.chkPosAlarm.BoxWidth = 20;
            this.chkPosAlarm.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkPosAlarm.ForeColor = System.Drawing.Color.White;
            this.chkPosAlarm.Location = new System.Drawing.Point(808, 158);
            this.chkPosAlarm.Name = "chkPosAlarm";
            this.chkPosAlarm.Size = new System.Drawing.Size(150, 44);
            this.chkPosAlarm.TabIndex = 18;
            this.chkPosAlarm.Text = "上升沿报警";
            this.chkPosAlarm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "数据类型：";
            // 
            // txtVarName
            // 
            this.txtVarName.Location = new System.Drawing.Point(435, 94);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(129, 34);
            this.txtVarName.TabIndex = 16;
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.FormattingEnabled = true;
            this.cmbGroupName.Location = new System.Drawing.Point(161, 95);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Size = new System.Drawing.Size(99, 35);
            this.cmbGroupName.TabIndex = 15;
            this.cmbGroupName.SelectedIndexChanged += new System.EventHandler(this.cmbGroupName_SelectedIndexChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarName,
            this.Start,
            this.OffsetOrLength,
            this.DataType,
            this.Scale,
            this.Offset,
            this.PosAlarm,
            this.NegAlarm,
            this.GroupName,
            this.Remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.Location = new System.Drawing.Point(12, 301);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.RowHeadersWidth = 50;
            this.dgvMain.RowTemplate.Height = 40;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1161, 392);
            this.dgvMain.TabIndex = 14;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMain_CellFormatting);
            this.dgvMain.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMain_RowPostPaint);
            // 
            // btnModifyVar
            // 
            this.btnModifyVar.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyVar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModifyVar.ForeColor = System.Drawing.Color.White;
            this.btnModifyVar.Location = new System.Drawing.Point(1022, 235);
            this.btnModifyVar.Name = "btnModifyVar";
            this.btnModifyVar.Size = new System.Drawing.Size(126, 37);
            this.btnModifyVar.TabIndex = 13;
            this.btnModifyVar.Text = "修改变量";
            this.btnModifyVar.UseVisualStyleBackColor = false;
            this.btnModifyVar.Click += new System.EventHandler(this.btnModifyGroup_Click);
            // 
            // btnDelVar
            // 
            this.btnDelVar.BackColor = System.Drawing.Color.Transparent;
            this.btnDelVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelVar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelVar.ForeColor = System.Drawing.Color.White;
            this.btnDelVar.Location = new System.Drawing.Point(777, 235);
            this.btnDelVar.Name = "btnDelVar";
            this.btnDelVar.Size = new System.Drawing.Size(126, 37);
            this.btnDelVar.TabIndex = 12;
            this.btnDelVar.Text = "删除变量";
            this.btnDelVar.UseVisualStyleBackColor = false;
            this.btnDelVar.Click += new System.EventHandler(this.btnDelVariable_Click);
            // 
            // btnAddVar
            // 
            this.btnAddVar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btnAddVar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddVar.ForeColor = System.Drawing.Color.White;
            this.btnAddVar.Location = new System.Drawing.Point(546, 235);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(126, 37);
            this.btnAddVar.TabIndex = 11;
            this.btnAddVar.Text = "新增变量";
            this.btnAddVar.UseVisualStyleBackColor = false;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(146, 235);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(357, 34);
            this.txtRemark.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "备注说明：";
            // 
            // cmbDataType
            // 
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Location = new System.Drawing.Point(161, 161);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(99, 35);
            this.cmbDataType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "变量名称：";
            // 
            // numOffsetOrLength
            // 
            this.numOffsetOrLength.Location = new System.Drawing.Point(1048, 96);
            this.numOffsetOrLength.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numOffsetOrLength.Name = "numOffsetOrLength";
            this.numOffsetOrLength.Size = new System.Drawing.Size(100, 34);
            this.numOffsetOrLength.TabIndex = 6;
            this.numOffsetOrLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(900, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "位偏移/长度：";
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(728, 95);
            this.numStart.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(101, 34);
            this.numStart.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(616, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "起始索引：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "通信组名称：";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1185, 75);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1151, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "变量配置";
            // 
            // VarName
            // 
            this.VarName.DataPropertyName = "VarName";
            this.VarName.HeaderText = " 变量名称";
            this.VarName.MinimumWidth = 6;
            this.VarName.Name = "VarName";
            this.VarName.ReadOnly = true;
            this.VarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VarName.Width = 120;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "起始索引";
            this.Start.MinimumWidth = 6;
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffsetOrLength
            // 
            this.OffsetOrLength.DataPropertyName = "OffsetOrLength";
            this.OffsetOrLength.HeaderText = "位偏移/长度";
            this.OffsetOrLength.MinimumWidth = 6;
            this.OffsetOrLength.Name = "OffsetOrLength";
            this.OffsetOrLength.ReadOnly = true;
            this.OffsetOrLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OffsetOrLength.Width = 120;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "数据类型";
            this.DataType.MinimumWidth = 6;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Scale
            // 
            this.Scale.DataPropertyName = "Scale";
            this.Scale.HeaderText = "比例系数";
            this.Scale.MinimumWidth = 6;
            this.Scale.Name = "Scale";
            this.Scale.ReadOnly = true;
            this.Scale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Offset
            // 
            this.Offset.DataPropertyName = "Offset";
            this.Offset.HeaderText = "偏移系数";
            this.Offset.MinimumWidth = 6;
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PosAlarm
            // 
            this.PosAlarm.DataPropertyName = "PosAlarm";
            this.PosAlarm.HeaderText = "上升沿";
            this.PosAlarm.MinimumWidth = 6;
            this.PosAlarm.Name = "PosAlarm";
            this.PosAlarm.ReadOnly = true;
            // 
            // NegAlarm
            // 
            this.NegAlarm.DataPropertyName = "NegAlarm";
            this.NegAlarm.HeaderText = "下降沿";
            this.NegAlarm.MinimumWidth = 6;
            this.NegAlarm.Name = "NegAlarm";
            this.NegAlarm.ReadOnly = true;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "通信组名称";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmVariableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 714);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmVariableConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGroupConfig";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGroupConfig_MouseMove);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffsetOrLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private zj.UserDefinedControl.PanelEx panelEx1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOffsetOrLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnModifyVar;
        private System.Windows.Forms.Button btnDelVar;
        private System.Windows.Forms.Button btnAddVar;
        private zj.UserDefinedControl.CheckBoxExt chkNegAlarm;
        private zj.UserDefinedControl.CheckBoxExt chkPosAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.ComboBox cmbGroupName;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffsetOrLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PosAlarm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NegAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}