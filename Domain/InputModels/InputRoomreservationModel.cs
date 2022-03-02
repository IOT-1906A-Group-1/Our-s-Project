using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputRoomreservationModel
    {
        /// <summary>
        /// 会议室预定
        /// </summary>

        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int roomreservationmodel_Id { get; set; }
        /// <summary>
        /// taskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 会议室
        /// </summary>
        public string roomreservationmodel_Name { get; set; }
        /// <summary>
        /// 座位
        /// </summary>
        public int roomreservationmodel_Zuo { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string roomreservationmodel_Bu { get; set; }
        /// <summary>
        /// 使用人
        /// </summary>
        public string roomreservationmodel_People { get; set; }
        /// <summary>
        /// 事由
        /// </summary>
        public string roomreservationmodel_Shi { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime roomreservationmodel_Stime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime roomreservationmodel_Etime { get; set; }
    }
}
