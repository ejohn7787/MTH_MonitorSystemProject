namespace zj.UserDefinedControl
{
    partial class RecipeControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeControl));
            this.chkeHumiAlarmEnable = new zj.UserDefinedControl.CheckBoxExt();
            this.chkeTempAlarmEnable = new zj.UserDefinedControl.CheckBoxExt();
            this.tseHum_LowerLimit = new zj.UserDefinedControl.TextSetEx();
            this.tseHum_HighLimit = new zj.UserDefinedControl.TextSetEx();
            this.tseTH_LowerLimit = new zj.UserDefinedControl.TextSetEx();
            this.tseTH_HighLimit = new zj.UserDefinedControl.TextSetEx();
            this.titleDevName = new zj.UserDefinedControl.Title();
            this.SuspendLayout();
            // 
            // chkeHumiAlarmEnable
            // 
            this.chkeHumiAlarmEnable.BoxBackColor = System.Drawing.Color.White;
            this.chkeHumiAlarmEnable.BoxWidth = 20;
            this.chkeHumiAlarmEnable.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkeHumiAlarmEnable.ForeColor = System.Drawing.Color.White;
            this.chkeHumiAlarmEnable.Location = new System.Drawing.Point(185, 260);
            this.chkeHumiAlarmEnable.Name = "chkeHumiAlarmEnable";
            this.chkeHumiAlarmEnable.Size = new System.Drawing.Size(162, 31);
            this.chkeHumiAlarmEnable.TabIndex = 6;
            this.chkeHumiAlarmEnable.Text = "湿度报警启用";
            this.chkeHumiAlarmEnable.UseVisualStyleBackColor = true;
            // 
            // chkeTempAlarmEnable
            // 
            this.chkeTempAlarmEnable.BoxBackColor = System.Drawing.Color.White;
            this.chkeTempAlarmEnable.BoxWidth = 20;
            this.chkeTempAlarmEnable.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkeTempAlarmEnable.ForeColor = System.Drawing.Color.White;
            this.chkeTempAlarmEnable.Location = new System.Drawing.Point(4, 260);
            this.chkeTempAlarmEnable.Name = "chkeTempAlarmEnable";
            this.chkeTempAlarmEnable.Size = new System.Drawing.Size(175, 34);
            this.chkeTempAlarmEnable.TabIndex = 5;
            this.chkeTempAlarmEnable.Text = "温度报警启用";
            this.chkeTempAlarmEnable.UseVisualStyleBackColor = true;
            // 
            // tseHum_LowerLimit
            // 
            this.tseHum_LowerLimit.BackColor = System.Drawing.Color.Transparent;
            this.tseHum_LowerLimit.CurrentValue = 0F;
            this.tseHum_LowerLimit.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.tseHum_LowerLimit.Location = new System.Drawing.Point(22, 202);
            this.tseHum_LowerLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tseHum_LowerLimit.Name = "tseHum_LowerLimit";
            this.tseHum_LowerLimit.Size = new System.Drawing.Size(304, 39);
            this.tseHum_LowerLimit.TabIndex = 4;
            this.tseHum_LowerLimit.TitleName = "1#站点湿度低限";
            this.tseHum_LowerLimit.Unit = "%";
            // 
            // tseHum_HighLimit
            // 
            this.tseHum_HighLimit.BackColor = System.Drawing.Color.Transparent;
            this.tseHum_HighLimit.CurrentValue = 0F;
            this.tseHum_HighLimit.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.tseHum_HighLimit.Location = new System.Drawing.Point(22, 153);
            this.tseHum_HighLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tseHum_HighLimit.Name = "tseHum_HighLimit";
            this.tseHum_HighLimit.Size = new System.Drawing.Size(304, 39);
            this.tseHum_HighLimit.TabIndex = 3;
            this.tseHum_HighLimit.TitleName = "1#站点湿度高限";
            this.tseHum_HighLimit.Unit = "%";
            // 
            // tseTH_LowerLimit
            // 
            this.tseTH_LowerLimit.BackColor = System.Drawing.Color.Transparent;
            this.tseTH_LowerLimit.CurrentValue = 0F;
            this.tseTH_LowerLimit.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.tseTH_LowerLimit.Location = new System.Drawing.Point(22, 104);
            this.tseTH_LowerLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tseTH_LowerLimit.Name = "tseTH_LowerLimit";
            this.tseTH_LowerLimit.Size = new System.Drawing.Size(304, 39);
            this.tseTH_LowerLimit.TabIndex = 2;
            this.tseTH_LowerLimit.TitleName = "1#站点温度低限";
            this.tseTH_LowerLimit.Unit = "℃";
            // 
            // tseTH_HighLimit
            // 
            this.tseTH_HighLimit.BackColor = System.Drawing.Color.Transparent;
            this.tseTH_HighLimit.CurrentValue = 0F;
            this.tseTH_HighLimit.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.tseTH_HighLimit.Location = new System.Drawing.Point(22, 55);
            this.tseTH_HighLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tseTH_HighLimit.Name = "tseTH_HighLimit";
            this.tseTH_HighLimit.Size = new System.Drawing.Size(304, 39);
            this.tseTH_HighLimit.TabIndex = 1;
            this.tseTH_HighLimit.TitleName = "1#站点温度高限";
            this.tseTH_HighLimit.Unit = "℃";
            // 
            // titleDevName
            // 
            this.titleDevName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleDevName.BackgroundImage")));
            this.titleDevName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleDevName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleDevName.Location = new System.Drawing.Point(16, 14);
            this.titleDevName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleDevName.Name = "titleDevName";
            this.titleDevName.Size = new System.Drawing.Size(109, 31);
            this.titleDevName.TabIndex = 0;
            this.titleDevName.TitleName = "1#站点";
            // 
            // RecipeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.chkeHumiAlarmEnable);
            this.Controls.Add(this.chkeTempAlarmEnable);
            this.Controls.Add(this.tseHum_LowerLimit);
            this.Controls.Add(this.tseHum_HighLimit);
            this.Controls.Add(this.tseTH_LowerLimit);
            this.Controls.Add(this.tseTH_HighLimit);
            this.Controls.Add(this.titleDevName);
            this.Font = new System.Drawing.Font("新宋体", 11.5F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecipeControl";
            this.Size = new System.Drawing.Size(372, 316);
            this.ResumeLayout(false);

        }

        #endregion

        private Title titleDevName;
        private TextSetEx tseTH_HighLimit;
        private TextSetEx tseTH_LowerLimit;
        private TextSetEx tseHum_LowerLimit;
        private TextSetEx tseHum_HighLimit;
        private CheckBoxExt chkeTempAlarmEnable;
        private CheckBoxExt chkeHumiAlarmEnable;
    }
}
