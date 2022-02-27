using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OutPutModels
{
    public class OutPutUser
    {
        /// <summary>
        /// user表主键id
        /// </summary>
        public int user_Id { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string user_Name { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string role_Name { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string department_Name { get; set; }
        /// <summary>
        /// userToRole表主键id
        /// </summary>
        public int userToRole_Id { get; set; }
    }
}
