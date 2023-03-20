namespace MTH_MonitorSystem
{
    partial class frmMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries1 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new zj.UserDefinedControl.PanelExt();
            this.lsvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.THGuage2 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt9 = new zj.UserDefinedControl.CheckBoxExt();
            this.THGuage1 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt10 = new zj.UserDefinedControl.CheckBoxExt();
            this.THGuage3 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt11 = new zj.UserDefinedControl.CheckBoxExt();
            this.THGuage5 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt12 = new zj.UserDefinedControl.CheckBoxExt();
            this.THGuage4 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt5 = new zj.UserDefinedControl.CheckBoxExt();
            this.THGuage6 = new zj.UserDefinedControl.testGuage();
            this.checkBoxExt6 = new zj.UserDefinedControl.CheckBoxExt();
            this.title1 = new zj.UserDefinedControl.Title();
            this.checkBoxExt7 = new zj.UserDefinedControl.CheckBoxExt();
            this.title2 = new zj.UserDefinedControl.Title();
            this.checkBoxExt8 = new zj.UserDefinedControl.CheckBoxExt();
            this.chartActualTrend = new SeeSharpTools.JY.GUI.StripChartX();
            this.checkBoxExt4 = new zj.UserDefinedControl.CheckBoxExt();
            this.chkTemp1 = new zj.UserDefinedControl.CheckBoxExt();
            this.checkBoxExt3 = new zj.UserDefinedControl.CheckBoxExt();
            this.chkHumi1 = new zj.UserDefinedControl.CheckBoxExt();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "info.png");
            this.imageList.Images.SetKeyName(1, "warning.png");
            this.imageList.Images.SetKeyName(2, "error.png");
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::MTH_MonitorSystem.Properties.Resources.BackGround;
            this.pnlMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Controls.Add(this.lsvInfo);
            this.pnlMain.Controls.Add(this.THGuage2);
            this.pnlMain.Controls.Add(this.checkBoxExt9);
            this.pnlMain.Controls.Add(this.THGuage1);
            this.pnlMain.Controls.Add(this.checkBoxExt10);
            this.pnlMain.Controls.Add(this.THGuage3);
            this.pnlMain.Controls.Add(this.checkBoxExt11);
            this.pnlMain.Controls.Add(this.THGuage5);
            this.pnlMain.Controls.Add(this.checkBoxExt12);
            this.pnlMain.Controls.Add(this.THGuage4);
            this.pnlMain.Controls.Add(this.checkBoxExt5);
            this.pnlMain.Controls.Add(this.THGuage6);
            this.pnlMain.Controls.Add(this.checkBoxExt6);
            this.pnlMain.Controls.Add(this.title1);
            this.pnlMain.Controls.Add(this.checkBoxExt7);
            this.pnlMain.Controls.Add(this.title2);
            this.pnlMain.Controls.Add(this.checkBoxExt8);
            this.pnlMain.Controls.Add(this.chartActualTrend);
            this.pnlMain.Controls.Add(this.checkBoxExt4);
            this.pnlMain.Controls.Add(this.chkTemp1);
            this.pnlMain.Controls.Add(this.checkBoxExt3);
            this.pnlMain.Controls.Add(this.chkHumi1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1394, 621);
            this.pnlMain.TabIndex = 19;
            // 
            // lsvInfo
            // 
            this.lsvInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lsvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvInfo.ForeColor = System.Drawing.Color.White;
            this.lsvInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvInfo.HideSelection = false;
            this.lsvInfo.Location = new System.Drawing.Point(755, 439);
            this.lsvInfo.Name = "lsvInfo";
            this.lsvInfo.ShowItemToolTips = true;
            this.lsvInfo.Size = new System.Drawing.Size(670, 159);
            this.lsvInfo.SmallImageList = this.imageList;
            this.lsvInfo.TabIndex = 18;
            this.lsvInfo.UseCompatibleStateImageBehavior = false;
            this.lsvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日志时间";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "日志内容";
            this.columnHeader2.Width = 300;
            // 
            // THGuage2
            // 
            this.THGuage2.BackColor = System.Drawing.Color.Transparent;
            this.THGuage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage2.ForeColor = System.Drawing.Color.White;
            this.THGuage2.Location = new System.Drawing.Point(339, 3);
            this.THGuage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage2.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage2.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage2.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage2.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage2.ModuleError = false;
            this.THGuage2.Name = "THGuage2";
            this.THGuage2.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage2.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage2.Size = new System.Drawing.Size(290, 200);
            this.THGuage2.StateVarName = "模块2异常";
            this.THGuage2.TabIndex = 3;
            this.THGuage2.Title = "2#站点";
            this.THGuage2.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage2.ValueNames = new string[] {
        "模块2温度",
        "模块2湿度",
        "参数3"};
            this.THGuage2.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt9
            // 
            this.checkBoxExt9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt9.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt9.BoxWidth = 20;
            this.checkBoxExt9.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt9.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt9.Location = new System.Drawing.Point(1248, 357);
            this.checkBoxExt9.Name = "checkBoxExt9";
            this.checkBoxExt9.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt9.TabIndex = 14;
            this.checkBoxExt9.Tag = "11";
            this.checkBoxExt9.Text = "6#站点湿度";
            this.checkBoxExt9.UseVisualStyleBackColor = false;
            this.checkBoxExt9.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // THGuage1
            // 
            this.THGuage1.BackColor = System.Drawing.Color.Transparent;
            this.THGuage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage1.ForeColor = System.Drawing.Color.White;
            this.THGuage1.Location = new System.Drawing.Point(30, 3);
            this.THGuage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage1.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage1.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage1.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage1.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage1.ModuleError = false;
            this.THGuage1.Name = "THGuage1";
            this.THGuage1.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage1.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage1.Size = new System.Drawing.Size(290, 200);
            this.THGuage1.StateVarName = "模块1异常";
            this.THGuage1.TabIndex = 0;
            this.THGuage1.Title = "1#站点";
            this.THGuage1.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage1.ValueNames = new string[] {
        "模块1温度",
        "模块1湿度",
        "参数3"};
            this.THGuage1.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt10
            // 
            this.checkBoxExt10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt10.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt10.BoxWidth = 20;
            this.checkBoxExt10.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt10.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt10.Location = new System.Drawing.Point(1089, 357);
            this.checkBoxExt10.Name = "checkBoxExt10";
            this.checkBoxExt10.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt10.TabIndex = 15;
            this.checkBoxExt10.Tag = "10";
            this.checkBoxExt10.Text = "6#站点温度";
            this.checkBoxExt10.UseVisualStyleBackColor = false;
            this.checkBoxExt10.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // THGuage3
            // 
            this.THGuage3.BackColor = System.Drawing.Color.Transparent;
            this.THGuage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage3.ForeColor = System.Drawing.Color.White;
            this.THGuage3.Location = new System.Drawing.Point(30, 202);
            this.THGuage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage3.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage3.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage3.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage3.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage3.ModuleError = false;
            this.THGuage3.Name = "THGuage3";
            this.THGuage3.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage3.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage3.Size = new System.Drawing.Size(290, 200);
            this.THGuage3.StateVarName = "模块3异常";
            this.THGuage3.TabIndex = 1;
            this.THGuage3.Title = "3#站点";
            this.THGuage3.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage3.ValueNames = new string[] {
        "模块3温度",
        "模块3湿度",
        "参数3"};
            this.THGuage3.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt11
            // 
            this.checkBoxExt11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt11.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt11.BoxWidth = 20;
            this.checkBoxExt11.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt11.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt11.Location = new System.Drawing.Point(930, 357);
            this.checkBoxExt11.Name = "checkBoxExt11";
            this.checkBoxExt11.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt11.TabIndex = 16;
            this.checkBoxExt11.Tag = "9";
            this.checkBoxExt11.Text = "5#站点湿度";
            this.checkBoxExt11.UseVisualStyleBackColor = false;
            this.checkBoxExt11.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // THGuage5
            // 
            this.THGuage5.BackColor = System.Drawing.Color.Transparent;
            this.THGuage5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage5.ForeColor = System.Drawing.Color.White;
            this.THGuage5.Location = new System.Drawing.Point(30, 410);
            this.THGuage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage5.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage5.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage5.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage5.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage5.ModuleError = false;
            this.THGuage5.Name = "THGuage5";
            this.THGuage5.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage5.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage5.Size = new System.Drawing.Size(290, 200);
            this.THGuage5.StateVarName = "模块5异常";
            this.THGuage5.TabIndex = 2;
            this.THGuage5.Title = "5#站点";
            this.THGuage5.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage5.ValueNames = new string[] {
        "模块5温度",
        "模块5湿度",
        "参数3"};
            this.THGuage5.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt12
            // 
            this.checkBoxExt12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt12.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt12.BoxWidth = 20;
            this.checkBoxExt12.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt12.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt12.Location = new System.Drawing.Point(771, 357);
            this.checkBoxExt12.Name = "checkBoxExt12";
            this.checkBoxExt12.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt12.TabIndex = 17;
            this.checkBoxExt12.Tag = "8";
            this.checkBoxExt12.Text = "5#站点温度";
            this.checkBoxExt12.UseVisualStyleBackColor = false;
            this.checkBoxExt12.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // THGuage4
            // 
            this.THGuage4.BackColor = System.Drawing.Color.Transparent;
            this.THGuage4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage4.ForeColor = System.Drawing.Color.White;
            this.THGuage4.Location = new System.Drawing.Point(339, 202);
            this.THGuage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage4.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage4.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage4.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage4.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage4.ModuleError = false;
            this.THGuage4.Name = "THGuage4";
            this.THGuage4.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage4.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage4.Size = new System.Drawing.Size(290, 200);
            this.THGuage4.StateVarName = "模块4异常";
            this.THGuage4.TabIndex = 4;
            this.THGuage4.Title = "4#站点";
            this.THGuage4.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage4.ValueNames = new string[] {
        "模块4温度",
        "模块4湿度",
        "参数3"};
            this.THGuage4.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt5
            // 
            this.checkBoxExt5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt5.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt5.BoxWidth = 20;
            this.checkBoxExt5.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt5.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt5.Location = new System.Drawing.Point(1248, 314);
            this.checkBoxExt5.Name = "checkBoxExt5";
            this.checkBoxExt5.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt5.TabIndex = 10;
            this.checkBoxExt5.Tag = "7";
            this.checkBoxExt5.Text = "4#站点湿度";
            this.checkBoxExt5.UseVisualStyleBackColor = false;
            this.checkBoxExt5.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // THGuage6
            // 
            this.THGuage6.BackColor = System.Drawing.Color.Transparent;
            this.THGuage6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.THGuage6.ForeColor = System.Drawing.Color.White;
            this.THGuage6.Location = new System.Drawing.Point(339, 410);
            this.THGuage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.THGuage6.MaxPercents = new float[] {
        90F,
        90F,
        90F};
            this.THGuage6.MaxValue = new float[] {
        100F,
        100F,
        10F};
            this.THGuage6.MinPercents = new float[] {
        10F,
        10F,
        10F};
            this.THGuage6.MinValue = new float[] {
        0F,
        0F,
        0F};
            this.THGuage6.ModuleError = false;
            this.THGuage6.Name = "THGuage6";
            this.THGuage6.ParaColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))))};
            this.THGuage6.ParNum = zj.UserDefinedControl.ParNumber.TWO;
            this.THGuage6.Size = new System.Drawing.Size(290, 200);
            this.THGuage6.StateVarName = "模块6异常";
            this.THGuage6.TabIndex = 5;
            this.THGuage6.Title = "6#站点";
            this.THGuage6.Units = new string[] {
        "℃",
        "%",
        "mm"};
            this.THGuage6.ValueNames = new string[] {
        "模块6温度",
        "模块6湿度",
        "参数3"};
            this.THGuage6.Values = new float[] {
        0F,
        0F,
        0F};
            // 
            // checkBoxExt6
            // 
            this.checkBoxExt6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt6.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt6.BoxWidth = 20;
            this.checkBoxExt6.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt6.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt6.Location = new System.Drawing.Point(1089, 314);
            this.checkBoxExt6.Name = "checkBoxExt6";
            this.checkBoxExt6.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt6.TabIndex = 11;
            this.checkBoxExt6.Tag = "6";
            this.checkBoxExt6.Text = "4#站点温度";
            this.checkBoxExt6.UseVisualStyleBackColor = false;
            this.checkBoxExt6.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title1.BackgroundImage")));
            this.title1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.Location = new System.Drawing.Point(744, 8);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(98, 28);
            this.title1.TabIndex = 6;
            this.title1.TitleName = "实时趋势";
            // 
            // checkBoxExt7
            // 
            this.checkBoxExt7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt7.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt7.BoxWidth = 20;
            this.checkBoxExt7.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt7.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt7.Location = new System.Drawing.Point(930, 314);
            this.checkBoxExt7.Name = "checkBoxExt7";
            this.checkBoxExt7.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt7.TabIndex = 12;
            this.checkBoxExt7.Tag = "5";
            this.checkBoxExt7.Text = "3#站点湿度";
            this.checkBoxExt7.UseVisualStyleBackColor = false;
            this.checkBoxExt7.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title2.BackgroundImage")));
            this.title2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title2.Location = new System.Drawing.Point(755, 403);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(98, 28);
            this.title2.TabIndex = 7;
            this.title2.TitleName = "系统日志";
            // 
            // checkBoxExt8
            // 
            this.checkBoxExt8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt8.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt8.BoxWidth = 20;
            this.checkBoxExt8.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt8.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt8.Location = new System.Drawing.Point(771, 314);
            this.checkBoxExt8.Name = "checkBoxExt8";
            this.checkBoxExt8.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt8.TabIndex = 13;
            this.checkBoxExt8.Tag = "4";
            this.checkBoxExt8.Text = "3#站点温度";
            this.checkBoxExt8.UseVisualStyleBackColor = false;
            this.checkBoxExt8.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // chartActualTrend
            // 
            this.chartActualTrend.AxisX.AutoScale = false;
            this.chartActualTrend.AxisX.AutoZoomReset = false;
            this.chartActualTrend.AxisX.Color = System.Drawing.Color.White;
            this.chartActualTrend.AxisX.InitWithScaleView = false;
            this.chartActualTrend.AxisX.IsLogarithmic = false;
            this.chartActualTrend.AxisX.LabelAngle = 0;
            this.chartActualTrend.AxisX.LabelEnabled = true;
            this.chartActualTrend.AxisX.LabelFormat = null;
            this.chartActualTrend.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.chartActualTrend.AxisX.MajorGridCount = 4;
            this.chartActualTrend.AxisX.MajorGridEnabled = true;
            this.chartActualTrend.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartActualTrend.AxisX.Maximum = 1000D;
            this.chartActualTrend.AxisX.Minimum = 0D;
            this.chartActualTrend.AxisX.MinorGridColor = System.Drawing.Color.White;
            this.chartActualTrend.AxisX.MinorGridEnabled = false;
            this.chartActualTrend.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartActualTrend.AxisX.TickWidth = 1F;
            this.chartActualTrend.AxisX.Title = "";
            this.chartActualTrend.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartActualTrend.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartActualTrend.AxisX.ViewMaximum = 1000D;
            this.chartActualTrend.AxisX.ViewMinimum = 0D;
            this.chartActualTrend.AxisX2.AutoScale = false;
            this.chartActualTrend.AxisX2.AutoZoomReset = false;
            this.chartActualTrend.AxisX2.Color = System.Drawing.Color.Black;
            this.chartActualTrend.AxisX2.InitWithScaleView = false;
            this.chartActualTrend.AxisX2.IsLogarithmic = false;
            this.chartActualTrend.AxisX2.LabelAngle = 0;
            this.chartActualTrend.AxisX2.LabelEnabled = true;
            this.chartActualTrend.AxisX2.LabelFormat = null;
            this.chartActualTrend.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.chartActualTrend.AxisX2.MajorGridCount = 6;
            this.chartActualTrend.AxisX2.MajorGridEnabled = true;
            this.chartActualTrend.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartActualTrend.AxisX2.Maximum = 1000D;
            this.chartActualTrend.AxisX2.Minimum = 0D;
            this.chartActualTrend.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.chartActualTrend.AxisX2.MinorGridEnabled = false;
            this.chartActualTrend.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartActualTrend.AxisX2.TickWidth = 1F;
            this.chartActualTrend.AxisX2.Title = "";
            this.chartActualTrend.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartActualTrend.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartActualTrend.AxisX2.ViewMaximum = 1000D;
            this.chartActualTrend.AxisX2.ViewMinimum = 0D;
            this.chartActualTrend.AxisY.AutoScale = true;
            this.chartActualTrend.AxisY.AutoZoomReset = false;
            this.chartActualTrend.AxisY.Color = System.Drawing.Color.White;
            this.chartActualTrend.AxisY.InitWithScaleView = false;
            this.chartActualTrend.AxisY.IsLogarithmic = false;
            this.chartActualTrend.AxisY.LabelAngle = 0;
            this.chartActualTrend.AxisY.LabelEnabled = true;
            this.chartActualTrend.AxisY.LabelFormat = null;
            this.chartActualTrend.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.chartActualTrend.AxisY.MajorGridCount = 6;
            this.chartActualTrend.AxisY.MajorGridEnabled = true;
            this.chartActualTrend.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartActualTrend.AxisY.Maximum = 3.5D;
            this.chartActualTrend.AxisY.Minimum = 0.5D;
            this.chartActualTrend.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.chartActualTrend.AxisY.MinorGridEnabled = false;
            this.chartActualTrend.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartActualTrend.AxisY.TickWidth = 1F;
            this.chartActualTrend.AxisY.Title = "";
            this.chartActualTrend.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartActualTrend.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartActualTrend.AxisY.ViewMaximum = 3.5D;
            this.chartActualTrend.AxisY.ViewMinimum = 0.5D;
            this.chartActualTrend.AxisY2.AutoScale = true;
            this.chartActualTrend.AxisY2.AutoZoomReset = false;
            this.chartActualTrend.AxisY2.Color = System.Drawing.Color.Black;
            this.chartActualTrend.AxisY2.InitWithScaleView = false;
            this.chartActualTrend.AxisY2.IsLogarithmic = false;
            this.chartActualTrend.AxisY2.LabelAngle = 0;
            this.chartActualTrend.AxisY2.LabelEnabled = true;
            this.chartActualTrend.AxisY2.LabelFormat = null;
            this.chartActualTrend.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.chartActualTrend.AxisY2.MajorGridCount = 6;
            this.chartActualTrend.AxisY2.MajorGridEnabled = true;
            this.chartActualTrend.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.chartActualTrend.AxisY2.Maximum = 3.5D;
            this.chartActualTrend.AxisY2.Minimum = 0.5D;
            this.chartActualTrend.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.chartActualTrend.AxisY2.MinorGridEnabled = false;
            this.chartActualTrend.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.chartActualTrend.AxisY2.TickWidth = 1F;
            this.chartActualTrend.AxisY2.Title = "";
            this.chartActualTrend.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.chartActualTrend.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.chartActualTrend.AxisY2.ViewMaximum = 3.5D;
            this.chartActualTrend.AxisY2.ViewMinimum = 0.5D;
            this.chartActualTrend.BackColor = System.Drawing.Color.Transparent;
            this.chartActualTrend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chartActualTrend.ChartAreaBackColor = System.Drawing.Color.Transparent;
            this.chartActualTrend.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.chartActualTrend.DisplayPoints = 4000;
            this.chartActualTrend.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.chartActualTrend.ForeColor = System.Drawing.Color.White;
            this.chartActualTrend.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.chartActualTrend.LegendBackColor = System.Drawing.Color.Transparent;
            this.chartActualTrend.LegendFont = new System.Drawing.Font("微软雅黑", 11F);
            this.chartActualTrend.LegendForeColor = System.Drawing.Color.White;
            this.chartActualTrend.LegendVisible = true;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "1#站点温度";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.chartActualTrend.LineSeries.Add(stripChartXSeries1);
            this.chartActualTrend.Location = new System.Drawing.Point(755, 46);
            this.chartActualTrend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartActualTrend.Miscellaneous.CheckInfinity = false;
            this.chartActualTrend.Miscellaneous.CheckNaN = false;
            this.chartActualTrend.Miscellaneous.CheckNegtiveOrZero = false;
            this.chartActualTrend.Miscellaneous.DirectionChartCount = 3;
            this.chartActualTrend.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.chartActualTrend.Miscellaneous.MaxSeriesCount = 32;
            this.chartActualTrend.Miscellaneous.MaxSeriesPointCount = 4000;
            this.chartActualTrend.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.chartActualTrend.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.chartActualTrend.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.chartActualTrend.Miscellaneous.SplitViewAutoLayout = true;
            this.chartActualTrend.Name = "chartActualTrend";
            this.chartActualTrend.NextTimeStamp = new System.DateTime(((long)(0)));
            this.chartActualTrend.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.chartActualTrend.SeriesCount = 1;
            this.chartActualTrend.Size = new System.Drawing.Size(639, 206);
            this.chartActualTrend.SplitView = false;
            this.chartActualTrend.StartIndex = 0;
            this.chartActualTrend.TabIndex = 8;
            this.chartActualTrend.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.chartActualTrend.TimeStampFormat = null;
            this.chartActualTrend.XCursor.AutoInterval = true;
            this.chartActualTrend.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartActualTrend.XCursor.Interval = 0.001D;
            this.chartActualTrend.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.chartActualTrend.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartActualTrend.XCursor.Value = double.NaN;
            this.chartActualTrend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.chartActualTrend.YCursor.AutoInterval = true;
            this.chartActualTrend.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.chartActualTrend.YCursor.Interval = 0.001D;
            this.chartActualTrend.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.chartActualTrend.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.chartActualTrend.YCursor.Value = double.NaN;
            // 
            // checkBoxExt4
            // 
            this.checkBoxExt4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt4.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt4.BoxWidth = 20;
            this.checkBoxExt4.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt4.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt4.Location = new System.Drawing.Point(1248, 271);
            this.checkBoxExt4.Name = "checkBoxExt4";
            this.checkBoxExt4.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt4.TabIndex = 9;
            this.checkBoxExt4.Tag = "3";
            this.checkBoxExt4.Text = "2#站点湿度";
            this.checkBoxExt4.UseVisualStyleBackColor = false;
            this.checkBoxExt4.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // chkTemp1
            // 
            this.chkTemp1.BackColor = System.Drawing.Color.Transparent;
            this.chkTemp1.BoxBackColor = System.Drawing.Color.White;
            this.chkTemp1.BoxWidth = 20;
            this.chkTemp1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkTemp1.ForeColor = System.Drawing.Color.White;
            this.chkTemp1.Location = new System.Drawing.Point(771, 271);
            this.chkTemp1.Name = "chkTemp1";
            this.chkTemp1.Size = new System.Drawing.Size(139, 37);
            this.chkTemp1.TabIndex = 9;
            this.chkTemp1.Tag = "0";
            this.chkTemp1.Text = "1#站点温度";
            this.chkTemp1.UseVisualStyleBackColor = false;
            this.chkTemp1.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // checkBoxExt3
            // 
            this.checkBoxExt3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExt3.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxExt3.BoxWidth = 20;
            this.checkBoxExt3.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxExt3.ForeColor = System.Drawing.Color.White;
            this.checkBoxExt3.Location = new System.Drawing.Point(1089, 271);
            this.checkBoxExt3.Name = "checkBoxExt3";
            this.checkBoxExt3.Size = new System.Drawing.Size(139, 37);
            this.checkBoxExt3.TabIndex = 9;
            this.checkBoxExt3.Tag = "2";
            this.checkBoxExt3.Text = "2#站点温度";
            this.checkBoxExt3.UseVisualStyleBackColor = false;
            this.checkBoxExt3.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // chkHumi1
            // 
            this.chkHumi1.BackColor = System.Drawing.Color.Transparent;
            this.chkHumi1.BoxBackColor = System.Drawing.Color.White;
            this.chkHumi1.BoxWidth = 20;
            this.chkHumi1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.chkHumi1.ForeColor = System.Drawing.Color.White;
            this.chkHumi1.Location = new System.Drawing.Point(930, 271);
            this.chkHumi1.Name = "chkHumi1";
            this.chkHumi1.Size = new System.Drawing.Size(139, 37);
            this.chkHumi1.TabIndex = 9;
            this.chkHumi1.Tag = "1";
            this.chkHumi1.Text = "1#站点湿度";
            this.chkHumi1.UseVisualStyleBackColor = false;
            this.chkHumi1.CheckedChanged += new System.EventHandler(this.chk_Common_CheckedChanged);
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 621);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMonitor";
            this.Text = "集中监控";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private zj.UserDefinedControl.testGuage THGuage1;
        private zj.UserDefinedControl.testGuage THGuage3;
        private zj.UserDefinedControl.testGuage THGuage5;
        private zj.UserDefinedControl.testGuage THGuage6;
        private zj.UserDefinedControl.testGuage THGuage4;
        private zj.UserDefinedControl.testGuage THGuage2;
        private zj.UserDefinedControl.Title title1;
        private zj.UserDefinedControl.Title title2;
        private SeeSharpTools.JY.GUI.StripChartX chartActualTrend;
        private zj.UserDefinedControl.CheckBoxExt chkTemp1;
        private zj.UserDefinedControl.CheckBoxExt chkHumi1;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt3;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt4;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt5;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt6;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt7;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt8;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt9;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt10;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt11;
        private zj.UserDefinedControl.CheckBoxExt checkBoxExt12;
        private System.Windows.Forms.ListView lsvInfo;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private zj.UserDefinedControl.PanelExt pnlMain;
    }
}