using MTH_Models.models.System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.BLL;
using zj.MTHHelper;

namespace MTH_MonitorSystem
{
    public partial class frmUserManager : Form
    {
        private SysAdminManage sysAdminManage = new SysAdminManage();
        public frmUserManager()
        {
            InitializeComponent();
            this.dgvUserManage.AutoGenerateColumns= false; 
            UpdateData();
        }
        private List<SysAdmin> sysAdmins= new List<SysAdmin>();
        /// <summary>
        /// 更新用户集合
        /// </summary>
        private void UpdateData()
        {
            sysAdmins=sysAdminManage .QuerySysAdmins();
            if(sysAdmins.Count >0)
            {
                this.dgvUserManage.DataSource = null;
                this.dgvUserManage.DataSource = sysAdmins;
            }
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ///界面数据判断
            if(this.txt_LoginName.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("用户名不能为空","添加用户").Show();
                return;
            }
            if (this.txt_LoginPwd1.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("用户密码不能为空", "添加用户").Show();
                return;
            }
            if (this.txt_LoginPwd2.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("验证密码不能为空", "添加用户").Show();
                return;
            }

            if(this.txt_LoginPwd1.Text.Trim()!= this.txt_LoginPwd2.Text.Trim())
            {
                new FrmMsgboxWithoutAck("密码不一致", "添加用户").Show();
                return;
            }
            if(sysAdmins.Where(s=>s.LoginName == this.txt_LoginName.Text.Trim()).Count()>0)
            {
                new FrmMsgboxWithoutAck("该用户名已存在", "添加用户").Show();
                return;
            }
            //添加用户
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName= this.txt_LoginName.Text,
                LoginPwd = this.txt_LoginPwd1.Text,
                ParamSet = chk_ParamSet.Checked,
                Recipe = chk_Recipe.Checked,
                HistoryLog = chk_HistoryLog.Checked,
                HistoryTrend = chk_HistroyTrend.Checked,
                UserManage= chk_UserManage.Checked
            };
            if(sysAdminManage.AddSysAdmin(sysAdmin))
            {
                UpdateData();
            }
            else
            {
                new FrmMsgboxWithoutAck("添加用户失败！", "添加用户").Show();
                
            }
            

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (this.txt_LoginName.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("用户名不能为空", "修改用户").Show();
                return;
            }
            if (this.txt_LoginPwd1.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("用户密码不能为空", "修改用户").Show();
                return;
            }
            if (this.txt_LoginPwd2.Text.Length == 0)
            {
                new FrmMsgboxWithoutAck("验证密码不能为空", "修改用户").Show();
                return;
            }

            if (this.txt_LoginPwd1.Text.Trim() != this.txt_LoginPwd2.Text.Trim())
            {
                new FrmMsgboxWithoutAck("密码不一致", "修改用户").Show();
                return;
            }
            ///如果修改了用户则判断改改名的用户是否存在，直接用通过表格查询
            if (this.dgvUserManage.SelectedRows[0].Cells["LoginName"].Value.ToString()!=this.txt_LoginName.Text.Trim())
            {
                if (sysAdmins.Where(s => s.LoginName == this.txt_LoginName.Text.Trim()).Count() > 0)
                {
                    new FrmMsgboxWithoutAck("该用户名已经存在", "修改用户").Show();
                    return;
                }
            }
          
            //修改用户
            SysAdmin sysAdmin = new SysAdmin()
            {
                
                LoginId= Convert.ToInt32( this.dgvUserManage.SelectedRows[0].Cells["LoginId"].Value),
                LoginName = this.txt_LoginName.Text,
                LoginPwd = this.txt_LoginPwd1.Text,
                ParamSet = chk_ParamSet.Checked,
                Recipe = chk_Recipe.Checked,
                HistoryLog = chk_HistoryLog.Checked,
                HistoryTrend = chk_HistroyTrend.Checked,
                UserManage = chk_UserManage.Checked
            };
            if (sysAdminManage.ModifySysAdmin(sysAdmin))
            {
                UpdateData();
            }
            else
            {
                new FrmMsgboxWithoutAck("修改用户失败！", "修改用户").Show();

            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (sysAdminManage.DelSysAdmin(Convert.ToInt32(this.dgvUserManage.SelectedRows[0].Cells["LoginId"].Value)))
            {
                UpdateData();
            }
            else
            {
                new FrmMsgboxWithoutAck("删除用户失败！", "删除用户").Show();

            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.txt_LoginName.Clear();
            this.txt_LoginPwd1.Clear();
            this.txt_LoginPwd2 .Clear();
            SetCheckBoxs(false);
            
        }
        private void SetCheckBoxs(bool value)
        {
            this.chk_ParamSet.Checked = value;
            this.chk_Recipe.Checked = value;
            this.chk_HistoryLog.Checked = value;
            this.chk_UserManage.Checked = value;
            this.chk_HistroyTrend.Checked = value;  
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            SetCheckBoxs(!this.chk_ParamSet.Checked);
        }
        /// <summary>
        /// 添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserManage_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(sender as DataGridView,e);
        }

        private void dgvUserManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                UpdateInfo(sysAdmins[e.RowIndex]);                       
                //UpdateInfo(sysAdmins[this.dgvUserManage.SelectedRows[0].Index]);         //方法2

            }
        }
        private void UpdateInfo(SysAdmin sysAdmin)
        {
            if(sysAdmin!= null)
            {
                txt_LoginName.Text = sysAdmin.LoginName;
                txt_LoginPwd1.Text= sysAdmin.LoginPwd;
                txt_LoginPwd2.Text= sysAdmin.LoginPwd;
                this.chk_ParamSet.Checked = sysAdmin.ParamSet;
                this.chk_Recipe.Checked = sysAdmin.Recipe;
                this.chk_HistoryLog.Checked = sysAdmin.HistoryLog;
                this.chk_HistroyTrend.Checked = sysAdmin.HistoryTrend;
                this.chk_UserManage.Checked = sysAdmin.UserManage; 
            }
        }

        private void dgvUserManage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex >=2)
            {
               
                object o = e.Value;
                if(o != null)
                {
                    if(o.ToString().ToLower()=="true")
                    {
                        e.Value = "启用";
                    }
                    else
                    {
                        e.Value = "禁用";
                    }
                }
            }
        }
    }
}
