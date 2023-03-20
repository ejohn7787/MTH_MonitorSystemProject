using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zj.UserDefinedControl
{

    /// <summary>
    /// 扩展CheckBox控件
    /// </summary>
    public partial class CheckBoxExt : CheckBox
    {
        private StringFormat stringFormat = new StringFormat();
        private int boxWidth = 20;
        [Browsable(true)]
        [Description("选择框的大小")]
        [Category("自定义属性")]
        public int BoxWidth
        {
            get { return boxWidth; }
            set 
            { 
                boxWidth = value; 
                this.Invalidate();
            }
        }

        private Color boxBackColor = Color.White ;
        [Browsable(true)]
        [Description("选中框的背景颜色")]
        [Category("自定义属性")]
        public Color BoxBackColor
        {
            get { return boxBackColor; }
            set 
            {
                boxBackColor = value;
                this.Invalidate();
            }
        }



        private Color checkedColor = Color.FromArgb(3,25,66);
        [Browsable(true)]
        [Description("选中框的颜色")]
        [Category("自定义属性")]
        public Color CheckedColor 
        {
            get { return checkedColor; }
            set
            {
                checkedColor = value; 
                this.Invalidate();
            }
        }


        public CheckBoxExt()
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
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            base.OnPaintBackground(pevent); // 清除原有控件，只剩背景
            Graphics gs = pevent.Graphics;
            SetGraphics(gs);     //设置绘图质量
            Rectangle checkRectangle;
            Rectangle textRectangle;
            CalculatorRectangle(out checkRectangle,out textRectangle);
            SolidBrush solidBrush = new SolidBrush(boxBackColor);
            gs.FillRectangle(solidBrush, checkRectangle);
            Pen pen = new Pen(Color.LightGray);
            gs.DrawRectangle(pen, checkRectangle);
            if(this.CheckState == CheckState.Checked)
            {
                //画勾
                drawCheckedFlag(gs, checkRectangle, checkedColor);
            }
            gs.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRectangle,stringFormat);

        }
        /// <summary>
        /// 获取ChectBox的两个矩形区域
        /// </summary>
        /// <param name="checkRectangle"></param>
        /// <param name="textRectangle"></param>
        private void CalculatorRectangle(out Rectangle checkRectangle,out Rectangle textRectangle)
        {
            checkRectangle = new Rectangle(3, (this.Height- boxWidth)/2,boxWidth , boxWidth);
            textRectangle = new Rectangle(checkRectangle.Right + 3, 0, Width - checkRectangle.Right - 6, this.Height);
        }

        private void drawCheckedFlag(Graphics gs,Rectangle rectangle,Color color)
        {
            PointF[] pointFs = new PointF[3];
            pointFs[0] = new PointF(rectangle.X + rectangle.Width / 4.5f, rectangle.Y + rectangle.Height / 2.5f);
            pointFs[1] = new PointF(rectangle.X + rectangle.Width / 2.5f, rectangle.Bottom - rectangle.Height /3.0f);
            pointFs[2] = new PointF(rectangle.Right - rectangle.Width / 4.0f, rectangle.Y + rectangle.Height / 4.5f);
            Pen pen = new Pen(color,2.0f);
            gs.DrawLines(pen, pointFs);
        }

        private void SetGraphics(Graphics graphics)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  //指定抗锯齿
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        }
    }
}
