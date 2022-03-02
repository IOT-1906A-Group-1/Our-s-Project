using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
   public class BPMProcurementModel:BaseModels
    {
        /// <summary>
        /// 日常用品采购申请单
        /// </summary>
        public string Procurement { get; set; }
        /// <summary>
        /// 日常用品采购申请单详情
        /// </summary>
        public string ProcurementPlus { get; set; }
    }
}
