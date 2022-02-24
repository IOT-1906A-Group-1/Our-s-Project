using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputEmploy:BaseModels
    {
        public int employ_Id { get; set; }//主键id
        public int TaskId { get; set; }//taskid
        public string employ_Section { get; set; }//使用部门
        public DateTime employ_Hdate { get; set; }//核定日期
        public string employ_Post { get; set; }//岗位名称
        public string employ_State { get; set; }//岗位说明
        public string employ_Style { get; set; }//人员类别
        public string employ_Name { get; set; }//姓名
        public bool employ_Sex { get; set; }//性别
        public DateTime employ_Date { get; set; }//出生日期
        public string employ_Culture { get; set; }//文化程度
        public string employ_Health { get; set; }//健康状况
        public string employ_Phone { get; set; }//电话
        public string employ_Address { get; set; }//住址
        public string employ_Speciality { get; set; }//特长
        public bool employ_Isput { get; set; }//是否在本公司工作
        public string employ_Treatment { get; set; }//工资及待遇
        public string employ_Time { get; set; }//合同期限
        public string employ_Period { get; set; }//试用期
    }
}
