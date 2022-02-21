using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public Decimal ProductPrice { get; set; }
        public int DDD { get; set; }
        public int Number { get; set; }
    }
}
