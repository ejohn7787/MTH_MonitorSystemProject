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
    public partial class DialPanel : UserControl
    {
        #region 属性
        private string title = "1#站点";
        /// <summary>
        /// 设置表盘的标题
        /// </summary>
        [Browsable(true)]
        [Description("设置表盘的标题")]
        [Category("外观")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                lblTitle.Text = title;
                this.Invalidate();
            }
        }

       

        private bool moduleError = false;
        /// <summary>
        /// 模块出错
        /// </summary>
        [Browsable(true)]
        [Description("模块出错")]
        [Category("外观")]
        public bool ModuleError
        {
            get { return moduleError ; }
            set 
            {
                moduleError  = value;
                lblTitle.BackColor= moduleError ? Color.Red : Color.Olive;
            }
        }


        private string  temp = "0.0";
        [Browsable(true)]
        [Description("温度值")]
        [Category("外观")]
        public string  Temp
        {
            get { return temp ; }
            set 
            {
                if (temp != value)
                {
                    temp = value;
                    parShowTemp.parValue = temp;
                    if (float.TryParse(temp, out float val))
                    {
                        this.dialPlate.GaugeValues[0] = val;
                    }
                    else
                    {
                        this.dialPlate.GaugeValues[0] = 0.0f;
                    }
                }
               
            }
        }

        private string humidity = "0.0";
        [Browsable(true)]
        [Description("温度值")]
        [Category("外观")]
        public string Humidity
        { 
            get { return humidity; }
            set
            {
                if(humidity != value)
                {
                    humidity = value;
                    parShowHumi.parValue = humidity;
                    if(float.TryParse (humidity,out float val))
                    {
                        this.dialPlate.GaugeValues[1] = val;
                    }
                    else
                    {
                        this.dialPlate.GaugeValues[1] = 0.0f;
                    }
                }
                    
            }
        }



        #endregion
        public DialPanel()
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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }


    }
}
