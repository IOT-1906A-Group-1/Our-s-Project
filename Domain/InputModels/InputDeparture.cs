using Domain.InputModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.InputModels
{
    /// <summary>
    /// 员工离职表
    /// </summary>
    public class InputDeparture:BaseModels
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int departure_Id { get; set; }
        /// <summary>
        /// taskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string departure_Name { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string departure_Bu { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime departure_Date { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string departure_Zhi { get; set; }
        /// <summary>
        /// 入职日期
        /// </summary>
        public DateTime departure_RDate { get; set; }
        /// <summary>
        /// 离职类型
        /// </summary>
        public string departure_Lizhi { get; set; }
    }
}
