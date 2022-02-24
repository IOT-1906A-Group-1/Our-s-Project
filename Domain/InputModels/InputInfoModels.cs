using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputInfoModels:BaseModels
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int info_Id { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        public string info_Position { get; set; }
        /// <summary>
        /// 上年已有
        /// </summary>
        public int info_LastYears_Has { get; set; }
        /// <summary>
        /// 一月份
        /// </summary>
        public int info_January{ get; set; }
        /// <summary>
        /// 二月份
        /// </summary>
        public int info_February { get; set; }
        /// <summary>
        /// 三月份
        /// </summary>
        public int info_March { get; set; }
        /// <summary>
        /// 四月份
        /// </summary>
        public int info_April { get; set; }
        /// <summary>
        /// 五月份
        /// </summary>
        public int info_May { get; set; }
        /// <summary>
        /// 六月份
        /// </summary>
        public int info_June { get; set; }
        /// <summary>
        /// 七月份
        /// </summary>
        public int info_July { get; set; }
        /// <summary>
        /// 八月份
        /// </summary>
        public int info_August { get; set; }
        /// <summary>
        /// 九月份
        /// </summary>
        public int info_September { get; set; }
        /// <summary>
        /// 十月份
        /// </summary>
        public int info_October { get; set; }
        /// <summary>
        /// 十一月份
        /// </summary>
        public int info_November { get; set; }
        /// <summary>
        /// 十二月份
        /// </summary>
        public int info_December { get; set; }
        /// <summary>
        /// 合计
        /// </summary>
        public int info_Sum { get; set; }
    }
}
