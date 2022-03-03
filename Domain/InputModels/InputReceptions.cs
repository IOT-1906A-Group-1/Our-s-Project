using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputReceptions
    {
        /// <summary>
        /// 接待申请表-副表2
        /// </summary>

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        public int receptionplus_Id { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime receptionplus_Stime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime receptionplus_Etime { get; set; }
        /// <summary>
        /// 行程
        /// </summary>
        public string receptionplus_Xing { get; set; }
        /// <summary>
        /// 陪同人员
        /// </summary>
        public string receptionplus_Pei { get; set; }
        /// <summary>
        /// 是否用车
        /// </summary>
        public bool receptionplus_Yong { get; set; }
        /// <summary>
        /// 是否预定会议室
        /// </summary>
        public bool receptionplus_Hui { get; set; }
        /// <summary>
        /// 是否预定酒店
        /// </summary>
        public bool receptionplus_Jiu { get; set; }
        /// <summary>
        /// 是否需要展厅
        /// </summary>
        public bool receptionplus_Zhan { get; set; }
        /// <summary>
        /// 是否需要订餐
        /// </summary>
        public bool receptionplus_Can { get; set; }
        /// <summary>
        /// 残疾公司那些部门
        /// </summary>
        public string receptionplus_Bu { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string receptionplus_Bei { get; set; }
    }
}
