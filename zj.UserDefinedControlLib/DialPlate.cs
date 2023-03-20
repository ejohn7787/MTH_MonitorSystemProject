using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zj.UserDefinedControl
{
    /// <summary>
    /// 表盘样式枚举
    /// </summary>

    public enum GaugeStyle
    {
        Needle,
        Level
    }
    /// <summary>
    ///  表盘表示的参数个数
    /// </summary>
    public enum ParNumber
    {
        ONE,
        TWO,
        THREE,
    }
    /// <summary>
    /// 表盘用户控件
    /// </summary>
    public partial class DialPlate : UserControl
    {
        #region 类内类型


        /// <summary>
        /// 刻度盘数据的数据结构
        /// </summary>
        public struct MarkValue
        {
            public string strvalue;          //刻度的值

            public float x;               //刻度字符串的x轴坐标
            public float y;               //刻度字符串的y轴坐标
        }


        #endregion
        #region 字段
        /// <summary>
        ///  字符串 显示方式
        /// </summary>
        private StringFormat stringFormat = new StringFormat();
        #endregion
        #region 属性
        #region 全盘外观
        private GaugeStyle gaugeStyle = GaugeStyle.Needle;
        /// <summary>
        /// 表盘显示类型
        /// </summary>
        [Browsable(true)]
        [Description("表盘显示类型")]
        [Category("外观")]
        public GaugeStyle GaugeStyle
        {
            get { return gaugeStyle; }
            set
            {
                gaugeStyle = value;
                this.Invalidate();
            }
        }

        private ParNumber parNumber = ParNumber.ONE;
        /// <summary>
        /// 表示的参数数量
        /// </summary>
        [Browsable(true)]
        [Description("表示的参数数量")]
        [Category("外观")]
        public ParNumber ParNumber
        {
            get { return parNumber; }
            set
            {
                parNumber = value;
                this.Invalidate();
            }
        }
        #endregion
        #region 刻度部分
        #region 颜色

        private Color[] paraColors = { Color.FromArgb(187, 187, 0), Color.FromArgb(187, 0, 187), Color.FromArgb(0, 187, 187) };   //默认色;
        /// <summary>
        /// 参数颜色
        /// </summary>
        [Browsable(true)]
        [Description("参数颜色")]
        [Category("外观")]
        public Color[] ParaColors
        {
            get { return paraColors; }
            set
            {
                paraColors = value;
                this .Invalidate();
            }
        }



        private Color alarmColor = Color.FromArgb(36, 184, 196);
        /// <summary>
        /// 表盘报警颜色
        /// </summary>
        [Browsable(true)]
        [Description("表盘报警颜色")]
        [Category("外观")]
        public Color AlarmColor
        {
            get { return alarmColor; }
            set
            {
                alarmColor = value;
                this.Invalidate();
            }
        }
        #endregion


        private int textRange = 30;
        /// <summary>
        ///表盘刻度文字区域范围
        /// </summary>
        public int TextRange
        {
            get { return textRange; }
            set
            {
                textRange = value;
                this.Invalidate();
            }
        }

        private int textGap = 15;
        [Browsable(true)]
        [Description("表盘文字与线的间隔")]
        [Category("外观")]
        public int TextGap
        {
            get { return textGap; }
            set
            {
                textGap = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 表盘线宽
        /// </summary>
        private int dialWidth = 5;           //默认值为10
        /// <summary>
        /// 表盘线宽
        /// </summary>
        [Browsable(true)]
        [Description("表盘线宽")]
        [Category("外观")]
        public int DialWidth
        {
            get { return dialWidth; }
            set
            {
                dialWidth = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 边缘空白
        /// </summary>
        [Browsable(true)]
        [Description("表盘内补白")]
        [Category("外观")]
        public new Padding Padding
        {

            get { return base.Padding; }
            set
            {
                base.Padding = value;
                this.Invalidate();
            }

        }

        private int markNum = 7;
        /// <summary>
        /// 间隔数量
        /// </summary>
        [Browsable(true)]
        [Description("刻度数量")]
        [Category("外观")]
        public int MarkNum
        {
            get { return markNum; }
            set
            {
                markNum = value;
                this.Invalidate();
            }
        }

        private float[] dialMinRanges = { 0.0f, 0.0f, 0.0f };
        /// <summary>
        /// 表盘范围最小值
        /// </summary>
        [Browsable(true)]
        [Description("表盘范围最小值")]
        [Category("外观")]
        public float[] DialMinRanges
        {
            get { return dialMinRanges; }
            set
            {
                dialMinRanges = value;
                this.Invalidate();
            }
        }


        private float[] dialMaxRanges = { 10.0f, 10.0f, 10.0f };
        /// <summary>
        /// 表盘范围最大值
        /// </summary>
        [Browsable(true)]
        [Description("表盘范围最大值")]
        [Category("外观")]
        public float[] DialMaxRanges
        {
            get { return dialMaxRanges; }
            set
            {
                dialMaxRanges = value;
                this.Invalidate();
            }
        }







        #endregion
        #region 内圈部分
        private int centerRadius = 10;
        [Browsable(true)]
        [Description("表盘中心点半径")]
        [Category("外观")]
        public int CenterRadius
        {
            get { return centerRadius; }
            set
            {
                if (value > 0)
                {
                    centerRadius = value;
                }
                else
                {
                    centerRadius = 5;
                }
                this.Invalidate();

            }
        }

        private int pointerGap = 10;
        [Browsable(true)]
        [Description("表盘指针与线的间隔")]
        [Category("外观")]
        public int PointerGap
        {
            get { return pointerGap; }
            set
            {
                pointerGap = value;
                this.Invalidate();

            }

        }

        private int levelWidth = 10;
        /// <summary>
        /// 当使用液位计模式时的表示宽度
        /// </summary>
        [Browsable(true)]
        [Description(" 当使用液位计模式时的表示宽度")]
        [Category("外观")]
        public int LevelWidth
        {
            get { return levelWidth; }
            set
            {
                levelWidth = value;
                this.Invalidate();
            }
        }

        private int levelGap = 5;
        [Browsable(true)]
        [Description("值得液位表示间隔")]
        [Category("外观")]
        public int LevelGap
        {
            get { return levelGap; }
            set
            {
                levelGap = value;
                this.Invalidate();
            }
        }


        #endregion
        #region 参数部分

        private float[] paraRangeMinPercents = { 10.0f, 10.0f, 10.0f };
        /// <summary>
        /// 参数的低限百分比
        /// </summary>
        [Browsable(true)]
        [Description("参数的低限百分比")]
        [Category("外观")]
        public float[] ParaRangeMinPercents
        {
            get { return paraRangeMinPercents; }
            set
            {
                paraRangeMinPercents = value;
                this.Invalidate();
            }
        }

        private float[] paraRangeMaxPercents = { 90.0f, 90.0f, 90.0f };
        /// <summary>
        /// 参数的高限百分比
        /// </summary>
        [Browsable(true)]
        [Description("参数的高限百分比")]
        [Category("外观")]
        public float[] ParaRangeMaxPercents
        {
            get { return paraRangeMaxPercents; }
            set
            {
                paraRangeMaxPercents = value;
                this.Invalidate();
            }
        }


        private float[] gaugeValues = new float[3];
        [Browsable(true)]
        [Description("当前数值")]
        [Category("外观")]
        public float[] GaugeValues
        {
            get { return gaugeValues; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] >= dialMinRanges[i] && value[i] <= dialMaxRanges[i])
                    {
                        gaugeValues[i] = value[i];
                    }
                    else
                    {
                        gaugeValues[i] = 0f;
                    }
                }


                this.Invalidate();

            }
        }

        #endregion


        #endregion

        private Graphics gs;
        private int diameter;
        public DialPlate()
        {
            InitializeComponent();
            //将指定的 System.Windows.Forms.ControlStyles 标志设置为 true 或 false。
            /***********************************************************************
             * 如果为 true，则控件忽略窗口消息 WM_ERASEBKGND 以减少闪烁。 
             * 仅当将 ControlStyles.UserPaint 位设置为 true 时，才应用此样式。
             ************************************************************************/
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            /************************************************************************
             * 如果为 true，则控件将首先绘制到缓冲区而不是直接绘制到屏幕，这可以减少闪烁。
             * 如果将此属性设置为 true，则还应将 AllPaintingInWmPaint设置为 true。
             **************************************************************************/
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            stringFormat.Alignment = StringAlignment.Center;      //水平居中
            stringFormat.LineAlignment = StringAlignment.Center;  //垂直居中
        }

        private void MyGaugePanel_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;         //设置双缓冲
            base.OnPaint(e);
            #region 异常处理
            if (this.Width * 0.5 > this.Height)  //判断控件的宽度大于高度的一半
            {
                return;
            }
            if (this.Width <= 20 || this.Height <= 20)
            {
                return;
            }
            #endregion
            #region 获取画布
            gs = e.Graphics;    //获取控件的画布
            SetGraphics(gs);     //设置绘图质量
            #endregion
            try
            {
                for (int i = 0; i < (int)parNumber + 1; i++)
                {
                    #region 绘制刻度
                    //   获取 画笔
                    Pen DialPen = new Pen(paraColors[i], dialWidth);
                    Pen DialAlarmPen = new Pen(alarmColor, dialWidth);

                    int alarmAngleMin = (int)(180 * paraRangeMinPercents[i] / 100);
                    int alarmAngleMax = (int)(180 * paraRangeMaxPercents[i] / 100);
                    int left = this.Padding.Left + (DialWidth / 2) * ((2 * (i + 1) - 1)) + ((textGap + textRange) * i);
                    int top = this.Padding.Top + (DialWidth / 2) * ((2 * (i + 1) - 1)) + ((textGap + textRange) * i);
                    int maxPadding = Math.Max(this.Padding.Bottom + this.Padding.Top, this.Padding.Left + this.Padding.Right);

                    diameter = this.Width - maxPadding - ((DialWidth / 2) * ((2 * (i + 1) - 1)) + ((textGap + textRange) * i)) * 2;  //刻度圈的直径


                    if (diameter < 0)
                    {
                        return;
                    }

                    if (alarmAngleMin != 0)
                    {
                        gs.DrawArc(DialAlarmPen, left, top, diameter, diameter, 180, alarmAngleMin);
                    }

                    gs.DrawArc(DialPen, left, top, diameter, diameter, 180 + alarmAngleMin, alarmAngleMax - alarmAngleMin);
                    gs.DrawArc(DialAlarmPen, left, top, diameter, diameter, 180 + alarmAngleMax, 180 - alarmAngleMax);
                    gs.TranslateTransform(this.Width / 2, this.Width / 2);                  //坐标原点转为表的指针中心
                    gs.RotateTransform(-90);           //逆时针旋转坐标系
                    SolidBrush solidBrush;
                    float markAngleOffset = 180.0f / (markNum - 1); //获取标记角度的偏移;

                    for (int j = 0; j < markNum; j++)        //画垂直刻度
                    {


                        if (markAngleOffset * j > alarmAngleMin && markAngleOffset * j < alarmAngleMax)
                        {
                            solidBrush = new SolidBrush(paraColors[i]);
                        }
                        else
                        {
                            solidBrush = new SolidBrush(alarmColor);
                        }
                        Rectangle rectMark = new Rectangle();
                        rectMark.X = -3;
                        rectMark.Width = 6;
                        rectMark.Height = (int)(dialWidth * 2);
                        rectMark.Y = -((this.Width / 2) - left + (rectMark.Height / 2));
                        gs.FillRectangle(solidBrush, rectMark);
                        gs.RotateTransform(markAngleOffset);
                    }
                    #endregion
                    #region  绘制数字文本

                    gs.RotateTransform(-markAngleOffset * markNum);  //坐标返回
                    gs.RotateTransform(90);           //顺时针旋转坐标系
                                                      //绘制文本
                    ///获取值的偏移值
                    float rangeAvgDiff = (dialMaxRanges[i] - dialMinRanges[i]) / (markNum - 1);

                    for (int j = 0; j < markNum; j++)
                    {
                        float angle = -180f + j * markAngleOffset;  //获取文字的角度
                        float radius = diameter / 2;
                        float showValue = DialMinRanges[i] + rangeAvgDiff * j;
                        MarkValue markValue = (MarkValue)meterMark(angle, showValue, radius);

                        SizeF sizeF = gs.MeasureString(markValue.strvalue, this.Font);  //获取字体尺寸
                        RectangleF rectangleF = new RectangleF(markValue.x - (sizeF.Width / 2f), markValue.y, sizeF.Width, sizeF.Height);
                        gs.DrawString(markValue.strvalue, this.Font, new SolidBrush(paraColors[i]), rectangleF, stringFormat);

                    }
                    #endregion
                    #region 绘制内圈数据
                    if (gaugeStyle == GaugeStyle.Needle)
                    {
                        //绘制指针式
                        //            //画点
                        FillCircle();
                        //            //画指针
                        float p = (gaugeValues[i] - dialMinRanges[i]) / (dialMaxRanges[i] - dialMinRanges[i]);
                        if (p > 0)
                        {
                            DrawLine(p, i);
                        }

                    }
                    else
                    {
                        //绘制液位式
                        Pen pen = new Pen(ParaColors[i], levelWidth);
                        float sweepAngle = ((gaugeValues[i] - dialMinRanges[i]) / (dialMaxRanges[i] - dialMinRanges[i])) * 180;
                        int OutRangeWidth = ((int)parNumber + 1) * (DialWidth + textGap + textRange + Padding.Left);
                        float X = -(this.Width * 0.5f - OutRangeWidth - (levelWidth * 0.5f * ((2 * (i + 1) - 1))) - levelGap * i);
                        float Y = -(this.Width * 0.5f - OutRangeWidth - (levelWidth * 0.5f * ((2 * (i + 1) - 1))) - levelGap * i);
                        float WidthX = this.Width - OutRangeWidth * 2 - levelWidth * ((2 * (i + 1) - 1)) - levelGap * 2 * i;
                        float WidthY = this.Width - OutRangeWidth * 2 - levelWidth * ((2 * (i + 1) - 1)) - levelGap * 2 * i;

                        if (sweepAngle >= 0 && sweepAngle <= 180)
                        {

                            gs.DrawArc(pen, new RectangleF(X, Y, WidthX, WidthY), 180.0f, sweepAngle);

                        }


                    }


                    gs.TranslateTransform(-this.Width / 2, -this.Width / 2);                  //坐标原点转为表的指针中心
                    #endregion
                }
            }
            catch (Exception)
            {
                return;
            }
            

        }

        private void SetGraphics(Graphics graphics)
        {
            
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //指定抗锯齿
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        }
        /// <summary>
        /// 初始化 字符的结构体，
        /// </summary>
        /// <param name="angle">字符所在角度</param>
        /// <param name="value">字符的值</param>
        /// <param name="radius">字符所在半径</param>
        /// <returns></returns>
        private MarkValue? meterMark(float angle, float value, float radius)
        {
            MarkValue markValue = new MarkValue();          //获取字符结构

            if (radius > 0)  //如果半径大于0 
            {
                string strTemp = value.ToString();
                int pIndex = strTemp.IndexOf('.');    //判断小数位数
                if (pIndex == -1)
                {
                    markValue.strvalue = strTemp;   //刻度数据
                }
                else
                {
                    markValue.strvalue = value.ToString("f1");
                }

                markValue.x = (float)((radius - textGap) * Math.Cos(angle * Math.PI / 180));  // 角度值切换为弧度值
                markValue.y = (float)((radius - textGap) * Math.Sin(angle * Math.PI / 180));
                return markValue;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 画表的中心点
        /// </summary>
        private void FillCircle()
        {
            Rectangle rec = new Rectangle(-centerRadius / 2, -centerRadius / 2, centerRadius, centerRadius);
            gs.FillEllipse(new SolidBrush(Color.Blue), rec);
        }
        /// <summary>
        /// 绘制表的指针
        /// </summary>
        /// <param name="percent"> 位置的占整个量程的百分比</param>
        /// <param name="i"> 第几层的表 </param>
        private void DrawLine(float percent, int i)
        {
            float Pointerlen = (diameter / 2) - textGap - pointerGap;
            if (Pointerlen < 0.0)
            {
                return;
            }
            int x = (int)(Pointerlen * Math.Cos((1 + percent) * Math.PI));
            int y = (int)(Pointerlen * Math.Sin((1 + percent) * Math.PI));
            gs.DrawLine(new Pen(ParaColors[i], 3), 0, 0, x, y);
        }
    }
}
