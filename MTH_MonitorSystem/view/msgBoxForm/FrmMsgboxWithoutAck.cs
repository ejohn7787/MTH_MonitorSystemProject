using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTH_MonitorSystem
{
    public partial class FrmMsgboxWithoutAck : Form
    {
        private Point mPoint;       //保存鼠标点击的位置
        public FrmMsgboxWithoutAck(string Info,string title)
        {
            InitializeComponent();
            this.TopMost = true;
            this.lblMsgInfo.Text = Info;
            this.lblTitle.Text = title; 

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #region  实现无边框窗体的鼠标拖动
        /// <summary>
        /// 实现无边框拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMsgboxWithAck_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);      //获取当前的鼠标坐标
        }

        private void FrmMsgboxWithAck_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标左击
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X+(e.X-mPoint.X) , this.Location.Y +( e.Y-mPoint.Y ));
            }
        }
        #endregion
    }
}
