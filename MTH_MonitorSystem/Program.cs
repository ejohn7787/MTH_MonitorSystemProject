using MTH_MonitorSystem.view.popForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTH_MonitorSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //启动登录界面
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.TopMost =true;
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                //启动主画面
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

            
        }
    }
}
