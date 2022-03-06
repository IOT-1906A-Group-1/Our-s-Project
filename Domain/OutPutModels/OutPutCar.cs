using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OutPutModels
{
    public class OutPutCar
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int carmaintain_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carmaintain_Name { get; set; }
        /// <summary>
        /// 保养日期
        /// </summary>
        public DateTime carmaintain_Date { get; set; }
        /// <summary>
        /// 保养原因
        /// </summary>
        public string carmaintain_Cause { get; set; }
        /// <summary>
        /// 保养项目
        /// </summary>
        public string carmaintain_Project { get; set; }
        /// <summary>
        /// 保养单位
        /// </summary>
        public string carmaintain_Unit { get; set; }
        /// <summary>
        /// 保养费用
        /// </summary>
        public string carmaintain_Money { get; set; }
        /// <summary>
        /// 保养当时公里数
        /// </summary>
        public int carmaintain_Km { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carmaintain_Remark { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        public int carinsutance_Id { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carinsutance_Name { get; set; }
        /// <summary>
        /// 制表时间
        /// </summary>
        public DateTime carinsutance_Zdate { get; set; }
        /// <summary>
        /// 车型
        /// </summary>
        public string carinsutance_Style { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string carinsutance_Number { get; set; }
        /// <summary>
        /// 购买日期
        /// </summary>
        public DateTime carinsutance_Mdate { get; set; }
        /// <summary>
        /// 座位数
        /// </summary>
        public int carinsutance_Seat { get; set; }
        /// <summary>
        /// 保险金额
        /// </summary>
        public Decimal carinsutance_Price { get; set; }
        /// <summary>
        /// 乘客险
        /// </summary>
        public Decimal carinsutance_Danger { get; set; }
        /// <summary>
        /// 保险项目
        /// </summary>
        public string carinsutance_Project { get; set; }
        /// <summary>
        /// 截止保险日期
        /// </summary>
        public DateTime carinsutance_Jdate { get; set; }
        /// <summary>
        /// 保险开始日期
        /// </summary>
        public DateTime carinsutance_Bkdate { get; set; }
        /// <summary>
        /// 保险结束日期
        /// </summary>
        public string carinsutance_Bjdate { get; set; }
        /// <summary>
        /// 主键
        /// </summary>
        public int carservice_Id { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carservice_Name { get; set; }
        /// <summary>
        /// 维修日期
        /// </summary>
        public DateTime carservice_Wdate { get; set; }
        /// <summary>
        /// 维修项目
        /// </summary>
        public string carservice_Project { get; set; }
        /// <summary>
        /// 维修单位
        /// </summary>
        public string carservice_Unit { get; set; }
        /// <summary>
        /// 维修当时公里数
        /// </summary>
        public int carservice_Km { get; set; }
        /// <summary>
        /// 维修费用
        /// </summary>
        public Decimal carservice_Money { get; set; }
        /// <summary>
        /// 出故障人员
        /// </summary>
        public string carservice_Trouble { get; set; }
        /// <summary>
        /// 出故障日期
        /// </summary>
        public DateTime carservice_Cdate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carservice_Remark { get; set; }
        /// <summary>
        /// 主键 
        /// </summary>
        public int carbreak_Id { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string carbreak_Name { get; set; }
        /// <summary>
        /// 处理日期
        /// </summary>
        public DateTime carbreak_Rdate { get; set; }
        /// <summary>
        /// 车辆违章日期
        /// </summary>
        public DateTime carbreak_Wdate { get; set; }
        /// <summary>
        /// 违章驾驶员
        /// </summary>
        public string carbreak_Driver { get; set; }
        /// <summary>
        /// 车辆违章是由
        /// </summary>
        public string carbreak_Shi { get; set; }
        /// <summary>
        /// 罚款金额
        /// </summary>
        public Decimal carbreak_Price { get; set; }
        /// <summary>
        /// 扣分
        /// </summary>
        public int carbreak_Deduct { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime carbreak_Cdate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string carbreak_Remark { get; set; }
        public int key { get; set; }
    }
}
