using MiniExcelLibs;
using MTH_Models.device;
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
using thinger.DataConvertLib;
using zj.MTHHelper;

namespace MTH_MonitorSystem
{
    public partial class FrmVariableConfig : Form
    {
        #region 字段
        private Point mPoint;                                                                      //保存鼠标点击的位置
        private string groupPath = Application.StartupPath + "\\Config\\Group.xlsx";               //组的表
        private string variablePath = Application.StartupPath + "\\Config\\Variable.xlsx";         //变量的表
        private List<Variable> TotalVariables = new List<Variable>();                              //添加的变量列表
        #endregion
        #region 构造函数
        public FrmVariableConfig()
        {
            InitializeComponent();
            this.cmbDataType.DataSource = Enum.GetNames(typeof(DataType));

            dgvMain.AutoGenerateColumns = false;
            List<Group> TotalGroups = GetGroups();                //每次加载窗体时获取最新的Groups的信息
            if (TotalGroups != null && TotalGroups.Count > 0)
            {
                foreach (var item in TotalGroups)
                {
                    this.cmbGroupName.Items.Add(item.GroupName);
                }
                this.cmbGroupName.SelectedIndex = 0;
                
            }
            TotalVariables = GetVariables();
            var list = GetVariablesByGroupName(this.cmbGroupName.Text.Trim());
            if (list != null && list.Count > 0)
            {
                this.dgvMain.DataSource = null;
                this.dgvMain.DataSource = list;
            }

           

        }
        #endregion


       
        /// <summary>
        /// 添加通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddVar_Click(object sender, EventArgs e)
        {
            string varName = this.txtVarName.Text.Trim();
            if (varName.Length == 0)
            {
                new FrmMsgboxWithoutAck("变量名称不能为空！", "添加变量").Show();
                return;
            }
            if (IsVarNameExist(varName)) //变量名称已存在
            {
                new FrmMsgboxWithoutAck("变量名称已存在！", "添加变量").Show();
                return;
            }
            // 添加一个变量的数据
            TotalVariables.Add(new Variable()
            {
                VarName = varName,
                Start = Convert.ToUInt16(this.numStart.Value),
                OffsetOrLength = Convert.ToUInt16(this.numOffsetOrLength.Value),
                DataType = this.cmbDataType.Text.Trim(),
                GroupName = this.cmbGroupName.Text.Trim(),
                PosAlarm = this.chkPosAlarm.Checked,
                NegAlarm = this.chkNegAlarm.Checked,
                Scale = Convert.ToSingle(this.numScale.Value),
                Offset = Convert.ToSingle(this.numOffset.Value),
                Remark = txtRemark.Text.Trim()

            });
            try
            {
                MiniExcel.SaveAs(variablePath, TotalVariables, overwriteFile: true);
                new FrmMsgboxWithoutAck("添加变量成功", "添加变量").Show();
                //刷新数据
                RefreshVariable();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("添加变量失败" + ex.Message, "添加变量").Show();
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
        /// 删除变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelVariable_Click(object sender, EventArgs e)
        {
            string varName = this.txtVarName.Text.Trim();
            if (!IsVarNameExist(varName))
            {
                new FrmMsgboxWithoutAck("变量名称不存在！", "删除变量").Show();
                return;
            }
            TotalVariables.RemoveAll(c => c.VarName  == varName);
            try
            {
                MiniExcel.SaveAs(variablePath, TotalVariables, overwriteFile: true);
                RefreshVariable();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("删除变量失败！" + ex.Message, "删除通信组").Show();
            }

        }
        /// <summary>
        /// 修改通信组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyGroup_Click(object sender, EventArgs e)
        {
            string varName = this.txtVarName.Text.Trim();
            if (!IsVarNameExist(varName))
            {
                new FrmMsgboxWithoutAck("变量名称不存在！", "删除变量").Show();
                return;
            }
            Variable variable = TotalVariables.Find(c => c.VarName == varName);  //找到对应的变量对象

            variable.Start = Convert.ToUInt16(this.numStart.Value);
            variable.OffsetOrLength = Convert.ToUInt16(this.numOffsetOrLength.Value);
            variable.GroupName = this.cmbGroupName.Text.Trim();
            variable.PosAlarm = this.chkPosAlarm.Checked;
            variable.NegAlarm = this.chkNegAlarm.Checked;
            variable.Scale = Convert.ToSingle(numScale.Value);
            variable.Offset = Convert.ToSingle (numOffset.Value);
            variable.DataType = this.cmbDataType.Text.Trim();
            variable.Remark = this.txtRemark.Text.Trim();
            try
            {
                MiniExcel.SaveAs(variablePath, TotalVariables, overwriteFile: true);
                RefreshVariable();
            }
            catch (Exception ex)
            {
                new FrmMsgboxWithoutAck("修改变量失败！" + ex.Message, "修改变量").Show();
            }
        }
        /// <summary>
        /// 点击单元格的事件，点击时获取行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Variable var = TotalVariables [e.RowIndex];  //获取Group对象
                UpdateVariable(var);
            }
        }
      
       
        /// <summary>
        /// ComboBox选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshVariable();
        }

        #region 通用方法
        /// <summary>
        /// 更新界面
        /// </summary>
        /// <param name="group"></param>
        private void UpdateVariable(Variable var)
        {
            if (var != null)
            {

                this.cmbGroupName.Text = var.GroupName;
                this.txtVarName.Text = var.VarName;
                this.numStart.Text = var.Start.ToString();
                this.numOffsetOrLength.Text = var.OffsetOrLength.ToString();
                this.cmbDataType.Text = var.DataType;
                this.chkPosAlarm.Checked = var.PosAlarm;
                this.chkNegAlarm.Checked = var.NegAlarm;
                this.numScale.Value = Convert.ToDecimal(var.Scale);
                this.numOffset.Value = Convert.ToDecimal(var.Offset);
                this.txtRemark.Text = var.Remark;

            }
        }
        /// <summary>
        /// 判断集合中的变量组名是否存在。
        /// </summary>
        /// <param name="varName"> 变量名 </param>
        /// <returns></returns>
        private bool IsVarNameExist(string varName)
        {
            return TotalVariables.FindAll(c => c.VarName == varName).ToList().Count > 0;
        }
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
        /// 获取所有变量
        /// </summary>
        /// <returns></returns>
        private List<Variable> GetVariables()
        {
            try
            {
                return MiniExcel.Query<Variable>(variablePath).ToList();
            }
            catch
            {
                return new List<Variable>();
            }
        }

        private List<Variable> GetVariablesByGroupName(string groupName)
        {
            if (groupName.Length == 0)
            {
                return TotalVariables;
            }
            else
            {

                return TotalVariables.FindAll(c => c.GroupName == groupName);

            }

        }
        /// <summary>
        /// 刷新DataGridView里的数据
        /// </summary>
        private void RefreshVariable()
        {
            var list = GetVariablesByGroupName(this.cmbGroupName.Text.Trim());
            this.dgvMain.DataSource = null;
            this.dgvMain.DataSource = list;



        }
        #endregion
    }
}
