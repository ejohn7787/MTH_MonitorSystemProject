using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static zj.UserDefinedControl.DialPlate;

namespace zj.UserDefinedControl
{
    public partial class testGuage : UserControl
    {
        private ParameterShow[] parameterShows = new ParameterShow[3];

            
        private string title = "1#站点";
        /// <summary>
        /// 标题
        /// </summary>
        [Browsable(true)]
        [Description("标题")]
        [Category("自定义属性")]
        public string Title
        {
            get { return title; }
            set 
            { 
                title = value; 
                lblTitle.Text = title;

            }
        }

        private bool moduleError = false;
        /// <summary>
        /// 模块出错
        /// </summary>
        [Browsable(true)]
        [Description("模块出错")]
        [Category("自定义属性")]
        public bool ModuleError
        {
            get { return moduleError; }
            set
            {
                moduleError = value;
                lblTitle.BackColor = moduleError ? Color.Red : Color.Olive;
            }
        }

        private string stateVarName;
        /// <summary>
        /// 模块状态变量名
        /// </summary>
        [Browsable(true)]
        [Description("模块状态变量名")]
        [Category("自定义属性")]
        public string StateVarName
        {
            get { return stateVarName; }
            set { stateVarName = value; }
        }

        /// <summary>
        /// 参数数量
        /// </summary>
        [Browsable(true)]
        [Description("参数数量")]
        [Category("自定义属性")]
        public ParNumber ParNum
        {
            get { return dialPlate1.ParNumber; }
            set 
            {
                flpBottom.Controls.Clear();
                if (dialPlate1.ParNumber != value)
                {
                    
                    dialPlate1.ParNumber = value;
                    CommonParameterShowIni();
                    this.Invalidate();
                }
               
               
            }
        }
        /// <summary>
        /// 当前值
        /// </summary>
        [Browsable(true)]
        [Description("当前值")]
        [Category("自定义属性")]
        public float[] Values
        {
            get { return dialPlate1.GaugeValues; }
            set
            {
               if(dialPlate1.GaugeValues != value)
               {
                    dialPlate1.GaugeValues = value;
                    
                    this.Invalidate();
                }
                
               
            }
        }

        private string[] valueNames = {"参数1","参数2","参数3"};
        /// <summary>
        /// 参数名
        /// </summary>
        [Browsable(true)]
        [Description("参数名")]
        [Category("自定义属性")]
        public string[] ValueNames
        {
            get { return valueNames ; }
            set { valueNames  = value; }
        }

        private string[] units = { "℃","%","mm"};
        /// <summary>
        /// 参数单位
        /// </summary>
        [Browsable(true)]
        [Description("参数单位")]
        [Category("自定义属性")]
        public string[] Units
        {
            get { return units; }
            set { units = value; }
        }

