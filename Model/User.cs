using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User//用户表
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int user_Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string user_Password { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string user_Name { get; set; }
    }
}
