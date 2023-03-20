using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTH_Models.models.System;

namespace zj.DAL
{
    public class SysAdminService
    {
        /// <summary>
        ///  用户登录验证的方法
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public SysAdmin  AdiminLogin( SysAdmin sysAdmin) 
        {
            string sql = "Select LoginId,ParamSet,Recipe,HistoryLog,HistoryTrend,UserManage ";
            sql += "from SysAdmin ";
            sql += "where 1=1 ";
            sql += "and LoginName = @LoginName ";
            sql += "and LoginPwd = @LonginPwd ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LonginPwd",sysAdmin.LoginPwd)
            };
            DataSet dataSet = SQLHelper.GetDataSet(sql, sqlParameters);
            if(dataSet!=null && dataSet.Tables.Count> 0 && dataSet.Tables[0].Rows.Count ==1)
            {
                sysAdmin.LoginId =Convert.ToInt32( dataSet.Tables[0].Rows[0]["LoginId"]);
                sysAdmin.ParamSet =Convert.ToBoolean(dataSet.Tables[0].Rows[0]["ParamSet"]);
                sysAdmin.Recipe = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["Recipe"]);
                sysAdmin.HistoryLog = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["HistoryLog"]);
                sysAdmin.HistoryTrend = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["HistoryTrend"]);
                sysAdmin.UserManage = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["UserManage"]);
                return sysAdmin;
            }
            else { return null; }
        }
        public int AddSysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO SysAdmin(LoginName,LoginPwd,ParamSet,Recipe,HistoryLog,HistoryTrend,UserManage)");
            sql.Append(" VALUES(@LoginName,@LoginPwd,@ParamSet,@Recipe,@HistoryLog,@HistoryTrend,@UserManage)");
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@ParamSet",sysAdmin.ParamSet),
                new SqlParameter("@Recipe",sysAdmin.Recipe),
                new SqlParameter("@HistoryLog",sysAdmin.HistoryLog),
                new SqlParameter("@HistoryTrend",sysAdmin.HistoryTrend),
                new SqlParameter("@UserManage",sysAdmin.UserManage)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), sqlParameters);
        }
        public int DelSysAdmin(int loginId)
        {
            string sql = "DELETE FROM SysAdmin";
            sql += " WHERE 1=1";
            sql += " AND LoginId = @LoginId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@LoginId",loginId)
                
            };
            return SQLHelper.ExecuteNonQuery(sql, sqlParameters);
        }

        public int ModifySysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE SysAdmin");
            sql.Append(" SET ");
            sql.Append("LoginName=@LoginName,");
            sql.Append("LoginPwd=@LoginPwd,");
            sql.Append("ParamSet=@ParamSet,");
            sql.Append("Recipe=@Recipe,");
            sql.Append("HistoryLog=@HistoryLog,");
            sql.Append("HistoryTrend=@HistoryTrend,");
            sql.Append("UserManage=@UserManage ");
            sql.Append("WHERE 1=1 ");
            sql.Append("AND LoginId=@LoginId");
            SqlParameter[] sqlParameters =
           {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@ParamSet",sysAdmin.ParamSet),
                new SqlParameter("@Recipe",sysAdmin.Recipe),
                new SqlParameter("@HistoryLog",sysAdmin.HistoryLog),
                new SqlParameter("@HistoryTrend",sysAdmin.HistoryTrend),
                new SqlParameter("@UserManage",sysAdmin.UserManage),
                new SqlParameter("@LoginId",sysAdmin.LoginId)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), sqlParameters);
        }
        public List<SysAdmin> QuerySysAdmins()
        {
            string sql = "SELECT LoginId,LoginName,LoginPwd,ParamSet,Recipe,HistoryLog,HistoryTrend,UserManage ";
            sql += "FROM SysAdmin";

            SqlDataReader sqlDataReader = SQLHelper.ExecuteReader(sql);
            List<SysAdmin> sysAdmins = new List<SysAdmin>();
            while (sqlDataReader.Read())
            {
                sysAdmins.Add(new SysAdmin()
                {
                    LoginId =Convert.ToInt32( sqlDataReader["LoginId"]),
                    LoginName = sqlDataReader["LoginName"].ToString(),
                    LoginPwd = sqlDataReader["LoginPwd"].ToString(),
                    ParamSet = Convert.ToBoolean(sqlDataReader["ParamSet"]),
                    Recipe = Convert.ToBoolean(sqlDataReader["Recipe"]),
                    HistoryLog = Convert.ToBoolean(sqlDataReader["HistoryLog"]),
                    HistoryTrend = Convert.ToBoolean(sqlDataReader["HistoryTrend"]),
                    UserManage = Convert.ToBoolean(sqlDataReader["UserManage"]),
                });
            }
            return sysAdmins;

        }

    }
}
