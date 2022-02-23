using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工亲属详细信息表
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int employee_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        ///亲属姓名
        /// </summary>
        public string employee_Name { get; set; }
        /// <summary>
        /// 与本人关系
        /// </summary>
        public string employee_Relation { get; set; }
        /// <summary>
        /// 亲属在公司的职务
        /// </summary>
        public string employee_Post { get; set; }
    }
}
