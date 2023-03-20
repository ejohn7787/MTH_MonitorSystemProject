namespace zj.UserDefinedControl
{
    partial class testGuage
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
            this.flpBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.dialPlate1 = new zj.UserDefinedControl.DialPlate();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpBottom
            // 
            this.flpBottom.BackColor = System.Drawing.Color.Transparent;
            this.flpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBottom.Location = new System.Drawing.Point(0, 398);
            this.flpBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpBottom.Name = "flpBottom";
            this.flpBottom.Size = new System.Drawing.Size(530, 137);
            this.flpBottom.TabIndex = 1;
            // 
            // dialPlate1
            // 
            this.dialPlate1.AlarmColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.BackColor = System.Drawing.Color.Transparent;
            this.dialPlate1.CenterRadius = 10;
            this.dialPlate1.DialMaxRanges = new float[] {
        20F,
        10F,
        10F};
            this.dialPlate1.DialMinRanges = new float[] {
        0F,
        0F,
        0F};
            this.dialPlate1.DialWidth = 5;
            this.dialPlate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialPlate1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dialPlate1.GaugeStyle = zj.UserDefinedControl.GaugeStyle.Level;
            this.dialPlate1.GaugeValues = new float[] {
        0F,
        0F,
        0F};
            this.dialPlate1.LevelGap = 5;
            this.dialPlate1.LevelWidth = 10;
            this.dialPlate1.Location = new System.Drawing.Point(0, 0);
            this.dialPlate1.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.dialPlate1.MarkNum = 7;
            this.dialPlate1.Name = "dialPlate1";
            this.dialPlate1.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.dialPlate1.ParaRangeMaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.dialPlate1.ParaRangeMinPercents = new float[] {
        10F,
        10F,
        10F};
            this.dialPlate1.ParNumber = zj.UserDefinedControl.ParNumber.ONE;
            this.dialPlate1.PointerGap = 10;
            this.dialPlate1.Size = new System.Drawing.Size(530, 346);
            this.dialPlate1.TabIndex = 0;
            this.dialPlate1.TextGap = 15;
            this.dialPlate1.TextRange = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Olive;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 43);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "1#站点";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testGuage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpBottom);
            this.Controls.Add(this.dialPlate1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "testGuage";
            this.Size = new System.Drawing.Size(530, 535);
            this.Load += new System.EventHandler(this.testGuage_Load);
            this.SizeChanged += new System.EventHandler(this.testGuage_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DialPlate dialPlate1;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Label lblTitle;
    }
}
