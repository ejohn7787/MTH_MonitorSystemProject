using MTH_Models.models.device;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.DAL
{
    public  class ActualDataService
    {
        /// <summary>
        /// 数据库插入数据
        /// </summary>
        /// <param name="actualData"></param>
        /// <returns></returns>
        public int AddActualData(ActualData actualData)
        {
            //拼装SQL语句
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append("Insert into ActualData(");
            stringBuilder.Append("InsertTime,");
            stringBuilder.Append("Station1Temp,Station1Humidity,");
            stringBuilder.Append("Station2Temp,Station2Humidity,");
            stringBuilder.Append("Station3Temp,Station3Humidity,");
            stringBuilder.Append("Station4Temp,Station4Humidity,");
            stringBuilder.Append("Station5Temp,Station5Humidity,");
            stringBuilder.Append("Station6Temp,Station6Humidity) ");
            stringBuilder.Append("values(");
            stringBuilder.Append("@InsertTime,");
            stringBuilder.Append("@Station1Temp,@Station1Humidity,");
            stringBuilder.Append("@Station2Temp,@Station2Humidity,");
            stringBuilder.Append("@Station3Temp,@Station3Humidity,");
            stringBuilder.Append("@Station4Temp,@Station4Humidity,");
            stringBuilder.Append("@Station5Temp,@Station5Humidity,");
            stringBuilder.Append("@Station6Temp,@Station6Humidity) ");
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@InsertTime",actualData.InsertTime),
                new SqlParameter("@Station1Temp",actualData.Station1Temp),
                new SqlParameter("@Station1Humidity",actualData .Station1Humidity),
                new SqlParameter("@Station2Temp",actualData .Station2Temp),
                new SqlParameter("@Station2Humidity",actualData .Station2Humidity),
                new SqlParameter("@Station3Temp",actualData .Station3Temp),
                new SqlParameter("@Station3Humidity",actualData .Station3Humidity),
                new SqlParameter("@Station4Temp", actualData.Station4Temp),
                new SqlParameter("@Station4Humidity",actualData .Station4Humidity),
                new SqlParameter("@Station5Temp",actualData .Station5Temp),
                new SqlParameter("@Station5Humidity",actualData .Station5Humidity),
                new SqlParameter("@Station6Temp",actualData .Station2Humidity),
                new SqlParameter("@Station6Humidity",actualData .Station6Humidity)
            };
            return SQLHelper.ExecuteNonQuery(stringBuilder.ToString(), sqlParameters);

        }
        /// <summary>
        /// 查询数据库
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public DataTable QueryActualDataByCondition(string start,string end,List<string> columns)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Select InsertTime,");
            stringBuilder .Append(string.Join(",", columns));
            stringBuilder.Append(" from ActualData ");
            stringBuilder.Append("where 1=1 ");
            stringBuilder.Append("and InsertTime between @start and @end");

            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@start",start ),
                new SqlParameter("@end",end)
              
           };
            try
            {
                DataSet dataSet = SQLHelper.GetDataSet(stringBuilder.ToString(), sqlParameters);
                if (dataSet.Tables.Count > 0)
                {
                    return dataSet.Tables[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

           
        }
    }
}
