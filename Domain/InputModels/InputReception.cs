using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputReception
    {
        /// <summary>
        /// 接待申请表--主表
        /// </summary>

        /// <summary>
        /// 主键Id
        /// </summary>
        [Key]
        public int reception_Id { get; set; }
        /// <summary>
        /// taskid
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public string reception_Name { get; set; }
        /// <summary>
        /// 申请部门
        /// </summary>
        public string reception_Bu { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime reception_Stime { get; set; }
        /// <summary>
        /// 来访客人单位
        /// </summary>
        public string reception_Laifang { get; set; }
        /// <summary>
        /// 主要客人姓名、职位
        /// </summary>
        public string reception_Zhuyao { get; set; }
        /// <summary>
        /// 停留时间
        /// </summary>
        public DateTime reception_Ttime { get; set; }
        public DateTime reception_Ttimeplus { get; set; }
        /// <summary>
        /// 接待人
        /// </summary>
        public string reception_Jie { get; set; }
        /// <summary>
        /// 人数
        /// </summary>
        public int reception_Rnum { get; set; }
        /// <summary>
        /// 是否需要准备资料
        /// </summary>
        public bool reception_Zi { get; set; }
        /// <summary>
        /// 往来航班号
        /// </summary>
        public string reception_Lai { get; set; }
        /// <summary>
        /// 是否需要物品
        /// </summary>
        public bool reception_Wu { get; set; }
        /// <summary>
        /// 来访事由
        /// </summary>
        public string reception_Shi { get; set; }
        /// <summary>
        /// 其他要求
        /// </summary>
        public string reception_Yao { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string reception_Bei { get; set; }
    }
}
