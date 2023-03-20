using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using zj.BLL;
using zj.MTHHelper;

namespace MTH_MonitorSystem
{
    public partial class frmAlarm : Form
    {
        private SysLogManage syslogManage = new SysLogManage();
        public frmAlarm()
        {
            InitializeComponent();
            dgvMain.AutoGenerateColumns = false;
            cmb_AlarmType.Items.AddRange(new string[]
            {
                "全部",
                "触发",
                "消除"
            });
            cmb_AlarmType.SelectedIndex = 0;
            dtp_Start.Value = DateTime.Now.AddHours(-2); //设置当前时间前两小时
            dtp_End.Value = DateTime.Now;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            string start = this.dtp_Start.Text;
            string end = this.dtp_End.Text;
            string alarmType = this.cmb_AlarmType.Text == "全部" ? "" : this.cmb_AlarmType.Text;  //当全部时，没有查询条件
            //开启一个线程查询
            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
            {
                return QueryProcess(start, end, alarmType);

            });
            var task2 = task1.ContinueWith(task =>
            {
                this.Invoke(new Action(() =>
                {
                    if (task.Result.IsSuccess)
                    {
                        this.dgvMain.DataSource = null;
                        this.dgvMain.DataSource = task.Result.Content;
                    }
                    else
                    {
                        new FrmMsgboxWithoutAck("查询失败：" + task.Result.Message, "报警查询").Show();
                    }
                }));
            });

        }
        private OperateResult<DataTable> QueryProcess(string start, string end, string alarmType)
        {
            //判断时间
            DateTime startDateTime = Convert.ToDateTime(start);
            DateTime endDateTime = Convert.ToDateTime(end);
            if (startDateTime >= endDateTime)
            {
                return OperateResult.CreateFailResult<DataTable>("开始时间不能大于结束时间！");
            }
            //限制查询时间范围
            TimeSpan timeSpan = endDateTime - startDateTime;
            if (timeSpan.TotalHours > 24.0)
            {
                return OperateResult.CreateFailResult<DataTable>("查询范围不能大于24小时！");
            }
            DataTable dataTable = syslogManage.QuerySysLogByCondition(start, end, alarmType);
            if (dataTable != null)
            {
                return OperateResult.CreateSuccessResult(dataTable);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("未查询到数据！");
            }
        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(sender as DataGridView, e);  //添加行号
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XSLX文件(*.xlsx)|*.xlsx|所有文件|*.*";
            saveFileDialog.Title = "导出历史报警";
            saveFileDialog.FileName = "历史报警" + DateTime.Now.ToString("yyyyMMddHHmmss");
            saveFileDialog.DefaultExt = "xslx";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MiniExcel.SaveAs(saveFileDialog.FileName, this.dgvMain.DataSource);
                if (new FrmMsgboxWithAck("导出报警成功，是否立刻打开？", "打开报警记录").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }
    }
}
