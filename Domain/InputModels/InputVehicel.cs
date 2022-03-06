using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputVehicel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int vehicel_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string vehicel_Name { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string vehicel_Section { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public string vehicel_Sdate { get; set; }
        /// <summary>
        /// 星期
        /// </summary>
        public string vehicel_Week { get; set; }
        /// <summary>
        /// 出发地点
        /// </summary>
        public string vehicel_Start { get; set; }
        /// <summary>
        /// 目标地点
        /// </summary>
        public string vehicel_Target { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        public string vehicel_Cdate { get; set; }
        /// <summary>
        /// 返回时间
        /// </summary>
        public string vehicel_Fdate { get; set; }
        /// <summary>
        /// 乘车人数
        /// </summary>
        public int vehicel_Sum { get; set; }
        /// <summary>
        /// 随同人员
        /// </summary>
        public string vehicel_People { get; set; }
        /// <summary>
        /// 是由
        /// </summary>
        public string vehicel_Shi { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string vehicel_Number { get; set; }
        /// <summary>
        /// 出发时间2
        /// </summary>
        public string vehicel_Chudate { get; set; }
        /// <summary>
        /// 途径
        /// </summary>
        public string vehicel_Way { get; set; }
        /// <summary>
        /// 出发表盘公里数
        /// </summary>
        public int vehicel_Kkm { get; set; }
        /// <summary>
        /// 结束表盘公里数
        /// </summary>
        public int vehicel_Jkm { get; set; }
        /// <summary>
        /// 实际公里数
        /// </summary>
        public int vehicel_Skm { get; set; }
        /// <summary>
        /// 驾驶员
        /// </summary>
        public string vehicel_Driver { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string vehicel_Remner { get; set; }
    }
}
