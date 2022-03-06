using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetFdModel")]
    public class AssetFdModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Fd_Applicant { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Fd_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Fd_Data { get; set; }
        /// <summary>
        /// 申请编号
        /// </summary>
        public string Fd_Numbering { get; set; }
        /// <summary>
        /// 资产类别
        /// </summary>
        public string Fd_Type { get; set; }
        /// <summary>
        /// 存放地点
        /// </summary>
        public string Fd_Deposit { get; set; }
        /// <summary>
        /// 请购单号
        /// </summary>
        public string Fd_Number { get; set; }
        /// <summary>
        /// 所属项目
        /// </summary>
        public string Fd_Project { get; set; }
        /// <summary>
        /// 使用人
        /// </summary>
        public string Fd_User { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string Fd_Affiliationdp { get; set; }
    }
}
