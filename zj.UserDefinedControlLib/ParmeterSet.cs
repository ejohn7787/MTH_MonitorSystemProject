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
    public partial class ParmeterSet : UserControl
    {
        #region  自定义属性
       
        [Description("数据名称")]
        [Category("外观")]
        public string ItemName
        {
            get { return lblItemName .Text  ; }
            set 
            { 
                
                lblItemName.Text = value;
                

            }
        }
        [Description("单位")]
        [Category("外观")]
        public string Unit
        {
            get { return lblUnit .Text ; }
            set
            {

                lblUnit.Text = value;
                

            }
        }


        #endregion
        public ParmeterSet()
        {
            InitializeComponent();
            
        }
    }
}
