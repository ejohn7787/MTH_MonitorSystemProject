using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTH_Models.models.Recipe
{
    /// <summary>
    /// 配方的实体类
    /// </summary>
    public class RecipeParam
    {
        public float TempHighLimit { get; set; }
        public float TempLowLimit { get; set; }
        public float HumiHighLimit { get; set; }
        public float  HumiLowLimit { get; set; }
        public bool TempAlarmEnable { get; set; }
        public bool HumiAlarmEnable { get; set; }
    }
}
