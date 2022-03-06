using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 车辆维修表
    /// </summary>
    public class CarService
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int carservice_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carservice_Name { get; set; }
        /// <summary>
        /// 维修日期
        /// </summary>
        public DateTime carservice_Wdate { get; set; }
        /// <summary>
        /// 维修项目
        /// </summary>
        public string carservice_Project { get; set; }
        /// <summary>
        /// 维修单位
        /// </summary>
        public string carservice_Unit { get; set; }
        /// <summary>
        /// 维修当时公里数
        /// </summary>
        public int carservice_Km { get; set; }
        /// <summary>
        /// 维修费用
        /// </summary>
        public Decimal carservice_Money { get; set; }
        /// <summary>
        /// 出故障人员
        /// </summary>
        public string carservice_Trouble { get; set; }
        /// <summary>
        /// 出故障日期
        /// </summary>
        public DateTime carservice_Cdate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carservice_Remark { get; set; }
    }
}
