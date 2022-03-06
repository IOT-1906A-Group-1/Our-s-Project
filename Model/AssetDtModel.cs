using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetDtModel")]
    public class AssetDtModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Dt_Name { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Dt_Model { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Dt_Num { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public int Dt_Price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public int Dt_Amount { get; set; }
        /// <summary>
        /// 供货单位
        /// </summary>
        public string Dt_Unit { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        public string Dt_Purchaser { get; set; }
    }
}
