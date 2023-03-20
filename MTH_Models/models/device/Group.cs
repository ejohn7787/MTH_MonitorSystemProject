using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.device
{
    /// <summary>
    /// 设备的通信组
    /// </summary>
    public  class Group
    {
        /// <summary>
        /// 通信组的名称
        /// </summary>
        public string GroupName  { get; set; }
        /// <summary>
        ///  读取的起始地址
        /// </summary>
        public ushort Start { get; set; }
        /// <summary>
        /// 读取的长度
        /// </summary>
        public ushort Length { get; set; }
        /// <summary>
        /// 存储区
        /// </summary>
        public string StoreArea { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 变量的集合
        /// </summary>
        [ExcelIgnore]
        public List<Variable> VarList { get; set; }
    }
}
