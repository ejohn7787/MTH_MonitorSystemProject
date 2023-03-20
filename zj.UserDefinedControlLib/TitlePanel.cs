using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace zj.UserDefinedControl
{
    

    public partial class TitlePanel : Panel
    {
        private Graphics graphics;
        private StringFormat stringFormat = new StringFormat();
        private int headHeight = 30;
        [Browsable(true)]             //可见性设置 true可见 false不可见
        [Category("自定义属性")]    //自定义属性的类型
        [Description("标题的高度")]   //指定属性的说明文本
        public int HeadHeight
        {
            get { return headHeight; }
            set
            { 
                headHeight = value;
                this.Invalidate();   //修改控件属性后立即反应使控件图像无效,调用重绘.
            }
            
        }

        public TitlePanel()
        {
            InitializeComponent();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
        }

        public TitlePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //绘制
           
            graphics = e.Graphics;
            graphics.DrawRectangle(new Pen(Color.Gray, 1), 2, 2, this.Width - 4, this.Height - 4);
            graphics.FillRectangle(new SolidBrush(Color.Blue), 2, 2, this.Width - 4, headHeight);
            graphics.DrawString("title", this.Font, new SolidBrush(Color.White), new RectangleF(2, 2, this.Width - 4,headHeight ), stringFormat);  //居中显示文字

        }


    }
}
