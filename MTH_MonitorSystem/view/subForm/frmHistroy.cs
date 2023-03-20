using MTH_Models.models.device;
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
using zj.UserDefinedControl;

namespace MTH_MonitorSystem
{
    public partial class frmHistory : Form
    {
        #region 字段
        /// <summary>
        /// 数据库访问
        /// </summary>
        private ActualDataManage actualDataManage = new ActualDataManage ();
        private Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
        /// <summary>
        /// 建立一个控件的容器，使历史趋势图中的图例按指定的顺序排列
        /// </summary>
        private List<CheckBoxExt> checkBoxExts= new List<CheckBoxExt> ();
        #endregion
        #region 构造函数
        public frmHistory()
        {
            InitializeComponent();
            ///这部分代码可以试着用反射来简化，做一个通用的方法，别的地方都能用
            {
                checkBoxExts.Add(this.chkTemp1);
                checkBoxExts.Add(this.chkHumi1);
                checkBoxExts.Add(this.chkTemp2);
                checkBoxExts.Add(this.chkHumi2);
                checkBoxExts.Add(this.chkTemp3);
                checkBoxExts.Add(this.chkHumi3);
                checkBoxExts.Add(this.chkTemp4);
                checkBoxExts.Add(this.chkHumi4);
                checkBoxExts.Add(this.chkTemp5);
                checkBoxExts.Add(this.chkHumi5);
                checkBoxExts.Add(this.chkTemp6);
                checkBoxExts.Add(this.chkHumi6);
            }
           
            dtp_Start.Value = DateTime.Now.AddHours(-2); //设置当前时间前两小时
            dtp_End.Value = DateTime.Now;
            //初始化 chart
            //X轴类型
            this.chartHisTrend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.String;
            //设置图例
            this.chartHisTrend.LegendVisible = false;
            //显示的点数
            this.chartHisTrend.DisplayPoints = 100000;
            //Y1轴范围
            this.chartHisTrend.AxisY.Minimum = 0.0f;
            this.chartHisTrend.AxisY.Maximum = 100.0f;
            //Y轴不能缩放
            this.chartHisTrend.AxisY.AutoScale = false;


        }
        #endregion
        #region 方法
        /// <summary>
        /// 为了实现中文标签和数据库字段对象名称之间的对应关系,建立所有的参数列表
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> GetKeyValues()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            foreach (var item in checkBoxExts)         //遍历控件内所有的CheckBoxExt控件
            {
                if (item.Tag != null && item.Tag.ToString().Length > 0)
                {
                    if (item.Checked)
                    {
                        keyValuePairs.Add(item.Tag.ToString(), item.Text);
                    }
                }
            }
            return keyValuePairs;
        }
        /// <summary>
        /// 根据数据选择情况，获取数据库数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private  OperateResult<DataTable> QueryProcess(string start,string end)
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
            DataTable dataTable = actualDataManage.QueryActualDataByCondition(start, end, keyValuePairs.Keys.ToList());
            if (dataTable != null)
            {
                return OperateResult.CreateSuccessResult(dataTable);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("未查询到数据！");
            }
        }
        /// <summary>
        /// 更新历史趋势图
        /// </summary>
        /// <param name="dataTable"></param>
        private void UpDateChart(DataTable dataTable)
        {

            //获取记录数,和列数
            int rowCount = dataTable.Rows.Count;
            int columnCount = keyValuePairs.Count;
            //设置chart
           
            this.chartHisTrend.Clear();          
            this.chartHisTrend.SeriesCount = columnCount;
            
           

            for(int i = 0;i < keyValuePairs.Count; i++)
            {

                this.chartHisTrend.Series[i].Name = keyValuePairs.Values.ToList()[i];
                this.chartHisTrend.Series[i].Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle; 

            }
           //解析DataTable
            double[,] Ydata = new double[columnCount,rowCount];
            string[] Xdata = new string[rowCount];
            for(int i=0;i<rowCount;i++)
            {
                for(int j=0;j<columnCount;j++)
                {
                    if (dataTable.Rows[i][j+1] is DBNull)
                    {
                        Ydata[j,i] = 0.0f;
                    }
                    else
                    {
                        try
                        {
                            Ydata[j, i] = Convert.ToDouble(dataTable.Rows[i][j + 1]);
                        }
                        catch(Exception)
                        {
                            Ydata[j, i] = 0.0f;
                        }
                    }
                }
                Xdata[i] = Convert.ToDateTime(dataTable.Rows[i][0]).ToString("HH:mm:ss");
            }
            this.chartHisTrend.Plot(Ydata, Xdata);
        }
        
        #endregion
        #region 事件

        private void btn_Query_Click(object sender, EventArgs e)
        {
           // 准备参数
            keyValuePairs= GetKeyValues();          //获取要查询的参数
            string start = this.dtp_Start.Text;
            string end = this.dtp_End.Text;
            if(keyValuePairs.Count == 0)
            {
                new FrmMsgboxWithoutAck("请勾选需要查询的参数！","查询出错");
                return;
            }
            //查询数据库
            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
                {
                    return QueryProcess(start, end );

                });
            var task2 = task1.ContinueWith(task => {
                this.Invoke(new Action(() =>
                {
                    if(task.Result.IsSuccess)
                    {
                        UpDateChart(task.Result.Content);
                    }
                    else
                    {
                        new FrmMsgboxWithoutAck("查询出错"+ task.Result.Message,"查询错误！").Show();
                    }
                }));
            });
        }
        #endregion

        private void btn_QuickQuery_Click(object sender, EventArgs e)
        {
            this.dtp_Start.Value = DateTime.Now.AddHours(-5.0f);
            this.dtp_End.Value = DateTime.Now;
            this.btn_Query_Click(null,null);
        }

        private void btn_SaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件(*.jpg)|*.jpg|所有文件|*.*";
            saveFileDialog.FileName = "历史趋势图片" + DateTime.Now.ToString("yyyyMMddHHmmss");
            saveFileDialog.Title = "历史趋势保存";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.AddExtension = true;

            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                this.chartHisTrend.SaveAsImage (saveFileDialog.FileName);
                if (new FrmMsgboxWithAck("导出趋势图片成功，是否立刻打开？", "打开趋势图片").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }

        private void btn_ExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV文件(*.csv)|*.csv|所有文件|*.*";
            saveFileDialog.FileName = "历史趋势CSV" + DateTime.Now.ToString("yyyyMMddHHmmss");
            saveFileDialog.Title = "历史趋势CSV保存";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.chartHisTrend.SaveAsCsv(saveFileDialog.FileName);
                if (new FrmMsgboxWithAck("导出趋势CSV成功，是否立刻打开？", "打开趋势CSV").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }
    }
}
