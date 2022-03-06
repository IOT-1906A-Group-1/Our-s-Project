using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 车辆保养表
    /// </summary>
    public class CarMaintain
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int carmaintain_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carmaintain_Name { get; set; }
        /// <summary>
        /// 保养日期
        /// </summary>
        public DateTime carmaintain_Date { get; set; }
        /// <summary>
        /// 保养原因
        /// </summary>
        public string carmaintain_Cause { get; set; }
        /// <summary>
        /// 保养项目
        /// </summary>
        public string carmaintain_Project { get; set; }
        /// <summary>
        /// 保养单位
        /// </summary>
        public string carmaintain_Unit { get; set; }
        /// <summary>
        /// 保养费用
        /// </summary>
        public string carmaintain_Money { get; set; }
        /// <summary>
        /// 保养当时公里数
        /// </summary>
        public int carmaintain_Km { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carmaintain_Remark { get; set; }
    }
}
