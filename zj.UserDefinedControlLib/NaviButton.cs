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
    [DefaultEvent("Click")]
    public partial class NaviButton : UserControl
    {
        public NaviButton()
        {
            InitializeComponent();
        }
        #region 属性
        private bool isSelected = false;
        [Browsable(true)]
        [Description("是否选中导航按钮")]
        [Category("外观")]
        public bool IsSelected
        {
            get { return isSelected; }
            set 
            {
                isSelected = value;
                UpdateImage();
            }
        }
        private bool isLeft = true ;
        [Browsable(true)]
        [Description("是否位于左边")]
        [Category("外观")]
        public bool IsLeft
        {
            get { return isLeft ; }
            set
            { 
                isLeft = value;
                UpdateImage();
            }
        }

        private string title = "导航按钮";
        [Browsable(true)]
        [Description("是否位于左边")]
        [Category("外观")]
        public string Title
        { 
            get { return title; }
            set 
            { 
                title =  value;
                lblTitle.Text = this.title;
            }
        }

        #endregion
        #region 方法
        /// <summary>
        ///修改背景图片的方法
        /// </summary>
        private void UpdateImage()
        {
            if(this.IsLeft)
            {
                this.BackgroundImage = isSelected?Properties.Resources.LeftSelected : Properties.Resources.LeftUnSelected;
            }
            else
            {
                this.BackgroundImage = isSelected ? Properties.Resources.RightSelected : Properties.Resources.RightUnSelected;
            }
        }
        #endregion

        #region 事件
        public new EventHandler Click;
        #endregion
        /// <summary>
        /// 点击label标签触发自定义按钮的click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this,e);
        }
    }
}
