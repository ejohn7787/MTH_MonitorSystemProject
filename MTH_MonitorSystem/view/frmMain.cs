using MiniExcelLibs;
using MTH_Models;
using MTH_Models.device;
using MTH_MonitorSystem.common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using zj.BLL;
using zj.MTHHelper;
using zj.UserDefinedControl;
using MTH_Models.models.System;
using MTH_Models.models.device;

namespace MTH_MonitorSystem
{
    public partial class FrmMain : Form
    {
        #region 字段
        /// <summary>
        /// 设备信息保存路径
        /// </summary>
        private string devPath = Application.StartupPath + "\\Config\\Device.ini";
        private string groupPath = Application.StartupPath + "\\Config\\Group.xlsx";
        private string variablePath = Application.StartupPath + "\\Config\\Variable.xlsx";         //变量的表
        private CancellationTokenSource cts;                        //取消线程源
        //滚动报警的显示集合，在集合数量发生改变时发生Changed事件
        private ObservableCollection <string> actualAlarmList = new ObservableCollection<string>();
        /// <summary>
        /// 业务逻辑层 日志表，当有报警时使用添加报警信息到sysLog表
        /// </summary>
        private SysLogManage sysLogManage = new SysLogManage();
        /// <summary>
        /// 业务逻辑层 添加实时数据到ActualData表
        /// </summary>
        private ActualDataManage actualDataManage = new ActualDataManage();
        /// <summary>
        /// 添加实时数据用的系统定时器对象，多线程定时器。
        /// </summary>
        private System.Timers.Timer StoreTimer= new System.Timers.Timer();

        private string[] weeks = { "星期日","星期一", "星期二", "星期三", "星期四", "星期五", "星期六"  };
        //当前选择的页面索引
        private int CurrentPageIndex = 0;
        private List<NaviButton> naviButtons = new List<NaviButton>();
        #endregion
        #region 属性


        /// <summary>
        /// 获取中文星期字符串
        /// </summary>
        private string Weeks
        {
            get { return weeks[Convert.ToInt32(DateTime.Now.DayOfWeek)]; }
        }
        /// <summary>
        /// 获取当前时间属性，设置这个属性是为了使程序各处获得的时间格式相同
        /// </summary>
        public String CurrentTime
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        #endregion
        #region 构造函数
        public FrmMain()
        {

            InitializeComponent();
            naviButtons.Add(this.btnMonitor);
            naviButtons.Add(this.naviButton2);
            naviButtons.Add(this.naviButton3);
            naviButtons.Add(this.naviButton4);
            naviButtons.Add(this.naviButton5);
            naviButtons.Add(this.naviButton6);


            StoreTimer.Interval = 1000;  //一秒定时加入实时数据库
            StoreTimer.AutoReset = true;  //不断重复
            StoreTimer.Elapsed += StoreTimer_Elapsed;   //绑定定时器触发事件
            StoreTimer.Start();            //开启定时器
            this.FormClosing += FrmMain_FormClosing;         //绑定关闭窗口的事件

        }


        #endregion
        #region 事件

        /// <summary>
        /// 定时存储当前数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //跨线程更新界面
            this.Invoke(new Action(() => {
                //更新当前时间
                this.lblCurrentTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("HH:mm:ss") + " "+  Weeks ;
                //更新当前通信状态的LED
                this.led_Status.Value = commonObj.Device.IsConnected;
            }));
           
            

