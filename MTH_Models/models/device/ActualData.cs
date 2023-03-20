using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.models.device
{
    /// <summary>
    /// 实时数据的实体类,保存到SQL数据库的ActualData数据表
    /// </summary>
    public  class ActualData
    {
        public string InsertTime { get; set; }
        public string Station1Temp { get; set; }
        public string Station1Humidity { get;set; }
        public string Station2Temp { get; set; }
        public string Station2Humidity { get; set; }
        public string Station3Temp { get; set; }
        public string Station3Humidity { get; set; }
        public string Station4Temp { get; set; }
        public string Station4Humidity { get; set; }
        public string Station5Temp { get; set; }
        public string Station5Humidity { get; set; }
        public string Station6Temp { get; set; }
        public string Station6Humidity { get; set; }

    }
}
