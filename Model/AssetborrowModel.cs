using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("AssetborrowModel")]
    public class AssetborrowModel
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string Borrow_Per { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string Borrow_Department { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public string Borrow_Date { get; set; }
        /// <summary>
        /// 归还日期
        /// </summary>
        public string Borrow_Data { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Borrow_Name { get; set; }
        /// <summary>
        /// 资产型号
        /// </summary>
        public string Borrow_Model { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Borrow_Remark { get; set; }
        /// <summary>
        /// 资料名称
        /// </summary>
        public string Borrow_information { get; set; }

    }
}
