using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models
{
    /// <summary>
    /// 所有的窗体枚举，小于"临界窗体"的窗体不关闭。
    /// </summary>
    public enum FormNames
    {
        集中监控,
        临界窗体,
        参数设置,
        配方管理,
        报警追溯,
        历史趋势,
        用户管理,
    }
}
