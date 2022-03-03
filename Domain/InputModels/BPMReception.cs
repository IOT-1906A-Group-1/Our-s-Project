using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class BPMReception:BaseModels
    {
        /// <summary>
        /// 接待申请表--主表
        /// </summary>
        public string Reception { get; set; }
        /// <summary>
        /// 接待申请表-副表2
        /// </summary>
        public string Receptions { get; set; }
        /// <summary>
        /// 接待申请表-副表3
        /// </summary>
        public string Receptionplus { get; set; }
    }
}
