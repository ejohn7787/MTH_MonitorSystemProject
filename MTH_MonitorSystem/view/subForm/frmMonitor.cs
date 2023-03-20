using MTH_MonitorSystem.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.UserDefinedControl;

namespace MTH_MonitorSystem
{
    public partial class frmMonitor : Form
    {
        #region 字段
        /// <summary>
        /// 建立一个定时器
        /// </summary>
        private Timer updateTimer = new Timer();
        #endregion
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// 功能：
        /// 1、初始化图表控件
        /// 2、初始化定时器
        /// </summary>
        public frmMonitor()
        {
            InitializeComponent();
            SetChart();                       //初始化图表控件
            lsvInfo.Columns[1].Width = lsvInfo.Width - lsvInfo.Columns[0].Width-25;
            updateTimer.Interval = 1000; //定时器设置1秒间隔
            updateTimer.Tick += UpdateTimer_Tick;     //绑定定时事件
            updateTimer.Start();

            //绑定窗体关闭事件，用 lamda 表达式
            this.FormClosing += (sender, e) =>
            {
                updateTimer.Stop();             //关闭定时器
            };
        }
        #endregion
        /// <summary>
        /// 定时器的定时事件，利用frmMain窗体的多线程中读取的数据更新界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (commonObj.Device.IsConnected)
            {
                foreach (var item in pnlMain.Controls.OfType<testGuage>())
                {
                    //更新温湿度表
                    UpdateTestGuage(item);
                    this.Refresh();
                }
                //更新趋势曲线
                List<double> ydata = new List<double>();
                for(int i=1; i <=6; i++)
                {
                    ydata.Add(Convert.ToDouble(commonObj.Device[$"模块{i}温度"]));
                    ydata.Add(Convert.ToDouble(commonObj.Device[$"模块{i}湿度"]));
                }
                this.chartActualTrend.PlotSingle(ydata.ToArray());
            }
        }
        /// <summary>
        /// 更新温湿度表
        /// </summary>
        /// <param name="Guage"></param>
        private void UpdateTestGuage(testGuage Guage)
        {
            if (commonObj.Device[Guage.ValueNames[0]] != null)
            {
                Guage.Values[0]=Convert.ToSingle(commonObj.Device[Guage.ValueNames[0]]);
            }
            if (commonObj.Device[Guage.ValueNames[1]] != null)
            {
                Guage.Values[1] = Convert.ToSingle(commonObj.Device[Guage.ValueNames[1]]);
            }
            if (commonObj.Device[Guage.StateVarName] != null)
            {
                Guage.ModuleError = commonObj.Device[Guage.StateVarName].ToString ()=="true";
            }
        } 

        private void SetChart()
        {
            //X轴采用时间戳
            this.chartActualTrend.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.TimeStamp;
            //X轴的时间格式
            this.chartActualTrend.TimeStampFormat = "HH:mm:ss";
            //显示图例
            this.chartActualTrend.LegendVisible=true;
            //设置显示的数据点
            this.chartActualTrend.DisplayPoints = 4000;
            //Y轴范围
            this.chartActualTrend.AxisY.Minimum = 0.0f;
            this.chartActualTrend.AxisY.Maximum = 100.0f;
            //Y轴固定范围
            this.chartActualTrend.AxisY.AutoScale = false;
            //清空曲线
            this.chartActualTrend.Series.Clear();
            //设置曲线的数量
            this.chartActualTrend.SeriesCount = 12;
            //设置曲线
            for(int i =0;i<12;i++)
            {
                //设置曲线的名称
                this.chartActualTrend.Series[i].Name = i % 2 == 0 ? $"{i / 2 + 1}#站点温度" : $"{i / 2 + 1}#站点湿度";
                //设置曲线不可见
                this.chartActualTrend.Series[i].Visible = false;
                //设置曲线的粗细
                this.chartActualTrend.Series[i].Width  = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle;
                //设置曲线的Y轴
                this.chartActualTrend.Series[i].YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            }
            this.chkTemp1.Checked=true;
            this.chkHumi1.Checked = true;



        }
    /// <summary>
    /// 获取当前时间的字符串
    /// </summary>
    private string CurrentTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }
        /// <summary>
        /// 实现日志信息的方法原型，跨线程访问
        /// </summary>
        /// <param name="level"></param>
        /// <param name="Info"></param>
        public void Addlog(int level, string Info)
        {
            if (level > 2)
            {
                level = 2;
            }
            if (level < 0)
            {
                level = 0;
            }
            if (this.lsvInfo.InvokeRequired)
            {
                this.lsvInfo.Invoke(new Action<int, string>(Addlog), level, Info);
            }
            else
            {
                ListViewItem item = new ListViewItem(CurrentTime, level);
                item.SubItems.Add(Info);
                this.lsvInfo.Items.Add(item);
                //由于数据是向下插入，下面语句保证每次新的数据可见。
                this.lsvInfo.Items[this.lsvInfo.Items.Count - 1].EnsureVisible();

            }
        }

        private void chk_Common_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBoxExt checkBox)
            {
                if(checkBox.Tag != null && checkBox.Tag.ToString().Length>0)
                {
                    int index = Convert.ToInt32(checkBox.Tag.ToString());
                    this.chartActualTrend.Series[index].Visible = checkBox.Checked;
                }
            }
        }
    }
}
