namespace zj.UserDefinedControl
{
    partial class TextSet
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.ledAlarm = new SeeSharpTools.JY.GUI.LED();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.15615F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.27907F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.28904F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUnit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ledAlarm, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "1#站点温度高限";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblValue_DoubleClick);
            // 
            // lblValue
            // 
            this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(173, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(46, 40);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "0.0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValue.DoubleClick += new System.EventHandler(this.lblValue_DoubleClick);
            // 
            // lblUnit
            // 
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(225, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(49, 40);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "℃";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnit.DoubleClick += new System.EventHandler(this.lblValue_DoubleClick);
            // 
            // ledAlarm
            // 
            this.ledAlarm.BlinkColor = System.Drawing.Color.Lime;
            this.ledAlarm.BlinkInterval = 1000;
            this.ledAlarm.BlinkOn = false;
            this.ledAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ledAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledAlarm.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.ledAlarm.Location = new System.Drawing.Point(287, 10);
            this.ledAlarm.Margin = new System.Windows.Forms.Padding(10);
            this.ledAlarm.Name = "ledAlarm";
            this.ledAlarm.OffColor = System.Drawing.Color.Lime;
            this.ledAlarm.OnColor = System.Drawing.Color.Red;
            this.ledAlarm.Size = new System.Drawing.Size(23, 20);
            this.ledAlarm.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.ledAlarm.TabIndex = 3;
            this.ledAlarm.Value = false;
            // 
            // TextSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextSet";
            this.Size = new System.Drawing.Size(320, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblUnit;
        private SeeSharpTools.JY.GUI.LED ledAlarm;
    }
}
