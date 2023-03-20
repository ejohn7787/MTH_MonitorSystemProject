namespace MTH_MonitorSystem
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.naviButton6 = new zj.UserDefinedControl.NaviButton();
            this.naviButton5 = new zj.UserDefinedControl.NaviButton();
            this.naviButton4 = new zj.UserDefinedControl.NaviButton();
            this.naviButton3 = new zj.UserDefinedControl.NaviButton();
            this.naviButton2 = new zj.UserDefinedControl.NaviButton();
            this.btnMonitor = new zj.UserDefinedControl.NaviButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAlarm = new System.Windows.Forms.Panel();
            this.sclAlarmText = new SeeSharpTools.JY.GUI.ScrollingText();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlCore = new zj.UserDefinedControl.PanelEx();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.led_Status = new SeeSharpTools.JY.GUI.LED();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MidPanel.SuspendLayout();
            this.pnlAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCore.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.naviButton6);
            this.TopPanel.Controls.Add(this.naviButton5);
            this.TopPanel.Controls.Add(this.naviButton4);
            this.TopPanel.Controls.Add(this.naviButton3);
            this.TopPanel.Controls.Add(this.naviButton2);
            this.TopPanel.Controls.Add(this.btnMonitor);
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Controls.Add(this.lblTitleName);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1440, 110);
            this.TopPanel.TabIndex = 0;
            // 
            // naviButton6
            // 
            this.naviButton6.BackColor = System.Drawing.Color.Transparent;
            this.naviButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton6.BackgroundImage")));
            this.naviButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton6.IsLeft = false;
            this.naviButton6.IsSelected = false;
            this.naviButton6.Location = new System.Drawing.Point(1272, 64);
            this.naviButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton6.Name = "naviButton6";
            this.naviButton6.Size = new System.Drawing.Size(140, 31);
            this.naviButton6.TabIndex = 10;
            this.naviButton6.Title = "用户管理";
            this.naviButton6.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton5
            // 
            this.naviButton5.BackColor = System.Drawing.Color.Transparent;
            this.naviButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton5.BackgroundImage")));
            this.naviButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton5.IsLeft = false;
            this.naviButton5.IsSelected = false;
            this.naviButton5.Location = new System.Drawing.Point(1116, 64);
            this.naviButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton5.Name = "naviButton5";
            this.naviButton5.Size = new System.Drawing.Size(140, 31);
            this.naviButton5.TabIndex = 9;
            this.naviButton5.Title = "历史趋势";
            this.naviButton5.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton4
            // 
            this.naviButton4.BackColor = System.Drawing.Color.Transparent;
            this.naviButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton4.BackgroundImage")));
            this.naviButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton4.IsLeft = false;
            this.naviButton4.IsSelected = false;
            this.naviButton4.Location = new System.Drawing.Point(968, 64);
            this.naviButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton4.Name = "naviButton4";
            this.naviButton4.Size = new System.Drawing.Size(140, 31);
            this.naviButton4.TabIndex = 8;
            this.naviButton4.Title = "报警追溯";
            this.naviButton4.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton3
            // 
            this.naviButton3.BackColor = System.Drawing.Color.Transparent;
            this.naviButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton3.BackgroundImage")));
            this.naviButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton3.IsLeft = true;
            this.naviButton3.IsSelected = false;
            this.naviButton3.Location = new System.Drawing.Point(335, 64);
            this.naviButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton3.Name = "naviButton3";
            this.naviButton3.Size = new System.Drawing.Size(140, 31);
            this.naviButton3.TabIndex = 7;
            this.naviButton3.Title = "配方管理";
            this.naviButton3.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton2
            // 
            this.naviButton2.BackColor = System.Drawing.Color.Transparent;
            this.naviButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton2.BackgroundImage")));
            this.naviButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton2.IsLeft = true;
            this.naviButton2.IsSelected = false;
            this.naviButton2.Location = new System.Drawing.Point(179, 64);
            this.naviButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton2.Name = "naviButton2";
            this.naviButton2.Size = new System.Drawing.Size(140, 31);
            this.naviButton2.TabIndex = 6;
            this.naviButton2.Title = "参数设置";
            this.naviButton2.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.Transparent;
            this.btnMonitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMonitor.BackgroundImage")));
            this.btnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonitor.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMonitor.IsLeft = true;
            this.btnMonitor.IsSelected = false;
            this.btnMonitor.Location = new System.Drawing.Point(31, 64);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(140, 31);
            this.btnMonitor.TabIndex = 5;
            this.btnMonitor.Title = "集中监控";
            this.btnMonitor.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1332, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleName
            // 
            this.lblTitleName.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitleName.ForeColor = System.Drawing.Color.White;
            this.lblTitleName.Location = new System.Drawing.Point(505, 24);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(434, 61);
            this.lblTitleName.TabIndex = 3;
            this.lblTitleName.Text = "多温湿度采集监控系统";
            this.lblTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "MTH_Demo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MTH_MonitorSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.Color.Transparent;
            this.MidPanel.Controls.Add(this.led_Status);
            this.MidPanel.Controls.Add(this.label6);
            this.MidPanel.Controls.Add(this.pnlAlarm);
            this.MidPanel.Controls.Add(this.lblTitle);
            this.MidPanel.Controls.Add(this.btnRight);
            this.MidPanel.Controls.Add(this.btnLeft);
            this.MidPanel.Controls.Add(this.lblCurrentTime);
            this.MidPanel.Controls.Add(this.label3);
            this.MidPanel.Controls.Add(this.lblUser);
            this.MidPanel.Controls.Add(this.pictureBox2);
            this.MidPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MidPanel.Location = new System.Drawing.Point(0, 110);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(1440, 50);
            this.MidPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1258, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "通信状态：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAlarm
            // 
            this.pnlAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAlarm.Controls.Add(this.sclAlarmText);
            this.pnlAlarm.Location = new System.Drawing.Point(937, 0);
            this.pnlAlarm.Name = "pnlAlarm";
            this.pnlAlarm.Size = new System.Drawing.Size(297, 50);
            this.pnlAlarm.TabIndex = 10;
            // 
            // sclAlarmText
            // 
            this.sclAlarmText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.sclAlarmText.BorderColor = System.Drawing.Color.Transparent;
            this.sclAlarmText.BorderVisible = true;
            this.sclAlarmText.Cursor = System.Windows.Forms.Cursors.Default;
            this.sclAlarmText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sclAlarmText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sclAlarmText.ForeColor = System.Drawing.Color.White;
            this.sclAlarmText.Location = new System.Drawing.Point(0, 0);
            this.sclAlarmText.Name = "sclAlarmText";
            this.sclAlarmText.ScrollDirection = SeeSharpTools.JY.GUI.ScrollingText.TextDirection.RightToLeft;
            this.sclAlarmText.ScrollSpeed = 25;
            this.sclAlarmText.Size = new System.Drawing.Size(297, 50);
            this.sclAlarmText.TabIndex = 0;
            this.sclAlarmText.Text = "当前系统无报警！";
            this.sclAlarmText.VerticleAligment = SeeSharpTools.JY.GUI.ScrollingText.TextVerticalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblTitle.Image = global::MTH_MonitorSystem.Properties.Resources.Current;
            this.lblTitle.Location = new System.Drawing.Point(630, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 49);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "集中监控";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.Right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(798, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 30);
            this.btnRight.TabIndex = 8;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.Left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(590, 15);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(47, 30);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblCurrentTime.Location = new System.Drawing.Point(320, 17);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(275, 26);
            this.lblCurrentTime.TabIndex = 6;
            this.lblCurrentTime.Text = "2022-11-11 09:00:00 星期一";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "欢迎登录：现在时间是：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lblUser.Location = new System.Drawing.Point(26, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 29);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "管理员";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MTH_MonitorSystem.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(0, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pnlCore
            // 
            this.pnlCore.BackColor = System.Drawing.Color.Transparent;
            this.pnlCore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.pnlCore.BorderWidth = 3;
            this.pnlCore.BottomGap = 10;
            this.pnlCore.Controls.Add(this.pnlMain);
            this.pnlCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCore.LeftGap = 20;
            this.pnlCore.Location = new System.Drawing.Point(0, 160);
            this.pnlCore.Name = "pnlCore";
            this.pnlCore.Padding = new System.Windows.Forms.Padding(23, 13, 23, 13);
            this.pnlCore.RightGap = 20;
            this.pnlCore.Size = new System.Drawing.Size(1440, 685);
            this.pnlCore.TabIndex = 2;
            this.pnlCore.TopGap = 10;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(23, 13);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1394, 659);
            this.pnlMain.TabIndex = 1;
            // 
            // led_Status
            // 
            this.led_Status.BlinkColor = System.Drawing.Color.Lime;
            this.led_Status.BlinkInterval = 1000;
            this.led_Status.BlinkOn = false;
            this.led_Status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led_Status.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led_Status.Location = new System.Drawing.Point(1372, 11);
            this.led_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.led_Status.Name = "led_Status";
            this.led_Status.OffColor = System.Drawing.Color.Red;
            this.led_Status.OnColor = System.Drawing.Color.Lime;
            this.led_Status.Size = new System.Drawing.Size(25, 27);
            this.led_Status.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.led_Status.TabIndex = 12;
            this.led_Status.Value = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(1440, 845);
            this.Controls.Add(this.pnlCore);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            this.pnlAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private zj.UserDefinedControl.NaviButton naviButton6;
        private zj.UserDefinedControl.NaviButton naviButton5;
        private zj.UserDefinedControl.NaviButton naviButton4;
        private zj.UserDefinedControl.NaviButton naviButton3;
        private zj.UserDefinedControl.NaviButton naviButton2;
        private zj.UserDefinedControl.NaviButton btnMonitor;
        private zj.UserDefinedControl.PanelEx pnlCore;
        private System.Windows.Forms.Panel pnlMain;
        private SeeSharpTools.JY.GUI.ScrollingText sclAlarmText;
        private SeeSharpTools.JY.GUI.LED led_Status;

        //  private zj.UserDefinedControl.DialPlate dialPlate1;
    }
}

