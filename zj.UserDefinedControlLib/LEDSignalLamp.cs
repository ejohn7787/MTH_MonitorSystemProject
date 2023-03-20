using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace zj.UserDefinedControl
{
    public partial class LEDSignalLamp : UserControl
    {
     
        private Graphics gs;
        #region 属性
        private Color LEDTrueColor = Color.Red;
        [Browsable(true)]             //可见性设置 true可见 false不可见
        [Category("外观")]    //自定义属性的类型
        [Description("信号灯亮颜色")]   //指定属性的说明文本
        public Color GetLEDTrueColor
        {
            get { return LEDTrueColor; }
            set
            {
                LEDTrueColor = value;
                this.Invalidate();
            }
        }

        private Color LEDFalseColor = Color.DarkRed;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Category("外观")]              //自定义属性的类型
        [Description("信号灯灭颜色")]   //指定属性的说明文本
        public Color GetLEDFalseColor
        {
            get { return LEDFalseColor; }
            set
            {
                LEDFalseColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 信号灯ON/OFF状态
        /// </summary>
        private bool status = false;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("信号灯状态")]
        [Category("外观")]
        public bool Status
        {
            get { return status; }
            set
            {
                status = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 边缘空白
        /// </summary>
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("信号灯内补白")]
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
        /// <summary>
        /// 信号灯是否要边框
        /// </summary>
        private bool isborder=false ;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("信号灯是否要边框")]
        [Category("外观")]
        public bool isBorder
        {
            get { return isborder; }
            set
            {
                isborder = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 信号灯边宽
        /// </summary>
        private float borderWidthRatio = 0.1f;
        [Browsable(true)]               //可见性设置 true可见 false不可见

        public float BorderWidthRatio
        {
            get { return borderWidthRatio; }
            set 
            { 
                if(value > 1.0f)
                {
                    borderWidthRatio = 0.1f;
                }
                borderWidthRatio = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 边与灯的空白比例
        /// </summary>
        private float borderGapRatio=0.1f;
        [Browsable(true)]               //可见性设置 true可见 false不可见

        public float BorderGapRatio
        {
            get { return borderGapRatio; }
            set 
            {
                if (value > 1.0f)
                {
                    borderGapRatio = 0.1f;
                }
                borderGapRatio = value;
                this.Invalidate();
            }
        }

        private bool gradient = false ;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("是否渐变色")]
        [Category("外观")]
        public bool Gradient
        {
            get { return gradient ; }
            set 
            { 
                gradient  = value;
                this.Invalidate();
            }
        }

        private Color centerColor = Color.White ;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("中心色")]
        [Category("外观")]
        public Color CenterColor
        {
            get { return centerColor ; }
            set 
            {
                centerColor = value;
                this.Invalidate();          //强制重绘
            }
        }


        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public LEDSignalLamp()
        {
            InitializeComponent();
            //将指定的 System.Windows.Forms.ControlStyles 标志设置为 true 或 false。
            /***********************************************************************
             * 如果为 true，则控件忽略窗口消息 WM_ERASEBKGND 以减少闪烁。 
             * 仅当将 ControlStyles.UserPaint 位设置为 true 时，才应用此样式。
             ************************************************************************/ 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint ,true );
            /************************************************************************
             * 如果为 true，则控件将首先绘制到缓冲区而不是直接绘制到屏幕，这可以减少闪烁。
             * 如果将此属性设置为 true，则还应将 AllPaintingInWmPaint设置为 true。
             **************************************************************************/
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /************************************************
             * 绘制原始灯
             *************************************************/
           
            gs = e.Graphics;  //获取画布
            //提高绘画质量
            SetGraphics();
            //判断矩形的宽高取最小值
            int ledWidth = Math.Min(this.Width, this.Height);
            //按钮控件的内补白
            int ledpadding = Math.Max(Padding.Left + Padding.Right, Padding.Top + Padding.Bottom);
            //按钮的直径
            int ledDiameter = ledWidth - ledpadding;                                     
            Brush lampBrush = null;
            //获取绘制的园的外接矩形
            Rectangle rectangle = new Rectangle(Padding.Left, Padding.Top, ledDiameter, ledDiameter);
            if (ledDiameter <0)
            {
                return;
            }
            //按钮的半径
            int ledRadius = ledDiameter / 2;
            //按钮内部填充窗体背景色的直径
            int ledBorderGapDiameter = ledDiameter - (int)(ledRadius * borderGapRatio) - (int)(ledRadius * borderWidthRatio * 2);
            if(ledBorderGapDiameter <0)
            {
                return;
            }
            // 信号灯外边的尺寸
            int ledBorderXY =(int)((ledRadius * borderGapRatio) / 2 + ledRadius * borderWidthRatio); 
            if(gradient )  //可变色
            {
                GraphicsPath graphicsPath = new GraphicsPath();  //封闭路径对象
                graphicsPath.AddEllipse(rectangle);
                PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);  //沿封闭路径建立画刷
                pathGradientBrush.CenterColor = centerColor;                                 //中心色

                pathGradientBrush.SurroundColors =new Color[]{ status ? LEDTrueColor : LEDFalseColor }; //边缘色
                lampBrush = pathGradientBrush;

            }
            else
            {
                lampBrush = new SolidBrush(status ? LEDTrueColor : LEDFalseColor);
            }



            gs.FillEllipse(lampBrush, rectangle);
            if(isborder )
            {
                //画圆环
                gs.DrawEllipse(new Pen(this.BackColor, ledRadius * borderGapRatio), new Rectangle(Padding.Left + ledBorderXY, Padding.Top + ledBorderXY, ledBorderGapDiameter, ledBorderGapDiameter));
            }

        }
        /// <summary>
        /// 提高绘图质量
        /// </summary>
        private void SetGraphics()
        {
            gs.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;                   //指定抗锯齿的呈现。
            gs.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;                 //指定抗锯齿的呈现。
            gs.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;         //在有提示的情况下使用每个字符的标志符号 ClearType 位图来绘制字符。
            gs.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;                //在无提示的情况下使用每个字符的抗锯齿效果标志符号位图来绘制字符。
            gs.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;  //插补模式
        }
    }
}
