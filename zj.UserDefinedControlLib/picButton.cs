using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.UserDefinedControl.Properties;
//using static System.Net.Mime.MediaTypeNames;


namespace zj.UserDefinedControl
{
    
    /// <summary>
    /// 带图标的按钮
    /// </summary>
    public partial class picButton : Button
    {
        Dictionary<string,Image> keyValuePairs = new Dictionary<string,Image>();
       
        private Graphics gs;
        /// <summary>
        /// 自定义测试事件
        /// </summary>
        public event Action testchangeImage;  //定义一个事件
        #region 按钮图片的枚举类型
        /// <summary>
        /// 枚举按钮的类型属性值
        /// </summary>
        public enum ButtonPresentImg
        {
            None,
            Check,
            Close,
            Cancel,
            Down,
            Back,
            Up
        }
        #endregion
        #region 属性

        private ButtonPresentImg buttontype = ButtonPresentImg.None ;
        /// <summary>
        /// 属性:按钮类型设置属性.并修改其他属性值.
        /// </summary>
        [Browsable(true)]             //可见性设置 true可见 false不可见
        [Category("自定义属性")]    //自定义属性的类型
        [Description("按钮类型设置")]   //指定属性的说明文本
        public ButtonPresentImg ButtonType
        {
            get { return buttontype; }
            set 
            {
                buttontype = value;
                if(buttontype != ButtonPresentImg.None)
                {
                    this.Invalidate();          //强制重绘
                 

                    this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                }
                else
                {
                    gs = null;
                    this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                }
                
              

            }
        }

        #endregion
        #region 构造函数
        public picButton()
        {
            InitializeComponent();
         
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
           

            
        }




        public picButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
        #endregion
        #region 方法
        /// <summary>
        /// 根据名称获取资源中对应的图片
        /// </summary>
        /// <param name="imageName"></param>
        /// <returns></returns>
        private System.Drawing.Image GetImage(string imageName)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly(); //获取当前的程序集
                ResourceManager resourceManager = new ResourceManager("zj.UserDefinedControl.Properties.Resources", assembly);

                object obj = resourceManager.GetObject(imageName);

                return (System.Drawing.Image)obj;
            }
            catch(Exception)
            {
                return null;
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


        #endregion
        #region 事件
       

        /// <summary>
        /// 调用事件委托
        /// </summary>
        public void fun()
        {
            if(testchangeImage!=null)
            {
                testchangeImage.Invoke();
                
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            try
            {
                if (keyValuePairs.Count()==0)
                {
                    string[] buttonTypeNames = Enum.GetNames(typeof(ButtonPresentImg));
                    foreach (string buttonType in buttonTypeNames)
                    {
                        keyValuePairs.Add(buttonType, GetImage(buttonType));
                    }
                }
            
           
                gs = e.Graphics;
                SetGraphics();
                if (buttontype != ButtonPresentImg.None)
                {

                    
                    Image image = keyValuePairs[buttontype.ToString()];
                    gs.DrawImage(image, new Rectangle(0, 0, this.Height, this.Height));
                }
            }
            catch
            {
                throw new Exception("按钮图标绘制失败！确认参数或资源是否存在");
            }
           
                
            
            
        }
    }
}
