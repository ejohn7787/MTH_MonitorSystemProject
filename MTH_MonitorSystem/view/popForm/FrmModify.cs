using MTH_MonitorSystem.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTH_MonitorSystem.view.popForm
{
    public partial class FrmModify : Form
    {
        private Point mPoint;
        /// <summary>
        /// 变量标签
        /// </summary>
        private string bindVarName = string.Empty;
        public FrmModify( string titleName,string bindVarName,string currentVal)
        {
            InitializeComponent();
            lblVarName.Text = titleName;
            lblCurrentVal.Text = currentVal;
            this.bindVarName = bindVarName;
            this.txtSetVal.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool result = commonObj .CommonWrite(bindVarName,txtSetVal.Text.Trim());
            if(result)
            {
                this.DialogResult =DialogResult.OK;
            }
            else
            {
                new FrmMsgboxWithoutAck("参数修改失败！", "参数修改");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region  实现无边框窗体的鼠标拖动
        /// <summary>
        /// 实现无边框拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModify_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);      //获取当前的鼠标坐标
        }

        private void FrmModify_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标左击
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mPoint.X), this.Location.Y + (e.Y - mPoint.Y));
            }
        }
        #endregion

        private void txtSetVal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }
    }
}