            ///可以用添加特性的方法，简化程序
            if(commonObj.Device.IsConnected)      //通信正常的情况下，都有值的情况下
            {
                bool result = commonObj.Device["模块1温度"]!=null;
                result &= commonObj.Device["模块1湿度"] != null;
                result &= commonObj.Device["模块2温度"] != null;
                result &= commonObj.Device["模块2湿度"] != null;
                result &= commonObj.Device["模块3温度"] != null;
                result &= commonObj.Device["模块3湿度"] != null;
                result &= commonObj.Device["模块4温度"] != null;
                result &= commonObj.Device["模块4湿度"] != null;
                result &= commonObj.Device["模块5温度"] != null;
                result &= commonObj.Device["模块5湿度"] != null;
                result &= commonObj.Device["模块6温度"] != null;
                result &= commonObj.Device["模块6湿度"] != null;
                if(result)
                {
                    actualDataManage.AddActualData(new ActualData()
                    {
                        InsertTime = CurrentTime,
                        Station1Temp = commonObj.Device["模块1温度"].ToString (),
                        Station1Humidity = commonObj.Device["模块1湿度"].ToString (),
                        Station2Temp = commonObj.Device["模块2温度"].ToString(),
                        Station2Humidity = commonObj.Device["模块2湿度"].ToString(),
                        Station3Temp = commonObj.Device["模块3温度"].ToString(),
                        Station3Humidity = commonObj.Device["模块3湿度"].ToString(),
                        Station4Temp = commonObj.Device["模块4温度"].ToString(),
                        Station4Humidity = commonObj.Device["模块4湿度"].ToString(),
                        Station5Temp = commonObj.Device["模块5温度"].ToString(),
                        Station5Humidity = commonObj.Device["模块5湿度"].ToString(),
                        Station6Temp = commonObj.Device["模块6温度"].ToString(),
                        Station6Humidity = commonObj.Device["模块6湿度"].ToString()

                    });

                    
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {

            //更新用户名称到界面
            this.lblUser.Text = commonObj.CurrentAdmin.LoginName;
            //绑定当前报警列表改变事件
            actualAlarmList.CollectionChanged += ActualAlarmList_CollectionChanged;
            //打开默认的Monitor窗体，才能将日志的代理和方法绑定
            CommonNaviButton_Click(this.btnMonitor, null);

            commonObj.Device = LoadDevice(devPath, groupPath, variablePath);
            if (commonObj.Device != null)
            {
                commonObj.Addlog(0, "设备信息加载成功");
                cts = new CancellationTokenSource();
                commonObj.Device.AlarmTrigEvent += Device_AlarmTrigEvent;  //绑定报警事件
               
                Task.Run(new Action(() =>
                {
                    DeviceCommunication(commonObj.Device);

                }), cts.Token);

            }
           
        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StoreTimer.Stop();
            commonObj.modbus?.DisConnect();
            cts?.Cancel();
        }


        /// <summary>
        /// 设备的报警事件逻辑
        /// </summary>
        /// <param name="ackType">报警的触发逻辑： true:触发报警 false:取消报警</param>
        /// <param name="variable"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Device_AlarmTrigEvent(bool ackType, Variable variable)
        {
            if(ackType)
            {

                commonObj.Addlog(1, variable.Remark+"触发");
                //把报警存储到数据库
                sysLogManage.AddSysLog(new SysLog()
                {
                    InsertTime = CurrentTime,
                    Note= variable.Remark,
                    AlarmType = "触发",
                    Operator = commonObj.CurrentAdmin.LoginName,
                    VarName = variable.VarName


                });
                if(!actualAlarmList.Contains(variable.Remark))
                {
                    actualAlarmList.Add(variable.Remark);
                }
                
            }
            else 
            {
                commonObj.Addlog(1, variable.Remark + "消除");
                //把报警存储到数据库
                sysLogManage.AddSysLog(new SysLog()
                {
                    InsertTime = CurrentTime,
                    Note = variable.Remark,
                    AlarmType = "消除",
                    Operator = commonObj.CurrentAdmin.LoginName,
                    VarName = variable.VarName


                });

                if (actualAlarmList.Contains(variable.Remark))
                {
                    actualAlarmList.Remove(variable.Remark);
                }
            }
        }



        /// <summary>
        /// 按下导航按钮后的通用事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommonNaviButton_Click(object sender, EventArgs e)
        {

            if (sender is NaviButton)
            {
                NaviButton navi = (NaviButton)sender;

                if (Enum.IsDefined(typeof(FormNames), navi.Title))  //判断按下的按钮的Title属性是否位于指定的枚举中
                {
                    //拿到窗体枚举值，窗体切换
                    FormNames formNames = (FormNames)Enum.Parse(typeof(FormNames), navi.Title, true);
                    //用户权限处理
                    switch (formNames)
                    {
                        case FormNames.参数设置:
                            if(!commonObj.CurrentAdmin.ParamSet)
                            {
                                new FrmMsgboxWithoutAck("用户权限不足，请检查！","权限不足").ShowDialog ();
                                return;
                            }
                            break;
                        case FormNames.配方管理:
                            if (!commonObj.CurrentAdmin.Recipe)
                            {
                                new FrmMsgboxWithoutAck("用户权限不足，请检查！", "权限不足").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.报警追溯:
                            if (!commonObj.CurrentAdmin.HistoryLog)
                            {
                                new FrmMsgboxWithoutAck("用户权限不足，请检查！", "权限不足").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.历史趋势:
                            if (!commonObj.CurrentAdmin.HistoryTrend)
                            {
                                new FrmMsgboxWithoutAck("用户权限不足，请检查！", "权限不足").ShowDialog();
                                return;
                            }
                            break;
                        case FormNames.用户管理:
                            if (!commonObj.CurrentAdmin.UserManage)
                            {
                                new FrmMsgboxWithoutAck("用户权限不足，请检查！", "权限不足").ShowDialog();
                                return;
                            }
                            break;
                        default:
                            break;
                    }
                  
                    //打开窗体
                    OpenForm(this.pnlMain, formNames);
                    //修改标题
                    SetTitle(this.lblTitle, formNames);
                    //修改导航按钮
                    SetNaviButtonSelected(this.TopPanel, navi);

                }

            }
        }

        /// <summary>
        /// 退出整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new FrmMsgboxWithAck("是否退出程序？","退出程序").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
        /// <summary>
        /// 滚动报警的显示集合，在集合数量发生改变时发生的事件业务逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ActualAlarmList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                switch (actualAlarmList.Count)
                {
                    case 0:
                        this.sclAlarmText.Text = "当前系统无报警!";
                        break;
                    default:
                        this.sclAlarmText.Text = string.Join(" ",actualAlarmList);
                        break;
                }
            }));
            

        }
        #endregion
        #region 通用的方法
        /// <summary>
        /// 嵌入窗体到容器控件
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="formNames"></param>
        private void OpenForm(Panel panel, FormNames formNames)
        {
            ///首先判断窗体是否已打开
            int total = panel.Controls.Count;
            int closeCount = 0;
            bool isFind = false;
            //遍历窗体容器中的控件
            for (int i = 0; i < total; i++)
            {

                Control control = panel.Controls[i - closeCount];
                //如果控件是窗体
                if (control is Form)
                {
                    Form form = (Form)control;
                    ///判断当前的窗体是否是需要操作的窗体，
                    ///如果是： 移动到最上方。
                    ///如果不是：检查窗体位于枚举的位置是否大于临界窗体。如果大于 关闭，小于不做处理。
                    ///该功能保证只有一个窗体被实例化。   其实窗体可以采用单例模式。
                    if (form.Text == formNames.ToString())
                    {
                        form.BringToFront();
                        isFind = true;
                        break;
                    }
                    else if ((FormNames)Enum.Parse(typeof(FormNames), form.Text, true) >= FormNames.临界窗体)  //如果窗体不需要常驻内存
                    {
                        form.Close();             //关闭窗体
                        closeCount++;
                    }
                }
            }

            if (isFind == false)  //遍历完毕，如果没有找到，打开要打开的窗体
            {
                Form form = null;
                switch (formNames)
                {
                    case FormNames.集中监控:
                        form = new frmMonitor();
                        commonObj.Addlog = ((frmMonitor)form).Addlog;  //绑定方法到代理
                        break;

                    case FormNames.参数设置:
                        form = new frmParameterSet(devPath);  //打开参数设置窗体，并把参数保存的文件的路径一并传递
                        break;
                    case FormNames.配方管理:
                        form = new frmRecipe(devPath);         //打开配方设置窗体，并把当前参数保存的文件的路径一并传递
                        break;
                    case FormNames.报警追溯:
                        form = new frmAlarm();
                        break;
                    case FormNames.历史趋势:
                        form = new frmHistory();
                        break;
                    case FormNames.用户管理:
                        form = new frmUserManager();
                        break;
                    default:
                        break;
                }
                //如果需要打开的窗体正常实例化，对象非空。（防止错误参数造成的误操作）
                if (form != null)
                {
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    form.Parent = pnlMain;        //设置窗体显示在容器内
                    form.BringToFront();
                    form.Show();
                }
            }
        }
        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="label"></param>
        /// <param name="formNames"></param>
        private void SetTitle(Label label, FormNames formNames)
        {
            label.Text = formNames.ToString();
        }
        /// <summary>
        /// 设置导航按钮选中
        /// </summary>
        /// <param name="topPanel"></param>
        /// <param name="naviButton"></param>
        private void SetNaviButtonSelected(Panel topPanel, NaviButton naviButton)
        {
            ///先复位所有导航按钮
            foreach (var item in topPanel.Controls.OfType<NaviButton>())
            {
                item.IsSelected = false;

            }
            naviButton.IsSelected = true;
        }
        /// <summary>
        /// 减少闪烁
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;

            }
        }
        /// <summary>
        /// 获取INI配置文件的值，加载设备信息，并返回
        /// </summary>
        /// <param name="path">设备的INI文件路径</param>
        /// <param name="groupPath">设备里的通信组的文件路径</param>
        /// <param name="variablePath">设备里的变量组的文件路径</param>
        /// <returns>返回设备对象</returns>
        private Device LoadDevice(string path, string groupPath, string variablePath)
        {
            //判断设备文件是否存在
            if (!File.Exists(path))
            {
                commonObj.Addlog(1, "设备配置文件不存在");
                return null;
            }
            List<Group> groups = LoadGroup(groupPath, variablePath); //加载通信组，（包括通信组中的变量组）
            //如果设备里的通信组存在，把
            if (groups != null && groups.Count > 0)
            {
                try
                {
                    return new Device()
                    {
                        IPAddress = IniConfigHelper.ReadIniData("设备参数", "IP地址", "127.0.0.1", path),
                        Port = Convert.ToInt32(IniConfigHelper.ReadIniData("设备参数", "端口号", "502", path)),
                        CurrentRecipe = IniConfigHelper.ReadIniData("配方参数", "当前配方", "", devPath),
                        GroupList = groups
                    };
                }
                catch (Exception ex)
                {
                    //日志写入
                    commonObj.Addlog(1, "设备信息加载失败" + ex.Message);
                    return null;

                }
            }
            else
            {
                return null;
            }


        }
        /// <summary>
        /// 加载设备,通信组信息，完善Device类
        /// </summary>
        /// <param name="groupPath">通信组文件存储地址</param>
        /// <param name="variablePath">变量组文件存储地址</param>
        /// <returns></returns>
        private List<Group> LoadGroup(string groupPath, string variablePath)
        {
            //判断文件是否存在
            if (!File.Exists(groupPath))
            {
                commonObj.Addlog(1, "通信组文件不存在");
                return null;
            }
            if (!File.Exists(variablePath))
            {
                commonObj.Addlog(1, "变量文件不存在");
                return null;
            }

            //解析通信组
            List<Group> groups = null;
            try
            {
                groups = MiniExcel.Query<Group>(groupPath).ToList();
            }
            catch (Exception ex)
            {
                commonObj.Addlog(1, "通信组内容异常" + ex.Message);
                return null;
            }
            //解析变量,保存早对应的通信组
            List<Variable> variables = null;
            try
            {
                variables = MiniExcel.Query<Variable>(variablePath).ToList();
            }
            catch (Exception ex)
            {
                commonObj.Addlog(1, "变量内容异常" + ex.Message);
                return null;
            }
            if (groups != null && variables != null)       //筛选
            {
                foreach (Group group in groups)
                {
                    group.VarList = variables.FindAll((s) => s.GroupName == group.GroupName);
                }
                return groups;
            }
            return null;

        }
        /// <summary>
        /// 多线程设备通信，读取参数的方法方法
        /// </summary>
        /// <param name="device"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void DeviceCommunication(Device device)
        {
            while (!cts.IsCancellationRequested)  //循环直到收到取消信息
            {
                //断线重连
                if (device.IsConnected)
                {
                    //通信读取
                    //遍历设备的每个通信组
                    foreach(Group group in device.GroupList)
                    {
                        byte[] data = null;
                        //应该返回的字节长度
                        int reqLength = 0;
                        if (group.StoreArea == "输入线圈" || group.StoreArea == "输出线圈")
                        {
                            
                            
                            switch (group.StoreArea)
                            {
                                case "输入线圈":
                                    data = commonObj.modbus.ReadInputCoils(group.Start, group.Length);
                                    reqLength = ShortLib.GetByteLengthFromBoolLength(group.Length);
                                    break;
                                case "输出线圈":
                                    data = commonObj.modbus.ReadOutputCoils(group.Start, group.Length);
                                    reqLength = ShortLib.GetByteLengthFromBoolLength(group.Length);
                                    break ;
                                
                                default:
                                    break;
                            }

                            ///这部分其实可以用委托上下合并成一次处理
                            if(data != null && data.Length == reqLength  )
                            {
                                //变量解析,遍历通信组中的每个变量
                                foreach (Variable variable in group.VarList)
                                {
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), variable.DataType,true);
                                    //获取需要的变量在收到数据中的实际起始地址
                                    ///由此可知变量的起始地址和通信组的起始地址其实
                                    ///都是相对Modbus本身的地址。两者其实是一个值。
                                    int start = variable.Start-group.Start;         
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            variable.varValue = BitLib.GetBitFromByteArray(data, start, variable.OffsetOrLength);
                                            break;
                                        
                                        default:
                                            break;
                                    }
                                    //处理 直接更新当前值CurrentValue缓存
                                    device.UpdateVariable(variable);
                                }
                                
                            }
                            else
                            {
                                device.IsConnected=false;
                                break;
                            }


                        }
                        else
                        {
                            switch (group.StoreArea )
                            {
                                case "输入寄存器":
                                    data = commonObj.modbus.ReadInputRegisters(group.Start,group.Length);  //读取modbus
                                    reqLength = group.Length*2;
                                    break;
                                case "输出寄存器":
                                    data = commonObj.modbus.ReadOutputRegisters(group.Start, group.Length);
                                    reqLength = group.Length * 2;
                                    break ;

                                default:
                                    break;
                            }
                            if (data != null && data.Length == reqLength)
                            {
                                //变量解析
                                foreach (Variable variable in group.VarList)
                                {
                                    DataType dataType = (DataType)Enum.Parse(typeof(DataType), variable.DataType, true);
                                    //获取需要的变量在收到数据中的实际起始地址
                                    ///modbus寄存器为16位
                                    int start = (variable.Start - group.Start)*2;
                                    switch (dataType)
                                    {
                                        case DataType.Bool:
                                            variable.varValue = BitLib.GetBitFrom2BytesArray(data,start,variable.OffsetOrLength,commonObj.dataFormat ==DataFormat.BADC || commonObj.dataFormat == DataFormat.DCBA);
                                            break;
                                        case DataType.Byte:
                                            variable.varValue = ByteLib.GetByteFromByteArray(data, commonObj.dataFormat == DataFormat.BADC || commonObj.dataFormat == DataFormat.DCBA ? start : start + 1);
                                            break;
                                        case DataType.Short:
                                            variable.varValue = ShortLib.GetShortFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.UShort:
                                            variable.varValue = UShortLib.GetUShortFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.Int:
                                            variable.varValue = IntLib.GetIntFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.UInt:
                                            variable.varValue = UIntLib.GetUIntFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.Float:
                                            variable.varValue = FloatLib.GetFloatFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.Double:
                                            variable.varValue = DoubleLib.GetDoubleFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.Long:
                                            variable.varValue = LongLib.GetLongFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.ULong:
                                            variable.varValue = ULongLib.GetULongFromByteArray(data, start, commonObj.dataFormat);
                                            break;
                                        case DataType.String:
                                            variable.varValue = StringLib.GetStringFromByteArrayByEncoding(data, start,variable.OffsetOrLength,Encoding.ASCII);
                                            break;
                                        case DataType.ByteArray:
                                            variable.varValue = ByteArrayLib.GetByteArrayFromByteArray(data, start, variable.OffsetOrLength);
                                            break;
                                        case DataType.HexString:
                                            variable.varValue = StringLib.GetHexStringFromByteArray(data, start, variable.OffsetOrLength);
                                            break;
                                        default:
                                            break;
                                    }
                                    //处理 
                                    //先做线性转换 再更新
                                    variable.varValue =MigrationLib.GetMigrationValue(variable .varValue ,variable .Scale.ToString(),variable .Offset.ToString ()).Content;
                                    device.UpdateVariable(variable);
                                }
                                //处理
                            }
                            else
                            {
                                device.IsConnected = false;
                                break;
                            }

                        }

                    }

                }
                else
                {
                    //非首次连接延时
                    if (device.IsReconnect)
                    {
                        commonObj.modbus?.DisConnect();
                        Thread.Sleep(device.ReConnectTime);
                    }

                    //通信连接
                    commonObj.modbus = new ModbusTCP();
                    device.IsConnected = commonObj.modbus.Connect(device.IPAddress, device.Port);
                    //如果连接成功，非首次连接标志置位

                    if (device.IsReconnect == true)
                    {
                        commonObj.Addlog(device.IsConnected ? 0 : 1, device.IsConnected ? "设备重连成功！" : "设备重连失败！");
                    }
                    else
                    {
                        commonObj.Addlog(device.IsConnected ? 0 : 1, device.IsConnected ? "设备初次连接成功！" : "设备初次连接失败！");
                        device.IsReconnect = true;
                    }


                }
            }
        }


        #endregion

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentPageIndex++;
            if(CurrentPageIndex < naviButtons.Count)
            {
                CommonNaviButton_Click(naviButtons[CurrentPageIndex],null);
            }
            else
            {
                CurrentPageIndex--;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentPageIndex--;
            if (CurrentPageIndex >= 0)
            {
                CommonNaviButton_Click(naviButtons[CurrentPageIndex], null);
            }
            else
            {
                CurrentPageIndex++;
            }
        }
    }
}
