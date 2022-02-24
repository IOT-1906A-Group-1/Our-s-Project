using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    /// <summary>
    /// 年度计划表(主表)
    /// </summary>
    public class InputPlanModels:BaseModels
    {

        public int TaskId { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int plan_Id { get; set; }
        /// <summary>
        /// 制表人
        /// </summary>
        public string plan_People { get; set; }
        /// <summary>
        /// 制表时间
        /// </summary>
        public DateTime plan_CreateTime { get; set; }
        /// <summary>
        /// 指标部门
        /// </summary>
        public string plan_PartMent { get; set; }
        /// <summary>
        /// 年份
        /// </summary>
        public DateTime plan_Years { get; set; }
        /// <summary>
        /// 详细信息表外键
        /// </summary>
        public int plan_InFormationId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string plan_Remark { get; set; }
    }
}
