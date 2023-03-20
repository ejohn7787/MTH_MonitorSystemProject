namespace MTH_MonitorSystem
{
    partial class frmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.txt_LoginPwd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LoginPwd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dgvUserManage = new System.Windows.Forms.DataGridView();
            this.title3 = new zj.UserDefinedControl.Title();
            this.chk_HistroyTrend = new zj.UserDefinedControl.CheckBoxExt();
            this.chk_UserManage = new zj.UserDefinedControl.CheckBoxExt();
            this.chk_HistoryLog = new zj.UserDefinedControl.CheckBoxExt();
            this.chk_Recipe = new zj.UserDefinedControl.CheckBoxExt();
            this.chk_ParamSet = new zj.UserDefinedControl.CheckBoxExt();
            this.title2 = new zj.UserDefinedControl.Title();
            this.title1 = new zj.UserDefinedControl.Title();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserManage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "用户名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(85)))));
            this.txt_LoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoginName.ForeColor = System.Drawing.Color.White;
            this.txt_LoginName.Location = new System.Drawing.Point(128, 68);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(166, 34);
            this.txt_LoginName.TabIndex = 9;
            this.txt_LoginName.Text = "Admin";
            // 
            // txt_LoginPwd1
            // 
            this.txt_LoginPwd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(85)))));
            this.txt_LoginPwd1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoginPwd1.ForeColor = System.Drawing.Color.White;
            this.txt_LoginPwd1.Location = new System.Drawing.Point(128, 116);
            this.txt_LoginPwd1.Name = "txt_LoginPwd1";
            this.txt_LoginPwd1.PasswordChar = '*';
            this.txt_LoginPwd1.Size = new System.Drawing.Size(166, 34);
            this.txt_LoginPwd1.TabIndex = 11;
            this.txt_LoginPwd1.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_LoginPwd2
            // 
            this.txt_LoginPwd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(85)))));
            this.txt_LoginPwd2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoginPwd2.ForeColor = System.Drawing.Color.White;
            this.txt_LoginPwd2.Location = new System.Drawing.Point(128, 167);
            this.txt_LoginPwd2.Name = "txt_LoginPwd2";
            this.txt_LoginPwd2.PasswordChar = '*';
            this.txt_LoginPwd2.Size = new System.Drawing.Size(166, 34);
            this.txt_LoginPwd2.TabIndex = 13;
            this.txt_LoginPwd2.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "确认密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_SelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btn_SelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAll.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SelectAll.ForeColor = System.Drawing.Color.White;
            this.btn_SelectAll.Location = new System.Drawing.Point(167, 382);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(132, 40);
            this.btn_SelectAll.TabIndex = 36;
            this.btn_SelectAll.Text = "全选/全不选";
            this.btn_SelectAll.UseVisualStyleBackColor = false;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(24, 503);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 35);
            this.btn_Add.TabIndex = 38;
            this.btn_Add.Text = "添加用户";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btn_Modify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Modify.ForeColor = System.Drawing.Color.White;
            this.btn_Modify.Location = new System.Drawing.Point(177, 503);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(132, 35);
            this.btn_Modify.TabIndex = 39;
            this.btn_Modify.Text = "修改用户";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btn_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Location = new System.Drawing.Point(24, 563);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(132, 35);
            this.btn_Del.TabIndex = 40;
            this.btn_Del.Text = "删除用户";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(177, 563);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(132, 35);
            this.btn_Clear.TabIndex = 41;
            this.btn_Clear.Text = "清空信息";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dgvUserManage
            // 
            this.dgvUserManage.AllowUserToAddRows = false;
            this.dgvUserManage.AllowUserToDeleteRows = false;
            this.dgvUserManage.AllowUserToResizeColumns = false;
            this.dgvUserManage.AllowUserToResizeRows = false;
            this.dgvUserManage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.dgvUserManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserManage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserManage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserManage.ColumnHeadersHeight = 40;
            this.dgvUserManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginName,
            this.LoginPwd,
            this.ParamSet,
            this.Recipe,
            this.HistoryLog,
            this.HistoryTrend,
            this.UserManage,
            this.LoginId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserManage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserManage.EnableHeadersVisualStyles = false;
            this.dgvUserManage.Location = new System.Drawing.Point(324, 14);
            this.dgvUserManage.Name = "dgvUserManage";
            this.dgvUserManage.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserManage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserManage.RowHeadersWidth = 55;
            this.dgvUserManage.RowTemplate.Height = 40;
            this.dgvUserManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserManage.Size = new System.Drawing.Size(1072, 584);
            this.dgvUserManage.TabIndex = 42;
            this.dgvUserManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserManage_CellClick);
            this.dgvUserManage.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUserManage_CellFormatting);
            this.dgvUserManage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUserManage_RowPostPaint);
            // 
            // title3
            // 
            this.title3.BackColor = System.Drawing.Color.Transparent;
            this.title3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title3.BackgroundImage")));
            this.title3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title3.Location = new System.Drawing.Point(11, 446);
            this.title3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(120, 35);
            this.title3.TabIndex = 37;
            this.title3.TitleName = "用户操作";
            // 
            // chk_HistroyTrend
            // 
            this.chk_HistroyTrend.BackColor = System.Drawing.Color.Transparent;
            this.chk_HistroyTrend.BoxBackColor = System.Drawing.Color.White;
            this.chk_HistroyTrend.BoxWidth = 20;
            this.chk_HistroyTrend.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chk_HistroyTrend.ForeColor = System.Drawing.Color.White;
            this.chk_HistroyTrend.Location = new System.Drawing.Point(167, 338);
            this.chk_HistroyTrend.Name = "chk_HistroyTrend";
            this.chk_HistroyTrend.Size = new System.Drawing.Size(132, 29);
            this.chk_HistroyTrend.TabIndex = 19;
            this.chk_HistroyTrend.Text = "历史曲线";
            this.chk_HistroyTrend.UseVisualStyleBackColor = false;
            // 
            // chk_UserManage
            // 
            this.chk_UserManage.BackColor = System.Drawing.Color.Transparent;
            this.chk_UserManage.BoxBackColor = System.Drawing.Color.White;
            this.chk_UserManage.BoxWidth = 20;
            this.chk_UserManage.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chk_UserManage.ForeColor = System.Drawing.Color.White;
            this.chk_UserManage.Location = new System.Drawing.Point(24, 389);
            this.chk_UserManage.Name = "chk_UserManage";
            this.chk_UserManage.Size = new System.Drawing.Size(132, 29);
            this.chk_UserManage.TabIndex = 18;
            this.chk_UserManage.Text = "用户管理";
            this.chk_UserManage.UseVisualStyleBackColor = false;
            // 
            // chk_HistoryLog
            // 
            this.chk_HistoryLog.BackColor = System.Drawing.Color.Transparent;
            this.chk_HistoryLog.BoxBackColor = System.Drawing.Color.White;
            this.chk_HistoryLog.BoxWidth = 20;
            this.chk_HistoryLog.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chk_HistoryLog.ForeColor = System.Drawing.Color.White;
            this.chk_HistoryLog.Location = new System.Drawing.Point(24, 338);
            this.chk_HistoryLog.Name = "chk_HistoryLog";
            this.chk_HistoryLog.Size = new System.Drawing.Size(132, 29);
            this.chk_HistoryLog.TabIndex = 17;
            this.chk_HistoryLog.Text = "报警追溯";
            this.chk_HistoryLog.UseVisualStyleBackColor = false;
            // 
            // chk_Recipe
            // 
            this.chk_Recipe.BackColor = System.Drawing.Color.Transparent;
            this.chk_Recipe.BoxBackColor = System.Drawing.Color.White;
            this.chk_Recipe.BoxWidth = 20;
            this.chk_Recipe.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chk_Recipe.ForeColor = System.Drawing.Color.White;
            this.chk_Recipe.Location = new System.Drawing.Point(167, 287);
            this.chk_Recipe.Name = "chk_Recipe";
            this.chk_Recipe.Size = new System.Drawing.Size(132, 29);
            this.chk_Recipe.TabIndex = 16;
            this.chk_Recipe.Text = "配方管理";
            this.chk_Recipe.UseVisualStyleBackColor = false;
            // 
            // chk_ParamSet
            // 
            this.chk_ParamSet.BackColor = System.Drawing.Color.Transparent;
            this.chk_ParamSet.BoxBackColor = System.Drawing.Color.White;
            this.chk_ParamSet.BoxWidth = 20;
            this.chk_ParamSet.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chk_ParamSet.ForeColor = System.Drawing.Color.White;
            this.chk_ParamSet.Location = new System.Drawing.Point(24, 287);
            this.chk_ParamSet.Name = "chk_ParamSet";
            this.chk_ParamSet.Size = new System.Drawing.Size(132, 29);
            this.chk_ParamSet.TabIndex = 15;
            this.chk_ParamSet.Text = "参数设置";
            this.chk_ParamSet.UseVisualStyleBackColor = false;
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title2.BackgroundImage")));
            this.title2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title2.Location = new System.Drawing.Point(13, 231);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(120, 35);
            this.title2.TabIndex = 14;
            this.title2.TitleName = "权限配置";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title1.BackgroundImage")));
            this.title1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.Location = new System.Drawing.Point(13, 14);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(120, 35);
            this.title1.TabIndex = 7;
            this.title1.TitleName = "用户信息";
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "用户名";
            this.LoginName.MinimumWidth = 6;
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            this.LoginName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginName.Width = 125;
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "LoginPwd";
            this.LoginPwd.HeaderText = "用户密码";
            this.LoginPwd.MinimumWidth = 6;
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.ReadOnly = true;
            this.LoginPwd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginPwd.Width = 125;
            // 
            // ParamSet
            // 
            this.ParamSet.DataPropertyName = "ParamSet";
            this.ParamSet.HeaderText = "参数设置";
            this.ParamSet.MinimumWidth = 6;
            this.ParamSet.Name = "ParamSet";
            this.ParamSet.ReadOnly = true;
            this.ParamSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ParamSet.Width = 200;
            // 
            // Recipe
            // 
            this.Recipe.DataPropertyName = "Recipe";
            this.Recipe.HeaderText = "配方管理";
            this.Recipe.MinimumWidth = 6;
            this.Recipe.Name = "Recipe";
            this.Recipe.ReadOnly = true;
            this.Recipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Recipe.Width = 140;
            // 
            // HistoryLog
            // 
            this.HistoryLog.DataPropertyName = "HistoryLog";
            this.HistoryLog.HeaderText = "报警追溯";
            this.HistoryLog.MinimumWidth = 6;
            this.HistoryLog.Name = "HistoryLog";
            this.HistoryLog.ReadOnly = true;
            this.HistoryLog.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HistoryLog.Width = 125;
            // 
            // HistoryTrend
            // 
            this.HistoryTrend.DataPropertyName = "HistoryTrend";
            this.HistoryTrend.HeaderText = "历史趋势";
            this.HistoryTrend.MinimumWidth = 6;
            this.HistoryTrend.Name = "HistoryTrend";
            this.HistoryTrend.ReadOnly = true;
            this.HistoryTrend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HistoryTrend.Width = 125;
            // 
            // UserManage
            // 
            this.UserManage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserManage.DataPropertyName = "UserManage";
            this.UserManage.HeaderText = "用户管理";
            this.UserManage.MinimumWidth = 6;
            this.UserManage.Name = "UserManage";
            this.UserManage.ReadOnly = true;
            this.UserManage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LoginId
            // 
            this.LoginId.DataPropertyName = "LoginId";
            this.LoginId.HeaderText = "用户ID";
            this.LoginId.MinimumWidth = 6;
            this.LoginId.Name = "LoginId";
            this.LoginId.ReadOnly = true;
            this.LoginId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginId.Visible = false;
            this.LoginId.Width = 125;
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 625);
            this.Controls.Add(this.dgvUserManage);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.chk_HistroyTrend);
            this.Controls.Add(this.chk_UserManage);
            this.Controls.Add(this.chk_HistoryLog);
            this.Controls.Add(this.chk_Recipe);
            this.Controls.Add(this.chk_ParamSet);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.txt_LoginPwd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LoginPwd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserManager";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zj.UserDefinedControl.Title title1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.TextBox txt_LoginPwd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LoginPwd2;
        private System.Windows.Forms.Label label2;
        private zj.UserDefinedControl.Title title2;
        private zj.UserDefinedControl.CheckBoxExt chk_ParamSet;
        private zj.UserDefinedControl.CheckBoxExt chk_Recipe;
        private zj.UserDefinedControl.CheckBoxExt chk_HistoryLog;
        private zj.UserDefinedControl.CheckBoxExt chk_UserManage;
        private zj.UserDefinedControl.CheckBoxExt chk_HistroyTrend;
        private System.Windows.Forms.Button btn_SelectAll;
        private zj.UserDefinedControl.Title title3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgvUserManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryTrend;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
    }
}