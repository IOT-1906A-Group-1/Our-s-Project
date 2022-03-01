using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using Domain.InputModels;

namespace Domain.InputModels
{
    /// <summary>
    ///人力资源管理需求 
    /// </summary>
    [Table("HRModel")]
    public class InputHRModel
    {
        [Key]
        public int HId { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请部门-自动填充当前登录用户的部门不可修改
        /// </summary>
        public string HR_Department { get; set; }
        /// <summary>
        /// 岗位名称-自动填充当前登录用户的岗位不可更改
        /// </summary>
        public string HR_Job { get; set; }
        /// <summary>
        /// 现有人数
        /// </summary>
        public int HR_Number { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public string HR_Time { get; set; }
        /// <summary>
        /// 岗位说明-自动填充当前的岗位声明可更改
        /// </summary>
        public string HR_Description { get; set; }
        /// <summary>
        /// 招聘人数
        /// </summary>
        public int HR_Recruits { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string HR_Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int HR_Age { get; set; }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string HR_Education { get; set; }
        /// <summary>
        /// 专业要求
        /// </summary>
        public string HR_Specialized { get; set; }
        /// <summary>
        /// 岗位要求
        /// </summary>
        public string HR_Jobrequirements { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string HR_Other { get; set; }
        /// <summary>
        /// 薪资待遇
        /// </summary>
        public int HR_Salarypackage { get; set; }
        /// <summary>
        /// 试用期
        /// </summary>
        public string HR_Tryout { get; set; }
        /// <summary>
        /// 申请原因
        /// </summary>
        public string HR_Application { get; set; }
        /// <summary>
        /// 拟聘合同
        /// </summary>
        public string HR_Proposed { get; set; }
        /// <summary>
        /// 添加附件
        /// </summary>
        public string HR_Annex { get; set; }
    }
}
