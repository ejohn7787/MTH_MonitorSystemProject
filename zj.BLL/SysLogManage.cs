using MTH_Models.models.System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;

namespace zj.BLL
{
    /// <summary>
    /// SysLog表的业务逻辑层,业务逻辑层如果没有复杂的业务的化，只是返回值的传递
    /// </summary>
    public  class SysLogManage
    {
        private SysLogService sysLogService = new SysLogService();
        public bool AddSysLog(SysLog sysLog)
        {
            return sysLogService.AddSysLog(sysLog) == 1;
        }
        public DataTable QuerySysLogByCondition(string start, string end, string alarmType)
        {
            return sysLogService.QuerySysLogByCondition(start, end, alarmType); 
        }
    }
}
