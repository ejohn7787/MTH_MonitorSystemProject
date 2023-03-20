using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static zj.UserDefinedControl.DialPlate;

namespace zj.UserDefinedControl
{
    public partial class ParameterShow : UserControl
    {

        [Description("数据名称")]
        [Category("外观")]
        public string ItemName
        {
            get { return lblItemName.Text; }
            set
            {

                lblItemName.Text = value;


            }
        }
        [Description("单位")]
        [Category("外观")]
        public string Unit
        {
            get { return lblItemUnit.Text; }
            set
            {

                lblItemUnit.Text = value;


            }
        }

        [Description("值")]
        [Category("外观")]
        public string parValue
        {
            get { return lblItemValue.Text; }
            set
            {

                lblItemValue.Text = value;


            }
        }


        public ParameterShow()
        {
            InitializeComponent();

            this.Width = lblItemName.Width + lblItemUnit.Width + lblItemValue.Width;
            lblItemName.Font = this.Font;
            lblItemUnit.Font = this.Font;
            lblItemValue.Font = this.Font;
        }
        /// <summary>
        /// 更新 控件的外观
        /// </summary>
        public void RePaint()
        {

            lblItemName.Font = this.Font;
            lblItemUnit.Font = this.Font;
            lblItemValue.Font = this.Font;
            this.Width = lblItemName.Width + lblItemUnit.Width + lblItemValue.Width;
            this.Height = lblItemUnit.Height;

        }
    }
}
