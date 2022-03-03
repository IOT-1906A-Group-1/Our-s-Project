using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BPMSysOUMembers
    {
        /// <summary>
        /// OUMId
        /// </summary>
        [Key]
        public int OUMId { get; set; }
        /// <summary>
        /// ouid
        /// </summary>
        public virtual int Ouid
        {
            get; set;
        }

        /// <summary>
        /// userAccount
        /// </summary>
        public virtual string UserAccount
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

        /// <summary>
        /// userDefaultRole
        /// </summary>
        public virtual bool UserDefaultRole
        {
            get; set;
        }

        /// <summary>
        /// leaderTitle
        /// </summary>
        public virtual string LeaderTitle
        {
            get; set;
        }

        /// <summary>
        /// department
        /// </summary>
        public virtual string Department
        {
            get; set;
        }

        /// <summary>
        /// fGOUEnabled
        /// </summary>
        public virtual bool FGOUEnabled
        {
            get; set;
        }

        /// <summary>
        /// fGYWEnabled
        /// </summary>
        public virtual bool FGYWEnabled
        {
            get; set;
        }

        /// <summary>
        /// level
        /// </summary>
        public virtual int Level
        {
            get; set;
        }

    }
}
