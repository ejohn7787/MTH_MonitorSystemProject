using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace zj.UserDefinedControl
{
   /// <summary>
   /// 做为控件容器的panel.减少显示闪烁
   /// </summary>
    public partial class PanelExt : Panel
    {
        #region 属性
      
        /// <summary>
        /// 边缘内空白
        /// </summary>
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边缘内补白")]
        [Category("外观")]
        public new Padding Padding 
        {
            get { return base.Padding; }
            set
            {
                base.Padding= value;
                this.Invalidate();
            }
        }
        
        /// <summary>
        /// 边缘外空白
        /// </summary>
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边缘外补白")]
        [Category("外观")]
        public new Padding Margin 
        {
            get { return base.Margin; }
            set
            {
                base.Margin = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 边框宽度
        /// </summary>
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边框宽度")]
        [Category("外观")]
        private int borderWidth = 1;
        public int BorderWidth
        { 
            get { return borderWidth; }
            set 
            {
                borderWidth = value;
                this.Invalidate();
            }
        }
        private Color borderColor = Color.FromArgb(35,255,253);
        /// <summary>
        /// 边框颜色
        /// </summary>
        [Browsable(true)]               //可见性设置 true可见 false不可见
        [Description("边框颜色")]
        [Category("外观")]
        public Color BorderColor
        {
            get { return borderColor; }
            set 
            { 
                borderColor = value;
                this.Invalidate();
            }
        }





        #endregion
        public PanelExt()
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
        /// <summary>
        /// 绘制控件背景的事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //解决窗体刷新，放大和闪烁的效果
           return;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            if(this.BackgroundImage!=null)
            {
                SetGraphics(e.Graphics);
                e.Graphics.DrawImage(this.BackgroundImage, new Rectangle(0,0,this.Width ,this.Height),new Rectangle(0,0,this.BackgroundImage.Width ,this.BackgroundImage .Height),GraphicsUnit.Pixel);

            }
            base.OnPaint(e);
            
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
