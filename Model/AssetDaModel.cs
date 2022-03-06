using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetDaModel")]
    public class AssetDaModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 附件说明
        /// </summary>
        public string Da_Illustrate { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Da_Unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Da_Num { get; set; }
        /// <summary>
        /// 保管人
        /// </summary>
        public string Da_Custodian { get; set; }
        /// <summary>
        /// 附件添加
        /// </summary>
        public string Da_Annex { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Da_remark { get; set; }  
    }
}
