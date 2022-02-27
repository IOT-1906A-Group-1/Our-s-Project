using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BPMSysOUs
    {
        [Key]
        /// <summary>
        /// ouid
        /// </summary>
        public virtual int Ouid
        {
            get; set;
        }

        /// <summary>
        /// parentOUID
        /// </summary>
        public virtual int ParentOUID
        {
            get; set;
        }

        /// <summary>
        /// oUName
        /// </summary>
        public virtual string OUName
        {
            get; set;
        }

        /// <summary>
        /// oULevel
        /// </summary>
        public virtual string OULevel
        {
            get; set;
        }

        /// <summary>
        /// rsid
        /// </summary>
        public virtual string Rsid
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

        /// <summary>
        /// code
        /// </summary>
        public virtual string Code
        {
            get; set;
        }

        /// <summary>
        /// orderIndex
        /// </summary>
        public virtual int OrderIndex
        {
            get; set;
        }

    }
}