        [Browsable(true)]
        [Description("参数最小值")]
        [Category("自定义属性")]
        public float[] MinValue 
        {
            get { return dialPlate1.DialMinRanges; }
            set { dialPlate1.DialMinRanges = value; }
        }
        [Browsable(true)]
        [Description("参数最大值")]
        [Category("自定义属性")]
        public float[] MaxValue
        {
            get { return dialPlate1.DialMaxRanges; }
            set 
            { 
                dialPlate1.DialMaxRanges = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 参数的低限百分比
        /// </summary>
        [Browsable(true)]
        [Description("参数的低限百分比")]
        [Category("自定义属性")]
        public float[] MinPercents
        {
            get { return dialPlate1.ParaRangeMinPercents; }
            set
            {
                dialPlate1.ParaRangeMinPercents = value;
                this.Invalidate();
            }
        }

      
        /// <summary>
        /// 参数的高限百分比
        /// </summary>
        [Browsable(true)]
        [Description("参数的高限百分比")]
        [Category("自定义属性")]
        public float[] MaxPercents
        {
            get { return dialPlate1.ParaRangeMaxPercents; }
            set
            {
                dialPlate1.ParaRangeMaxPercents = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 参数颜色
        /// </summary>
        [Browsable(true)]
        [Description("参数颜色")]
        [Category("自定义属性")]
        public Color[] ParaColors
        {
            get { return dialPlate1.ParaColors; }
            set
            {
                dialPlate1.ParaColors = value;
                this.Invalidate();
            }
        }



        public testGuage()
        {
            InitializeComponent();
            CommonParameterShowIni();
        }

        private void testGuage_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //dialPlate1.Font = this.Font;

            //dialPlate1.Height = (this.Width -Padding.Left -Padding.Right)/2+20 ;
            //int h = this.Height - dialPlate1.Height-Padding.Top -Padding .Bottom -20;
            //if(h > 0)
            //{
            //    flpBottom.Height = h;
            //}

            for (int i = 0; i < (int)ParNum + 1; i++)
            {
                //    //parameterShows[i] = new ParameterShow();
                //    //parameterShows[i].Width = dialPlate1.Width / 2 - 3;
                //    //parameterShows[i].Name = this.valueNames[i];
                      parameterShows[i].ItemName = this.valueNames[i];
                      parameterShows[i].parValue = dialPlate1.GaugeValues[i].ToString("f1");
                      parameterShows[i].Unit = units[i];
                //    parameterShows[i].Font = this.Font;
                //    parameterShows[i].RePaint();
                //    //Graphics gs = this.CreateGraphics();
                //    //SizeF sizeF = gs.MeasureString("test", this.Font);  //获取字体尺寸
                //    //parameterShows[i].Font = this.Font;
                //    //parameterShows[i].Height = (int)sizeF.Height;

            }




        }
        /// <summary>
        /// 通用的初始化参数显示
        /// </summary>
        private void CommonParameterShowIni()
        {
            for (int i = 0; i < 3; i++)
            {
                parameterShows[i] = new ParameterShow();
                parameterShows[i].Width = dialPlate1.Width / 2 - 3;
                parameterShows[i].Name = this.valueNames[i];
                parameterShows[i].ItemName = this.valueNames[i];
                parameterShows[i].parValue = Values[i].ToString("f1");
                parameterShows[i].Unit = units[i];
                Graphics gs = this.CreateGraphics();
                SizeF sizeF = gs.MeasureString("test", this.Font);  //获取字体尺寸
                parameterShows[i].Font = this.Font;
                parameterShows[i].Height = (int)sizeF.Height;
                if(i<=(int)ParNum)
                {
                    flpBottom.Controls.Add(parameterShows[i]);
                }
                
            }
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testGuage_SizeChanged(object sender, EventArgs e)
        {
           
            dialPlate1.Font = this.Font;
            Graphics gs = this.CreateGraphics();             //为了获取字体尺寸，实例化一个gs
            SizeF sizeF = gs.MeasureString("1", this.Font);  //获取字体尺寸
            //设置表头的高度=表的半径+一个字体的高度。
            dialPlate1.Height = (this.Width - Padding.Left - Padding.Right) / 2 + (int)sizeF.Height +3 ; 
            //计算控件剩余高度
            int h = this.Height - dialPlate1.Height - Padding.Top - Padding.Bottom ;
            if (h > 0)
            {
                flpBottom.Height = h;     //设置下部的流面板的高度
            }

            for (int i = 0; i < (int)ParNum + 1; i++)
            {
                //parameterShows[i] = new ParameterShow();
                //parameterShows[i].Width = dialPlate1.Width / 2 - 3;
                //parameterShows[i].Name = this.valueNames[i];
                parameterShows[i].ItemName = this.valueNames[i];
                parameterShows[i].parValue = dialPlate1.GaugeValues[i].ToString("f1");
                parameterShows[i].Unit = units[i];
                parameterShows[i].Font = this.Font;
                parameterShows[i].RePaint();
                //Graphics gs = this.CreateGraphics();
                //SizeF sizeF = gs.MeasureString("test", this.Font);  //获取字体尺寸
                //parameterShows[i].Font = this.Font;
                //parameterShows[i].Height = (int)sizeF.Height;

            }
        }
    }
}
