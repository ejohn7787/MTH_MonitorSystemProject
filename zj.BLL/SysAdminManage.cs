using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;                      //引用数据访问层
using MTH_Models.models.System;  //引用模型层
using System.Data;

namespace zj.BLL
{
    public class SysAdminManage
    {

        /// <summary>
        /// SysAdminManage 业务逻辑层
        /// </summary>
        private SysAdminService sysAdminService = new SysAdminService();
        
        /// <summary>
        ///  用户登录验证的方法
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin sysAdmin)
        {
            return sysAdminService.AdiminLogin(sysAdmin);
        }

        public bool AddSysAdmin(SysAdmin sysAdmin)
        {
            return sysAdminService .AddSysAdmin(sysAdmin) == 1;
        }

        public bool DelSysAdmin(int loginId)
        {
            return sysAdminService.DelSysAdmin(loginId)==1;
        }
        public bool ModifySysAdmin(SysAdmin sysAdmin)
        {
            return sysAdminService.ModifySysAdmin(sysAdmin) == 1;
        }
        public List<SysAdmin> QuerySysAdmins()
        {
            return sysAdminService.QuerySysAdmins();
        }
    }
}
