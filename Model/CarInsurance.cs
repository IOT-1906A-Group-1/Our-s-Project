using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 车辆保险表
    /// </summary>
    public class CarInsurance
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int carinsutance_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carinsutance_Name { get; set; }
        /// <summary>
        /// 制表时间
        /// </summary>
        public DateTime carinsutance_Zdate { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public string carinsutance_Style { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string carinsutance_Number { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime carinsutance_Mdate { get; set; }
        /// <summary>
        /// 座位数
        /// </summary>
        public int carinsutance_Seat { get; set; }
        /// <summary>
        /// 保险金额
        /// </summary>
        public Decimal carinsutance_Price { get; set; }
        /// <summary>
        /// 乘客险
        /// </summary>
        public Decimal carinsutance_Danger { get; set; }
        /// <summary>
        /// 保险项目
        /// </summary>
        public string carinsutance_Project { get; set; }
        /// <summary>
        /// 截止保险日期
        /// </summary>
        public DateTime carinsutance_Jdate { get; set; }
        /// <summary>
        /// 保险开始日期
        /// </summary>
        public DateTime carinsutance_Bkdate { get; set; }
        /// <summary>
        /// 保险结束日期
        /// </summary>
        public string carinsutance_Bjdate { get; set; }
    }
}
