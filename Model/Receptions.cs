using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receptions
    {
        /// <summary>
        /// 接待申请表-副表1
        /// </summary>
        
        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        public int receptions_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 物品名称
        /// </summary>
        public string receptions_Name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string receptions_Ben { get; set; }
        /// <summary>
        /// 使用数量
        /// </summary>
        public string receptions_Qin { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public string receptions_Knum { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public string receptions_Snum { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string receptions_Bei { get; set; }
    }
}
