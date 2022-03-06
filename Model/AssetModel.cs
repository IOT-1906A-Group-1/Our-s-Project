using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetModel")]
    public class AssetModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Asset_Per { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Asset_Department{ get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Asset_Date { get; set; }
        /// <summary>
        /// 表单单号
        /// </summary>
        public string Asset_Number{ get; set; }
        /// <summary>
        /// 固定资产名称
        /// </summary>
        public string Asset_Name { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string Asset_Model { get; set; }
        /// <summary>
        /// 配置
        /// </summary>
        public string Asset_Disposition { get; set; }
        /// <summary>
        /// 是否生产资产
        /// </summary>
        public bool Asset_State { get; set; }
        /// <summary>
        /// 申请理由
        /// </summary>
        public string Asset_Reason { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Asset_Remark { get; set; }

    }
}
