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
    /// 带边框的Panel控件
    /// </summary>
    public partial class PanelEx : Panel
    {
        public PanelEx()
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
            //是否支持透明色
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        private int topGap = 1;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("设置上边间隙")]
        [Category("自定义属性")]
        public int TopGap
        {
            get { return topGap; }
            set
            { 
                topGap = value;
                this.Invalidate();
            }
        }
        private int bottomGap = 1;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("设置下边间隙")]
        [Category("自定义属性")]
        public int BottomGap
        {
            get{ return bottomGap;   }
            set
            {
                bottomGap = value;
                this.Invalidate();
            }
             
         
        }
        private int leftGap = 1;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("设置左边间隙")]
        [Category("自定义属性")]
        public int LeftGap
        {
            get { return leftGap; }
            set 
            { 
                leftGap = value;
                this.Invalidate();
            }
        }
        private int rightGap = 1;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("设置右边间隙")]
        [Category("自定义属性")]
        public int RightGap
        {
            get { return rightGap; }
            set 
            { 
                rightGap = value;
                this.Invalidate();
            }
        }

        private int borderWidth = 2;
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边框的宽度")]
        [Category("自定义属性")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set 
            { 
                borderWidth = value;
                this.Invalidate();
            }
        }

        private Color borderColor=Color.FromArgb(35,255,253);
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边框的颜色")]
        [Category("自定义属性")]
        public Color BorderColor
        {
            get { return borderColor; }
            set 
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);    
            Graphics gs = e.Graphics;
            Pen pen = new Pen(borderColor,borderWidth);
            float x = leftGap + borderWidth * 0.5f;
            float y = topGap + borderWidth * 0.5f;
            float width = this.Width - leftGap - rightGap - borderWidth;
            float height = this.Height - topGap - bottomGap - borderWidth;
            gs.DrawRectangle(pen,x,y,width,height);
        }






    }
}
