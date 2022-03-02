using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputRoomNewModel
    {
        /// <summary>
        /// 会议室新增
        /// </summary>

        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int roomnewmodel_Id { get; set; }
        /// <summary>
        /// taskId
        /// </summary>
        public int TaskId { get; set; }
        /// <summary>
        /// 会议室名称
        /// </summary>
        public string roomnewmodel_Name { get; set; }
        /// <summary>
        /// 座位
        /// </summary>tss
        public int roomnewmodel_Znum { get; set; }
        /// <summary>
        /// 楼层
        /// </summary>
        public int roomnewmodel_Floor { get; set; }
        /// <summary>
        /// 可容纳人数
        /// </summary>
        public int roomnewmodel_Rnum { get; set; }
        /// <summary>
        /// 空调
        /// </summary>
        public string roomnewmodel_Kong { get; set; }
        /// <summary>
        /// 投影仪
        /// </summary>
        public string roomnewmodel_Tou { get; set; }
        /// <summary>
        /// 白板
        /// </summary>
        public string roomnewmodel_Bai { get; set; }
        /// <summary>
        /// 网络
        /// </summary>
        public string roomnewmodel_Wifi { get; set; }
        /// <summary>
        /// 网络范围
        /// </summary>
        public string roomnewmodel_Wfan { get; set; }
        /// <summary>
        /// 饮水机
        /// </summary>
        public string roomnewmodel_Ying { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public string roomnewmodel_Guan { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string roomnewmodel_Zhao { get; set; }
    }
}
