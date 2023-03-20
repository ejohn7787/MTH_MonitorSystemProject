using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.models.System
{
    /// <summary>
    /// 存入数据库的日志模型
    /// </summary>
    public class SysLog
    {
        /// <summary>
        /// 插入时间
        /// </summary>
        public string InsertTime { get; set; }
        /// <summary>
        /// 日志信息
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 报警类型
        /// </summary>
        public string  AlarmType { get; set; }
        /// <summary>
        /// 操作人员
        /// </summary>
        public string  Operator { get; set; }
        /// <summary>
        /// 变量名称
        /// </summary>
        public string VarName { get; set; }
    }
}
