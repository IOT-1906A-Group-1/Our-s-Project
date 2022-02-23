using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工录用表
    /// </summary>
    public class Employ
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int employ_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string employ_Section { get; set; }
        /// <summary>
        /// 核定日期
        /// </summary>
        public DateTime employ_Hdate { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string employ_Post { get; set; }
        /// <summary>
        /// 岗位说明
        /// </summary>
        public string employ_State { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        public string employ_Style { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string employ_Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool employ_Sex { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime employ_Date { get; set; }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string employ_Culture { get; set; }
        /// <summary>
        /// 健康状况
        /// </summary>
        public string employ_Health { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string employ_Phone { get; set; }
        /// <summary>
        /// 住址
        /// </summary>
        public string employ_Address { get; set; }
        /// <summary>
        /// 特长
        /// </summary>
        public string employ_Speciality { get; set; }
        /// <summary>
        /// 是否在本公司工作
        /// </summary>
        public bool employ_Isput { get; set; }
        /// <summary>
        /// 工资及待遇
        /// </summary>
        public string employ_Treatment { get; set; }
        /// <summary>
        /// 合同期限
        /// </summary>
        public string employ_Time { get; set; }
        /// <summary>
        /// 试用期
        /// </summary>
        public string employ_Period { get; set; }
    }
}
