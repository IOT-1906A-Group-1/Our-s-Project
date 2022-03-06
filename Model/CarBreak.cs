using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 车辆违章表
    /// </summary>
    public class CarBreak
    {
        /// <summary>
        /// 主键 
        /// </summary>
        [Key]
        public int carbreak_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carbreak_Name { get; set; }
        /// <summary>
        /// 处理日期
        /// </summary>
        public DateTime carbreak_Rdate { get; set; }
        /// <summary>
        /// 车辆违章日期
        /// </summary>
        public DateTime carbreak_Wdate { get; set; }
        /// <summary>
        /// 违章驾驶员
        /// </summary>
        public string carbreak_Driver { get; set; }
        /// <summary>
        /// 车辆违章是由
        /// </summary>
        public string carbreak_Shi { get; set; }
        /// <summary>
        /// 罚款金额
        /// </summary>
        public Decimal carbreak_Price { get; set; }
        /// <summary>
        /// 扣分
        /// </summary>
        public int carbreak_Deduct { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime carbreak_Cdate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carbreak_Remark { get; set; }
    }
}
