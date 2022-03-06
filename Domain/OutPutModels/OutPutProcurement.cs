using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OutPutModels
{
    public class OutPutProcurement
    {
        /// <summary>
        /// 主键
        /// </summary>
       
        public int procurement_Id { get; set; }
        /// <summary>
        /// taskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string procurement_Name { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string procurement_Jing { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string procurement_Sbu { get; set; }
        /// <summary>
        /// 经办部门
        /// </summary>
        public string procurement_Jbu { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime procurement_Stime { get; set; }
        /// <summary>
        /// 经办日期
        /// </summary>
        public DateTime procurement_Jtime { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string procurement_Yong { get; set; }
        public string procurementplus_Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string procurementplus_Gui { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int procurementplus_Num { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string procurementplus_Dan { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal procurementplus_Price { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string procurementplus_Bei { get; set; }
    }
}
