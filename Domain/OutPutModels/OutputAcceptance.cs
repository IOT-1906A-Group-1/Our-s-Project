using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OutPutModels
{
    public class OutputAcceptance
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        /// <summary>
        /// 附件说明
        /// </summary>
        public string Da_Illustrate { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Da_Unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Da_Num { get; set; }
        /// <summary>
        /// 保管人
        /// </summary>
        public string Da_Custodian { get; set; }
        /// <summary>
        /// 附件添加
        /// </summary>
        public string Da_Annex { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string Dt_Name { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Dt_Model { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Dt_Num { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public int Dt_Price { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public int Dt_Amount { get; set; }
        /// <summary>
        /// 供货单位
        /// </summary>
        public string Dt_Unit { get; set; }
        /// <summary>
        /// 采购人
        /// </summary>
        public string Dt_Purchaser { get; set; }
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
        /// <summary>
        /// 备注
        /// </summary>
        public string Da_remark { get; set; }

    }
}
