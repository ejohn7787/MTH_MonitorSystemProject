namespace MTH_MonitorSystem
{
    partial class frmRecipe
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
            MTH_Models.models.Recipe.RecipeParam recipeParam1 = new MTH_Models.models.Recipe.RecipeParam();
            MTH_Models.models.Recipe.RecipeParam recipeParam2 = new MTH_Models.models.Recipe.RecipeParam();
            MTH_Models.models.Recipe.RecipeParam recipeParam3 = new MTH_Models.models.Recipe.RecipeParam();
            MTH_Models.models.Recipe.RecipeParam recipeParam4 = new MTH_Models.models.Recipe.RecipeParam();
            MTH_Models.models.Recipe.RecipeParam recipeParam5 = new MTH_Models.models.Recipe.RecipeParam();
            MTH_Models.models.Recipe.RecipeParam recipeParam6 = new MTH_Models.models.Recipe.RecipeParam();
            this.panelExt1 = new zj.UserDefinedControl.PanelExt();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPresetRecipe = new System.Windows.Forms.Button();
            this.btnDelRecipe = new System.Windows.Forms.Button();
            this.btnModifyRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCurrentRecipeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeControl6 = new zj.UserDefinedControl.RecipeControl();
            this.recipeControl3 = new zj.UserDefinedControl.RecipeControl();
            this.recipeControl5 = new zj.UserDefinedControl.RecipeControl();
            this.recipeControl2 = new zj.UserDefinedControl.RecipeControl();
            this.recipeControl4 = new zj.UserDefinedControl.RecipeControl();
            this.recipeControl1 = new zj.UserDefinedControl.RecipeControl();
            this.panelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExt1
            // 
            this.panelExt1.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.BackGround;
            this.panelExt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.panelExt1.BorderWidth = 1;
            this.panelExt1.Controls.Add(this.splitContainer1);
            this.panelExt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExt1.Location = new System.Drawing.Point(0, 0);
            this.panelExt1.Name = "panelExt1";
            this.panelExt1.Size = new System.Drawing.Size(1418, 651);
            this.panelExt1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPresetRecipe);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelRecipe);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifyRecipe);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddRecipe);
            this.splitContainer1.Panel1.Controls.Add(this.txtRecipeName);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentRecipeName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl6);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl3);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl5);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl2);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl4);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 651);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnPresetRecipe
            // 
            this.btnPresetRecipe.BackColor = System.Drawing.Color.Transparent;
            this.btnPresetRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btnPresetRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPresetRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetRecipe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPresetRecipe.ForeColor = System.Drawing.Color.White;
            this.btnPresetRecipe.Location = new System.Drawing.Point(167, 592);
            this.btnPresetRecipe.Name = "btnPresetRecipe";
            this.btnPresetRecipe.Size = new System.Drawing.Size(107, 37);
            this.btnPresetRecipe.TabIndex = 23;
            this.btnPresetRecipe.Text = "应用配方";
            this.btnPresetRecipe.UseVisualStyleBackColor = false;
            this.btnPresetRecipe.Click += new System.EventHandler(this.btnPresetRecipe_Click);
            // 
            // btnDelRecipe
            // 
            this.btnDelRecipe.BackColor = System.Drawing.Color.Transparent;
            this.btnDelRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btnDelRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRecipe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelRecipe.ForeColor = System.Drawing.Color.White;
            this.btnDelRecipe.Location = new System.Drawing.Point(22, 592);
            this.btnDelRecipe.Name = "btnDelRecipe";
            this.btnDelRecipe.Size = new System.Drawing.Size(107, 37);
            this.btnDelRecipe.TabIndex = 22;
            this.btnDelRecipe.Text = "删除配方";
            this.btnDelRecipe.UseVisualStyleBackColor = false;
            this.btnDelRecipe.Click += new System.EventHandler(this.btnDelRecipe_Click);
            // 
            // btnModifyRecipe
            // 
            this.btnModifyRecipe.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btnModifyRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModifyRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyRecipe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModifyRecipe.ForeColor = System.Drawing.Color.White;
            this.btnModifyRecipe.Location = new System.Drawing.Point(167, 538);
            this.btnModifyRecipe.Name = "btnModifyRecipe";
            this.btnModifyRecipe.Size = new System.Drawing.Size(107, 37);
            this.btnModifyRecipe.TabIndex = 21;
            this.btnModifyRecipe.Text = "修改配方";
            this.btnModifyRecipe.UseVisualStyleBackColor = false;
            this.btnModifyRecipe.Click += new System.EventHandler(this.btnModifyRecipe_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.btnAddRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddRecipe.Location = new System.Drawing.Point(22, 538);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(107, 37);
            this.btnAddRecipe.TabIndex = 20;
            this.btnAddRecipe.Text = "添加配方";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(120, 487);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(154, 33);
            this.txtRecipeName.TabIndex = 19;
            // 
            // lblCurrentRecipeName
            // 
            this.lblCurrentRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentRecipeName.ForeColor = System.Drawing.Color.White;
            this.lblCurrentRecipeName.Location = new System.Drawing.Point(120, 440);
            this.lblCurrentRecipeName.Name = "lblCurrentRecipeName";
            this.lblCurrentRecipeName.Size = new System.Drawing.Size(154, 27);
            this.lblCurrentRecipeName.TabIndex = 18;
            this.lblCurrentRecipeName.Text = "THPR";
            this.lblCurrentRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "配方名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "当前配方：";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.Location = new System.Drawing.Point(22, 24);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 55;
            this.dgvMain.RowTemplate.Height = 40;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(252, 397);
            this.dgvMain.TabIndex = 15;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "序号";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GroupName.Width = 80;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "配方名称";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // recipeControl6
            // 
            this.recipeControl6.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl6.DevName = "6#站点";
            this.recipeControl6.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl6.Location = new System.Drawing.Point(744, 318);
            this.recipeControl6.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl6.Name = "recipeControl6";
            recipeParam1.HumiAlarmEnable = false;
            recipeParam1.HumiHighLimit = 0F;
            recipeParam1.HumiLowLimit = 0F;
            recipeParam1.TempAlarmEnable = false;
            recipeParam1.TempHighLimit = 0F;
            recipeParam1.TempLowLimit = 0F;
            this.recipeControl6.RecipParam = recipeParam1;
            this.recipeControl6.Size = new System.Drawing.Size(351, 306);
            this.recipeControl6.TabIndex = 5;
            // 
            // recipeControl3
            // 
            this.recipeControl3.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl3.DevName = "3#站点";
            this.recipeControl3.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl3.Location = new System.Drawing.Point(744, 0);
            this.recipeControl3.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl3.Name = "recipeControl3";
            recipeParam2.HumiAlarmEnable = false;
            recipeParam2.HumiHighLimit = 0F;
            recipeParam2.HumiLowLimit = 0F;
            recipeParam2.TempAlarmEnable = false;
            recipeParam2.TempHighLimit = 0F;
            recipeParam2.TempLowLimit = 0F;
            this.recipeControl3.RecipParam = recipeParam2;
            this.recipeControl3.Size = new System.Drawing.Size(351, 306);
            this.recipeControl3.TabIndex = 4;
            // 
            // recipeControl5
            // 
            this.recipeControl5.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl5.DevName = "5#站点";
            this.recipeControl5.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl5.Location = new System.Drawing.Point(374, 318);
            this.recipeControl5.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl5.Name = "recipeControl5";
            recipeParam3.HumiAlarmEnable = false;
            recipeParam3.HumiHighLimit = 0F;
            recipeParam3.HumiLowLimit = 0F;
            recipeParam3.TempAlarmEnable = false;
            recipeParam3.TempHighLimit = 0F;
            recipeParam3.TempLowLimit = 0F;
            this.recipeControl5.RecipParam = recipeParam3;
            this.recipeControl5.Size = new System.Drawing.Size(351, 306);
            this.recipeControl5.TabIndex = 3;
            // 
            // recipeControl2
            // 
            this.recipeControl2.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl2.DevName = "2#站点";
            this.recipeControl2.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl2.Location = new System.Drawing.Point(374, 0);
            this.recipeControl2.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl2.Name = "recipeControl2";
            recipeParam4.HumiAlarmEnable = false;
            recipeParam4.HumiHighLimit = 0F;
            recipeParam4.HumiLowLimit = 0F;
            recipeParam4.TempAlarmEnable = false;
            recipeParam4.TempHighLimit = 0F;
            recipeParam4.TempLowLimit = 0F;
            this.recipeControl2.RecipParam = recipeParam4;
            this.recipeControl2.Size = new System.Drawing.Size(351, 306);
            this.recipeControl2.TabIndex = 2;
            // 
            // recipeControl4
            // 
            this.recipeControl4.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl4.DevName = "4#站点";
            this.recipeControl4.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl4.Location = new System.Drawing.Point(4, 318);
            this.recipeControl4.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl4.Name = "recipeControl4";
            recipeParam5.HumiAlarmEnable = false;
            recipeParam5.HumiHighLimit = 0F;
            recipeParam5.HumiLowLimit = 0F;
            recipeParam5.TempAlarmEnable = false;
            recipeParam5.TempHighLimit = 0F;
            recipeParam5.TempLowLimit = 0F;
            this.recipeControl4.RecipParam = recipeParam5;
            this.recipeControl4.Size = new System.Drawing.Size(351, 306);
            this.recipeControl4.TabIndex = 1;
            // 
            // recipeControl1
            // 
            this.recipeControl1.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl1.DevName = "1#站点";
            this.recipeControl1.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.recipeControl1.Location = new System.Drawing.Point(4, 0);
            this.recipeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.recipeControl1.Name = "recipeControl1";
            recipeParam6.HumiAlarmEnable = false;
            recipeParam6.HumiHighLimit = 0F;
            recipeParam6.HumiLowLimit = 0F;
            recipeParam6.TempAlarmEnable = false;
            recipeParam6.TempHighLimit = 0F;
            recipeParam6.TempLowLimit = 0F;
            this.recipeControl1.RecipParam = recipeParam6;
            this.recipeControl1.Size = new System.Drawing.Size(351, 306);
            this.recipeControl1.TabIndex = 0;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 651);
            this.Controls.Add(this.panelExt1);
            this.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRecipe";
            this.Text = "配方管理";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.panelExt1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private zj.UserDefinedControl.PanelExt panelExt1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblCurrentRecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnPresetRecipe;
        private System.Windows.Forms.Button btnDelRecipe;
        private zj.UserDefinedControl.RecipeControl recipeControl6;
        private zj.UserDefinedControl.RecipeControl recipeControl3;
        private zj.UserDefinedControl.RecipeControl recipeControl5;
        private zj.UserDefinedControl.RecipeControl recipeControl2;
        private zj.UserDefinedControl.RecipeControl recipeControl4;
        private zj.UserDefinedControl.RecipeControl recipeControl1;
    }
}