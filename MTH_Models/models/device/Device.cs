using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.device
{
    /// <summary>
    /// 设备实体类
    /// </summary>
    public class Device
    {
        #region 索引器
        /// <summary>
        /// 索引器，获取 CurrentValue 键值集合元素中的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get
            {
                if(CurrentValue.ContainsKey(key))
                {
                    return CurrentValue[key];
                }
                else
                {
                    return null;
                }
            }
           
        }
        #endregion
        #region 字段
        /// <summary>
        /// 所有采集的当前值的键值对，配合索引器
        /// 键(key):为变量的名称（varName），
        /// 值(value):就是变量的值，
        /// 如果使用这个方法，要求不同组中也不可以有同名的变量。
        /// </summary>
        public Dictionary<string, object> CurrentValue = new Dictionary<string, object>();
        #endregion
        #region 属性
        /// <summary>
        /// 当前配方
        /// </summary>
        public string CurrentRecipe { get;set; }
        /// <summary>
        /// 通信状态的标志位
        /// </summary>
        public bool IsConnected { get; set; }
        #region 重连相关属性
        /// <summary>
        /// 是否重连标志
        /// </summary>
        public bool IsReconnect { get; set; } = false;
        /// <summary>
        /// 重连的延时时间单位毫秒
        /// </summary>
        public int ReConnectTime { get; set; } = 500;
        #endregion

        #region 连接的参数要素
        /// <summary>
        /// 设备的IP地址
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// 设备的端口号
        /// </summary>
        public int Port { get; set; }
        #endregion
       
        /// <summary>
        /// 设备相关的通信组的集合
        /// </summary>
        public List<Group> GroupList { get; set; }

        #endregion
        #region 方法
        /// <summary>
        /// 更新当前值键值对集合的值，
        /// 如果没有该键(key)就添加，如果键(key)已经存在就更新
        /// </summary>
        /// <param name="variable"></param>
        public void UpdateVariable(Variable variable)
        {
            //判断是否包含指定的键
            if (CurrentValue.ContainsKey(variable.VarName))
            {
                ///包含，修改值。
                CurrentValue[variable.VarName] = variable.varValue;

            }
            else
            {
                CurrentValue.Add(variable.VarName, variable.varValue);
            }
            //报警检测的代码
            CheckAlarm(variable);
        }
        /// <summary>
        ///  //报警检测的代码,触发报警事件AlarmTrigEvent
        /// </summary>
        /// <param name="variable"></param>
        private void CheckAlarm(Variable variable)
        {
            ///如果选择了上升沿报警
            if(variable.PosAlarm)
            {
                //当变量当前值是true。
                bool currentValue = variable.varValue.ToString().ToLower() == "true";
                if (variable.PosCacheValue == false && currentValue == true)
                {
                    //检测到了报警触发
                    AlarmTrigEvent?.Invoke(true, variable);
                }
                if (variable.PosCacheValue == true && currentValue == false)
                {
                    //检测到了报警消除
                    AlarmTrigEvent?.Invoke(false, variable);
                }

                variable.PosCacheValue = currentValue;
            }
            ///如果选择了下降沿报警
            if (variable.NegAlarm)
            {
                //当变量当前值是true。
                bool currentValue = variable.varValue.ToString().ToLower() == "true";
                if (variable.NegCacheValue == true && currentValue == false)
                {
                    //检测到了报警触发
                    AlarmTrigEvent?.Invoke(true, variable);
                }
                if (variable.PosCacheValue == false && currentValue == true)
                {
                    //检测到了报警消除
                    AlarmTrigEvent?.Invoke(false, variable);
                }

                variable.NegCacheValue = currentValue;
            }

        }
        #endregion
        #region 自定义事件
        /// <summary>
        /// 定义了一个报警触发和消除的事件，在CheckAlarm方法中被调用,
        /// 在FormMain窗体的加载事件中绑定业务逻辑
        /// </summary>
        public event Action<bool, Variable> AlarmTrigEvent;
        #endregion


    }
}
