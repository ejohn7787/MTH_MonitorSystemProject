using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.device
{
    public class Variable
    {
        /// <summary>
        /// 变量名称
        /// </summary>
        public string VarName { get; set; }
        /// <summary>
        /// 起始地址
        /// </summary>
        public ushort  Start { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 位偏移或长度
        /// </summary>
        public int OffsetOrLength { get; set; }

        /// <summary>
        /// 所属的组名
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 上升沿报警
        /// </summary>
        public bool  PosAlarm { get; set; }
        /// <summary>
        /// 下降沿报警
        /// </summary>
        public bool NegAlarm { get; set; }
        /// <summary>
        /// 数据调整比例值
        /// </summary>
        public float Scale { get; set; } = 1.0f;
        /// <summary>
        /// 数据调整偏移值
        /// </summary>
        public float Offset { get; set; } = 0.0f;
        /// <summary>
        /// 变量的当前值
        /// </summary>
        [ExcelIgnore]
        public object varValue { get; set; }
        /// <summary>
        /// 上升沿检测缓存值
        /// </summary>
        [ExcelIgnore]
        public bool PosCacheValue { get; set; } = false;
        /// <summary>
        /// 下降沿检测缓存值
        /// </summary>
        [ExcelIgnore]
        public bool NegCacheValue { get; set; } = true;


    }
}
