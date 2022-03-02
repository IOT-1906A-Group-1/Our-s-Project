using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Leave
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 任务id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string applyPeople { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string applyDepartment { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string applyDate { get; set; }
        /// <summary>
        /// 请假开始时间
        /// </summary>
        public string startDate { get; set; }
        /// <summary>
        /// 请假结束时间
        /// </summary>
        public string endDate { get; set; }
        /// <summary>
        /// 请假类型
        /// </summary>
        public string leaveType { get; set; }
        /// <summary>
        /// 请假天数
        /// </summary>
        public string leaveDays { get; set; }
        /// <summary>
        /// 请假原因
        /// </summary>
        public string leaveReason { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string OUsName { get; set; }
    }
}
