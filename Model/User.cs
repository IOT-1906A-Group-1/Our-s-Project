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
        [Key]
        public int user_Id { get; set; }//主键id
        public string user_Account { get; set; }//用户名
        public string user_Password { get; set; }//密码
        //冯俊杰
        //杰哥
        //今天上课好像犯困了
    }
}
