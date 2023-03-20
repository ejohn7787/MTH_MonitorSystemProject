namespace zj.UserDefinedControl
{
    partial class DialPanel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.parShowHumi = new zj.UserDefinedControl.ParameterShow();
            this.parShowTemp = new zj.UserDefinedControl.ParameterShow();
            this.dialPlate = new zj.UserDefinedControl.DialPlate();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Olive;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "1#站点";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parShowHumi
            // 
            this.parShowHumi.ItemName = "湿度";
            this.parShowHumi.Location = new System.Drawing.Point(248, 292);
            this.parShowHumi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.parShowHumi.Name = "parShowHumi";
            this.parShowHumi.parValue = "0.0";
            this.parShowHumi.Size = new System.Drawing.Size(215, 43);
            this.parShowHumi.TabIndex = 3;
            this.parShowHumi.Unit = "%";
            // 
            // parShowTemp
            // 
            this.parShowTemp.ItemName = "温度";
            this.parShowTemp.Location = new System.Drawing.Point(10, 292);
            this.parShowTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parShowTemp.Name = "parShowTemp";
            this.parShowTemp.parValue = "0.0";
            this.parShowTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parShowTemp.Size = new System.Drawing.Size(212, 43);
            this.parShowTemp.TabIndex = 2;
            this.parShowTemp.Unit = "℃";
            // 
            // dialPlate
            // 
            this.dialPlate.AlarmColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate.BackColor = System.Drawing.Color.Transparent;
            this.dialPlate.CenterRadius = 10;
            this.dialPlate.DialMaxRanges = new float[] {
        10F,
        10F,
        10F};
            this.dialPlate.DialMinRanges = new float[] {
        0F,
        0F,
        0F};
            this.dialPlate.DialWidth = 5;
            this.dialPlate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialPlate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dialPlate.GaugeStyle = zj.UserDefinedControl.GaugeStyle.Level;
            this.dialPlate.GaugeValues = new float[] {
        7F,
        9F,
        2F};
            this.dialPlate.LevelGap = 5;
            this.dialPlate.LevelWidth = 10;
            this.dialPlate.Location = new System.Drawing.Point(10, 10);
            this.dialPlate.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dialPlate.MarkNum = 7;
            this.dialPlate.Name = "dialPlate";
            this.dialPlate.Padding = new System.Windows.Forms.Padding(10);
            this.dialPlate.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.dialPlate.ParaRangeMaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.dialPlate.ParaRangeMinPercents = new float[] {
        10F,
        10F,
        10F};
            this.dialPlate.ParNumber = zj.UserDefinedControl.ParNumber.TWO;
            this.dialPlate.PointerGap = 10;
            this.dialPlate.Size = new System.Drawing.Size(453, 267);
            this.dialPlate.TabIndex = 0;
            this.dialPlate.TextGap = 15;
            this.dialPlate.TextRange = 30;
            // 
            // DialPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.parShowHumi);
            this.Controls.Add(this.parShowTemp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dialPlate);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DialPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(473, 348);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private DialPlate dialPlate;
        private ParameterShow parShowTemp;
        private ParameterShow parShowHumi;
    }
}
