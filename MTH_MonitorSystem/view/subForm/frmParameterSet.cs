using MTH_Models.device;
using MTH_MonitorSystem.common;
using MTH_MonitorSystem.view.popForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.MTHHelper;
using zj.UserDefinedControl;

namespace MTH_MonitorSystem
{
    public partial class frmParameterSet : Form
    {

        #region 字段
        private Timer updateTimer = new Timer();
        /// <summary>
        /// INI文件的保存路径，初始化
        /// </summary>
        private string devPath = string.Empty;
        #endregion
        #region 构造函数
        public frmParameterSet(string devPath)
        {
            InitializeComponent();
            this.devPath = devPath;

            iniParam();
            updateTimer.Interval = 500;
            updateTimer.Tick += UpdateTimer_Tick;
          
            
            updateTimer.Start();
            this.FormClosing += (sender, e) =>
            {
                updateTimer.Stop();

            };
            // 另一种稍微繁琐的方法
            //this.FormClosing += new FormClosingEventHandler((sender, e) =>
            //{


            //});

        }


        #endregion
        #region 事件
        /// <summary>
        /// 一秒定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            GetLimitParam();
        }
        private void btnGroupConfig_Click(object sender, EventArgs e)
        {
            new FrmGroupConfig().ShowDialog();
        }

        private void btnVarConfig_Click(object sender, EventArgs e)
        {
            new FrmVariableConfig().ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ///写入INI文件的各个参数
            bool result = IniConfigHelper.WriteIniData("设备参数", "IP地址", this.txtIP.Text.Trim(), devPath);
            result &= IniConfigHelper.WriteIniData("设备参数", "端口号", this.txtPort.Text.Trim(), devPath);
            if (result)//如果最终写入成功
            {
                ///修改设备类中的IP地址和端口号
                commonObj.Device.IPAddress = this.txtIP.Text.Trim();
                commonObj.Device.Port = Convert.ToInt32(this.txtPort.Text.Trim());

                DialogResult dialogResult = new FrmMsgboxWithAck("通信参数设置成功！是否立即重连？", "通信设置").ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    commonObj.Device.IsConnected = false;  //激活重连
                }


            }
            else
            {
                new FrmMsgboxWithoutAck("通信参数设置失败！", "通信设置").Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtIP.Text = commonObj.Device.IPAddress;
            this.txtPort.Text = commonObj.Device.Port.ToString();
        }

        /// <summary>
        /// 双击textset控件输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Common_ControlDoubleClick(object sender, EventArgs e)
        {
            if(sender is TextSet textSet)
            {
                if(textSet.BindVarName!=null && textSet.BindVarName.Length>0)
                {
                    string titleName = textSet.TitleName;
                    string bindVarName  = textSet.BindVarName;
                    string currentVal = textSet.CurrentValue;
                    FrmModify frmModify = new FrmModify(titleName, bindVarName, currentVal);
                    frmModify.ShowDialog();
                }
            }
        }
        /// <summary>
        /// 多选框点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Common_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxExt chkBox)
            {
                if (chkBox.Tag != null && chkBox.Tag.ToString().Length > 0)
                {
                    bool result = commonObj.CommonWrite(chkBox.Tag.ToString(), chkBox.Checked ? "1" : "0");
                    if(!result)
                    {
                        chkBox.CheckedChanged -=Common_CheckedChanged;   //先取消绑定事件
                        chkBox.Checked = !chkBox.Checked;
                        chkBox.CheckedChanged += Common_CheckedChanged;

                    }
                }
            }
        }
        #endregion
        #region 通用方法

        /// <summary>
        /// 统一的初始化界面控件的参数值
        /// </summary>
        private void iniParam()
        {
            this.txtIP.Text = commonObj.Device.IPAddress;
            this.txtPort.Text = commonObj.Device.Port.ToString();
            GetLimitParam();
            GetAlarmParam();
            CommonBindEvent();  //绑定控件
        }
        /// <summary>
        /// 更新限值的参数
        /// </summary>
        private void GetLimitParam()
        {
            if (commonObj.Device.IsConnected)
            {
                ///遍历每个TextSet控件
                foreach (TextSet textSet in pnlMain.Controls.OfType<TextSet>())
                {
                    //更新当前值
                    if (textSet.BindVarName != null && textSet.BindVarName.ToString().Length > 0)
                    {
                        textSet.CurrentValue = commonObj.Device[textSet.BindVarName.ToString()].ToString();

                    }
                    //更新是否报警
                    if (textSet.AlarmVarName != null && textSet.AlarmVarName.ToString().Length > 0)
                    {
                        
                        textSet.IsAlarm = commonObj.Device[textSet.AlarmVarName.ToString()].ToString().ToLower() == "true";
                    }
                }
            }
            
        }
        /// <summary>
        /// 获取多选框的状态
        /// </summary>
        private void GetAlarmParam()
        {
            if (commonObj.Device.IsConnected)
            {
                ///遍历每个TextSet控件
                foreach (CheckBoxExt chkBox in pnlMain.Controls.OfType<CheckBoxExt>())
                {
                    //更新当前值
                    if (chkBox.Tag != null && chkBox.Tag.ToString ().Length > 0)
                    {
                        chkBox.Checked  = commonObj.Device[chkBox.Tag.ToString()].ToString()=="1";

                    }
                  
                }
            }
        }
        /// <summary>
        /// 批量的控件绑定公共事件
        /// </summary>
        private void CommonBindEvent()
        {
            foreach(var item in pnlMain.Controls.OfType<TextSet>())  //遍历每个TextSet控件
            {
                if(item.BindVarName != null && item.BindVarName.ToString().Length > 0)
                {
                    item.ControlDoubleClick += Common_ControlDoubleClick;
                }
                
            }
            foreach (var item in pnlMain.Controls.OfType<CheckBoxExt>())  //遍历每个TextSet控件
            {
                if (item.Tag != null && item.Tag.ToString().Length > 0)
                {
                    item.CheckedChanged += Common_CheckedChanged;
                }

            }
        }
        #endregion

       
    }
}
