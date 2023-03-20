using MTH_Models.models.System;    //引入模型层
using MTH_MonitorSystem.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.BLL;                     //引入逻辑业务层                       

namespace MTH_MonitorSystem.view.popForm
{

    public partial class FrmLogin : Form
    {
        private Point mPoint;
        /// <summary>
        /// 逻辑业务层实例
        /// </summary>
        private SysAdminManage adminManage = new SysAdminManage();
        public FrmLogin()
        {
            InitializeComponent();
        }
     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //验证数据
            if(txtLoginName.Text .Trim().Length==0)
            {
                new FrmMsgboxWithoutAck("请填写登录用户名！", "登录提示").ShowDialog();
                this.txtLoginName.Focus ();
                return;
            }
            if ( txtPwd .Text.Trim().Length == 0)
            {
                new FrmMsgboxWithoutAck("请填写登录密码！", "登录提示").ShowDialog();
                this.txtPwd.Focus();
                return;
            }
            //封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName = txtLoginName.Text.Trim(),
                LoginPwd = txtPwd.Text.Trim()
            };

            sysAdmin = adminManage.AdminLogin(sysAdmin);      //获取用户信息
            if(sysAdmin == null)
            {
                new FrmMsgboxWithoutAck("用户名或密码不正确！", "登录提示").ShowDialog();
                this.txtLoginName.Focus();
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                //存储登录用户信息
                commonObj.CurrentAdmin = sysAdmin;
            }
        }

        #region  实现无边框窗体的鼠标拖动
        /// <summary>
        /// 实现无边框拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);      //获取当前的鼠标坐标
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标左击
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mPoint.X), this.Location.Y + (e.Y - mPoint.Y));
            }
        }
        #endregion

        private void txtLoginName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter) //如果按下回车键
            {

            }
        }

        #region 启用软键盘的方法
        private void StartKeyBoard()
        {
            //打开软键盘
            try
            {
                if (!System.IO.File.Exists(Environment.SystemDirectory + "\\osk.exe"))
                {
                    MessageBox.Show("软件盘可执行文件不存在！");
                    return;
                }

                softKey = System.Diagnostics.Process.Start(Environment.SystemDirectory + "\\osk.exe");
                // 上面的语句在打开软键盘后，系统还没用立刻把软键盘的窗口创建出来了。所以下面的代码用循环来查询窗口是否创建，只有创建了窗口
                // FindWindow才能找到窗口句柄，才可以移动窗口的位置和设置窗口的大小。这里是关键。
                IntPtr intptr = IntPtr.Zero;
                while (IntPtr.Zero == intptr)
                {
                    System.Threading.Thread.Sleep(100);
                    intptr = FindWindow(null, "屏幕键盘");
                }


                // 获取屏幕尺寸
                int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
                int iActulaHeight = Screen.PrimaryScreen.Bounds.Height;


                // 设置软键盘的显示位置，底部居中
                int posX = (iActulaWidth - 1000) / 2;
                int posY = (iActulaHeight - 300);


                //设定键盘显示位置
                MoveWindow(intptr, posX, posY, 1000, 300, true);


                //设置软键盘到前端显示
                SetForegroundWindow(intptr);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // 申明要使用的dll和api
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "MoveWindow")]
        public static extern bool MoveWindow(System.IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        private System.Diagnostics.Process softKey;
        #endregion

        private void txtLoginName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartKeyBoard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
