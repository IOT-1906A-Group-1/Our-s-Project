using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
   public class BPMPlanModels:BaseModels
    {
        /// <summary>
        /// 年度计划主表
        /// </summary>
        public string PlanData { get; set; }
        /// <summary>
        /// 年度计划详细
        /// </summary>
        public string PlanInfoDetail { get; set; }
    }
}
