using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetconnectModel")]
    public class AssetconnectModel
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Connect_Per { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Connect_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Connect_Data { get; set; }
        /// <summary>
        /// 交接单号
        /// </summary>
        public string Connect_Number { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string Connect_Numbering { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Connect_Name { get; set; }
        /// <summary>
        /// 交接人
        /// </summary>
        public string Connect_Handover { get; set; }
        /// <summary>
        /// 交接人部门
        /// </summary>
        public string Connect_Hdepartment{ get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Connect_Remark { get; set; }
    }
}
