namespace zj.UserDefinedControl
{
    partial class ParameterShow
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemValue = new System.Windows.Forms.Label();
            this.lblItemUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemName.Location = new System.Drawing.Point(0, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(64, 24);
            this.lblItemName.TabIndex = 3;
            this.lblItemName.Text = "数据名";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemValue
            // 
            this.lblItemValue.AutoSize = true;
            this.lblItemValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemValue.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemValue.Location = new System.Drawing.Point(64, 0);
            this.lblItemValue.Name = "lblItemValue";
            this.lblItemValue.Size = new System.Drawing.Size(64, 24);
            this.lblItemValue.TabIndex = 4;
            this.lblItemValue.Text = "数据值";
            this.lblItemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemUnit
            // 
            this.lblItemUnit.AutoSize = true;
            this.lblItemUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemUnit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemUnit.Location = new System.Drawing.Point(128, 0);
            this.lblItemUnit.Name = "lblItemUnit";
            this.lblItemUnit.Size = new System.Drawing.Size(46, 24);
            this.lblItemUnit.TabIndex = 5;
            this.lblItemUnit.Text = "单位";
            this.lblItemUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParameterShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemUnit);
            this.Controls.Add(this.lblItemValue);
            this.Controls.Add(this.lblItemName);
            this.Name = "ParameterShow";
            this.Size = new System.Drawing.Size(198, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Label lblItemUnit;
    }
}
