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
   
    public partial class TextSetEx : UserControl
    {
        public TextSetEx()
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
            lblTitle.Font = this.Font;
            lblUnit.Font = this.Font;
            numValue.Font = this.Font;
            
        }

        private string titleName="1#站点温度高限";
        [Browsable(true)]
        [Description("标题文本")]
        [Category("自定义属性")]
        public string TitleName 
        {
            get { return titleName   ; }
            set 
            { 
                titleName  = value; 
                this.lblTitle .Text = titleName;
            }
        }
       

        //private string alarmVarName="模块1异常";
        //[Browsable(true)]
        //[Description("报警绑定的变量名称")]
        //[Category("自定义属性")]
        //public string AlarmVarName
        //{
        //    get { return alarmVarName; }
        //    set { alarmVarName = value; }
        //}
        private float currentValue= 0.0f;
        [Browsable(true)]
        [Description("变量当前值")]
        [Category("自定义属性")]
        public float  CurrentValue
        {
            get 
            { 
                currentValue=Convert.ToSingle(this.numValue.Value);
                return currentValue; 
            }
            set 
            { 
                if(currentValue != value)
                {
                    currentValue = value;
                    numValue.Value = Convert.ToDecimal(currentValue);
                   
                }
            }
                
        }
        //private bool isAlarm;
        //[Browsable(true)]
        //[Description("是否报警")]
        //[Category("自定义属性")]
        //public bool IsAlarm
        //{
            
        //    get { return isAlarm; }
        //    set 
        //    {
        //        if(isAlarm != value)
        //        {
        //            isAlarm = value;
                  
        //        }
               
        //    }
        //}

        private string unit="℃";

        public string Unit
        {
            get { return unit; }
            set 
            {
                unit = value;
                lblUnit.Text = unit;    
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            lblTitle.Font = this.Font;
            lblUnit.Font = this.Font;
            numValue.Font = this.Font;
            
        }
       
    }
}
