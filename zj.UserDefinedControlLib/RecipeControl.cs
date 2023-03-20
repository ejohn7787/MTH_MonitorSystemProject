using MTH_Models.models.Recipe;
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
    public partial class RecipeControl : UserControl
    {
        public RecipeControl()      
        {
            InitializeComponent();
        }
        private string devName="1#站点";
        [Browsable(true)]
        [Description("设置和显示控件的标题并更改各个名称")]
        [Category("自定义属性")]
        public string DevName
        {
            get { return devName; }
            set 
            { 
                devName = value;
                this.titleDevName.TitleName  = devName;
                this.tseTH_HighLimit.TitleName = devName + "温度高限";
                this.tseTH_LowerLimit.TitleName = devName + "温度低限";
                this.tseHum_HighLimit.TitleName = devName + "湿度高限";
                this.tseHum_LowerLimit.TitleName = devName + "湿度低限";

            }
        }
        private RecipeParam recipParam = new RecipeParam();
        [Browsable(false)]
        [Description("设置和显示配方对象")]
        [Category("自定义属性")]
        public RecipeParam RecipParam
        {
            get
            { 
                recipParam=GetRecipParam();  //获取界面更新的配方值到对象字段
                return recipParam; 
            }
            set 
            { 
                recipParam = value; 
                SetRecipParam(recipParam);            //把对象字段的值更新到界面
            }
        }
        /// <summary>
        /// 获取配方值
        /// </summary>
        /// <returns>配方对象</returns>
        private RecipeParam GetRecipParam()
        {

            //获取配方值,对象初始化器获取对象
            return new RecipeParam()
            {
                TempHighLimit = tseTH_HighLimit.CurrentValue,
                TempLowLimit = tseTH_LowerLimit.CurrentValue,
                HumiHighLimit = tseHum_HighLimit.CurrentValue,
                HumiLowLimit = tseHum_LowerLimit.CurrentValue ,
                TempAlarmEnable= chkeTempAlarmEnable.Checked,
                HumiAlarmEnable= chkeHumiAlarmEnable.Checked
            } ;
        }
        /// <summary>
        /// 配方对象的值显示到UI
        /// </summary>
        /// <param name="recipParam">配方对象</param>
        private void SetRecipParam(RecipeParam recipParam)
        {
            tseTH_HighLimit.CurrentValue = recipParam.TempHighLimit;
            tseTH_LowerLimit.CurrentValue = recipParam.TempLowLimit;
            tseHum_HighLimit.CurrentValue = recipParam.HumiHighLimit;
            tseHum_LowerLimit.CurrentValue = recipParam.HumiLowLimit;
            chkeTempAlarmEnable.Checked= recipParam.TempAlarmEnable;
            chkeHumiAlarmEnable.Checked = recipParam.HumiAlarmEnable;
        }

    }
}
