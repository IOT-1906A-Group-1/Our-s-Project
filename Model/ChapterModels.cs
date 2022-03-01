using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChapterModels
    {
        public int TaskId { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int Chapter_Id { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Chapter_Person { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Chapter_Part { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Chapter_Date { get; set; }
        /// <summary>
        /// 印章名称
        /// </summary>
        public string Chapter_Name { get; set; }
        /// <summary>
        /// 陪同人员
        /// </summary>
        public string Chapter_People { get; set; }
        /// <summary>
        /// 是否外借
        /// </summary>
        public string Chapter_Lend { get; set; }
        /// <summary>
        /// 归还日期
        /// </summary>
        public string Chapter_SendBack { get; set; }
        /// <summary>
        /// 外出地址
        /// </summary>
        public string Chapter_Address { get; set; }
        /// <summary>
        /// 用章主要用途和内容
        /// </summary>
        public string Chapter_Content { get; set; }
    }
}
