using MTH_Models.models.device;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;

namespace zj.BLL
{
    public class ActualDataManage
    {
        private ActualDataService actualDataService = new ActualDataService();
        public bool AddActualData(ActualData actualData)
        {
            return actualDataService.AddActualData(actualData)==1;
        }
        public DataTable QueryActualDataByCondition(string start,string end,List<string> columns)
        {
            return  actualDataService.QueryActualDataByCondition(start,end,columns);
        }
    }
}
