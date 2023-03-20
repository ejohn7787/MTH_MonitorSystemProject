using MTH_Models.models.System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.DAL
{
    /// <summary>
    /// SysLog表的数据访问
    /// </summary>
    public class SysLogService
    {
        /// <summary>
        /// 插入报警日志
        /// </summary>
        /// <param name="sysLog"></param>
        /// <returns></returns>
        public int AddSysLog(SysLog sysLog)
        {
            string sql = "Insert into SysLog(InsertTime ,Note,AlarmType,Operator,VarName)";
            sql += "values(@InsertTime ,@Note,@AlarmType,@Operator,@VarName)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@InsertTime",sysLog.InsertTime),
                 new SqlParameter("@Note",sysLog.Note),
                  new SqlParameter("@AlarmType",sysLog.AlarmType),
                   new SqlParameter("@Operator",sysLog.Operator),
                    new SqlParameter("@VarName",sysLog.VarName)
            };
            return SQLHelper .ExecuteNonQuery(sql, sqlParameters);
        }
        /// <summary>
        /// 根据时间查询指定报警类型的内容
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="alarmType"></param>
        /// <returns></returns>
        public DataTable QuerySysLogByCondition(string start,string end,string alarmType)
        {
            string sql = "Select InsertTime ,Note,AlarmType,Operator,VarName ";
            sql += "from SysLog ";
            sql += "where 1=1 ";
            sql += "and InsertTime between @Start and @End ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@Start",start),
                new SqlParameter("@End",end)
            };
            
            //如果有报警类型，查询该报警类型，如果没有则查询全部
            if (alarmType.Length > 0)
            {
                sql += "and AlarmType = @AlarmType ";
                sqlParameters.Add(new SqlParameter("@alarmType", alarmType));
            }
            try
            {
                DataSet dataSet = SQLHelper.GetDataSet(sql, sqlParameters.ToArray());
                if (dataSet.Tables.Count > 0)
                {
                    return dataSet.Tables[0];
                }
                else
                {
                    return null;
                }
            }
            catch(Exception)
            {
                return null;
            }
           
        }
    }
}
