using MiniExcelLibs;
using MTH_Models.device;
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

using zj.MTHHelper;

namespace MTH_MonitorSystem
{
    public partial class FrmGroupConfig : Form
    {
        private Point mPoint;       //保存鼠标点击的位置
        private string groupPath = Application.StartupPath + "\\Config\\Group.xlsx";
        public FrmGroupConfig()
        {
            InitializeComponent();
            this.cmbStoreArea.DataSource = new string[] { "输入线圈", "输出线圈", "输入寄存器", "输出寄存器" };

            dgvMain.AutoGenerateColumns = false;
            TotalGroups = GetGroups();                //每次加载窗体时获取最新的Groups的信息
                                                      // RefreshGroups();
            if (TotalGroups != null && TotalGroups.Count > 0)
            {
                this.dgvMain.DataSource = null;
                this.dgvMain.DataSource = TotalGroups;
            }

        }
        
        private List<Group> TotalGroups = new List<Group>();  //添加的组列表
        /// <summary>
        /// 获取所有的通信组
        /// </summary>
        /// <returns></returns>
        private List<Group> GetGroups()
        {
            try
            {
                return MiniExcel.Query<Group>(groupPath).ToList();
            }
            catch
            {
                return new List<Group>();
            }
            
              
           
        }
        /// <summary>
        /// 刷新DataGridView里的数据
        /// </summary>
        private void RefreshGroups()
        {
            
                this.dgvMain.DataSource = null;
                this.dgvMain.DataSource = TotalGroups;
            


        }

        /// <summary>
        /// 添加通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = this.txtGroupName.Text.Trim();
            if (groupName.Length == 0)
            {
                new FrmMsgboxWithoutAck("通信组名称不能为空！", "添加通信组").Show();
                return;
            }
            if (IsGroupNameExist(groupName)) //通信组名称已存在
            {
                new FrmMsgboxWithoutAck("通信组名称已存在！", "添加通信组").Show();
                return;
            }
            // 添加一个组的数据
            TotalGroups.Add(new Group()
            {
                GroupName = txtGroupName.Text.Trim(),
                Start = Convert.ToUInt16(this.numStart.Value),
                Length = Convert.ToUInt16(this.numLength.Value),
                StoreArea = this.cmbStoreArea.Text.Trim(),
                Remark = txtRemark.Text.Trim()

            });
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroups, overwriteFile: true);
                new FrmMsgboxWithoutAck("添加通信组成功", "添加通信组").Show();
                //刷新数据
                RefreshGroups();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("添加通信组失败" + ex.Message, "添加通信组").Show();
            }

        }

        #region  实现无边框窗体的鼠标拖动
        /// <summary>
        /// 实现无边框拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGroupConfig_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);      //获取当前的鼠标坐标
        }

        private void FrmGroupConfig_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标左击
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mPoint.X), this.Location.Y + (e.Y - mPoint.Y));
            }
        }
        #endregion
        /// <summary>
        /// DataGridView添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint((DataGridView)sender, e); // 添加行号
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 需要设置单元格内容的显示格式时发生。单元格无参数时，显示“---”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ///单元格无参数时，显示“---”
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object value = this.dgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value; //获取单元格内容
                if (value == null || value.ToString().Length == 0)
                {
                    e.Value = "---";
                }
            }
        }
        /// <summary>
        /// 判断集合中的组名是否存在。
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        private bool IsGroupNameExist(string groupName)
        {
            return TotalGroups.FindAll(c => c.GroupName == groupName).ToList().Count > 0;
        }
        /// <summary>
        /// 删除通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            string groupName = this.txtGroupName.Text.Trim();
            if (!IsGroupNameExist(groupName))
            {
                new FrmMsgboxWithoutAck("通信组名称不存在！", "删除通信组").Show();
                return;
            }
            TotalGroups.RemoveAll(c => c.GroupName == groupName);
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroups, overwriteFile: true);
                RefreshGroups();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("删除通信组失败！" + ex.Message, "删除通信组").Show();
            }

        }
        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyGroup_Click(object sender, EventArgs e)
        {
            string groupName = this.txtGroupName.Text.Trim();
            if (!IsGroupNameExist(groupName))
            {
                new FrmMsgboxWithoutAck("通信组名称不存在！", "删除通信组").Show();
                return;
            }
            Group group = TotalGroups.Find(c => c.GroupName == groupName);  // 找到对应的group对象
            group.Start = Convert.ToUInt16(this.numStart.Value);
            group.Length = Convert.ToUInt16(this.numLength.Value);
            group.StoreArea = this.cmbStoreArea.Text.Trim();
            group.Remark = this.txtRemark.Text.Trim();
            try
            {
                MiniExcel.SaveAs(groupPath, TotalGroups, overwriteFile: true);
                RefreshGroups();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("修改通信组失败！" + ex.Message, "修改通信组").Show();
            }
        }
        /// <summary>
        /// 点击单元格的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Group group = TotalGroups[e.RowIndex];  //获取Group对象
                UpdateGroup(group);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="group"></param>
        private void UpdateGroup(Group group)
        {
            if (group != null)
            {
                this.txtGroupName.Text = group.GroupName;
                this.numStart.Text = group.Start.ToString();
                this.numLength.Text = group.Length.ToString();
                this.cmbStoreArea.Text = group.StoreArea;
                this.txtRemark.Text = group.Remark;

            }
        }
    }
}
