using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    ///<summary>
    ///表BPMSysOURoles的实体类
    ///</summary>
    public class BPMSysOURoles
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int KeyId { get; set; }
        /// <summary>
        /// ouid
        /// </summary>
        public virtual int Ouid
        {
            get; set;
        }

        /// <summary>
        /// roleName
        /// </summary>
        public virtual string RoleName
        {
            get; set;
        }

        /// <summary>
        /// sid
        /// </summary>
        public virtual string Sid
        {
            get; set;
        }

    }
}
