using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class ProcurementPlus
    {

        /// <summary>
        /// 日常用品采购申请单副表
        /// </summary>
        
        /// <summary>
        /// 主键序号
        /// </summary>
        public int procurementplus_Id { get; set; }
        /// <summary>
        /// taskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 用品名称
        /// </summary>
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
