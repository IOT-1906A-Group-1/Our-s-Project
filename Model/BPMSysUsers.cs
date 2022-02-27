using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BPMSysUsers
    {
        [Key]
        /// <summary>
        /// account
        /// </summary>
        public virtual string Account
        {
            get; set;
        }

        /// <summary>
        /// password
        /// </summary>
        public virtual string Password
        {
            get; set;
        }

        /// <summary>
        /// sysUser
        /// </summary>
        public virtual bool SysUser
        {
            get; set;
        }

        /// <summary>
        /// displayName
        /// </summary>
        public virtual string DisplayName
        {
            get; set;
        }

        /// <summary>
        /// description
        /// </summary>
        public virtual string Description
        {
            get; set;
        }

        /// <summary>
        /// sex
        /// </summary>
        public virtual string Sex
        {
            get; set;
        }

        /// <summary>
        /// birthday
        /// </summary>
        public virtual System.DateTime Birthday
        {
            get; set;
        }

        /// <summary>
        /// hrid
        /// </summary>
        public virtual string Hrid
        {
            get; set;
        }

        /// <summary>
        /// dateHired
        /// </summary>
        public virtual System.DateTime DateHired
        {
            get; set;
        }

        /// <summary>
        /// office
        /// </summary>
        public virtual string Office
        {
            get; set;
        }

        /// <summary>
        /// costCenter
        /// </summary>
        public virtual string CostCenter
        {
            get; set;
        }

        /// <summary>
        /// officePhone
        /// </summary>
        public virtual string OfficePhone
        {
            get; set;
        }

        /// <summary>
        /// homePhone
        /// </summary>
        public virtual string HomePhone
        {
            get; set;
        }

        /// <summary>
        /// mobile
        /// </summary>
        public virtual string Mobile
        {
            get; set;
        }

        /// <summary>
        /// eMail
        /// </summary>
        public virtual string EMail
        {
            get; set;
        }

        /// <summary>
        /// wWWHomePage
        /// </summary>
        public virtual string WWWHomePage
        {
            get; set;
        }

        /// <summary>
        /// location
        /// </summary>
        public virtual string Location
        {
            get; set;
        }

        /// <summary>
        /// age
        /// </summary>
        public virtual int Age
        {
            get; set;
        }

        /// <summary>
        /// userLevel
        /// </summary>
        public virtual int UserLevel
        {
            get; set;
        }

        /// <summary>
        /// 家庭电话
        /// </summary>
        public virtual string 家庭电话
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
        /// logonProvider
        /// </summary>
        public virtual string LogonProvider
        {
            get; set;
        }

        /// <summary>
        /// disabled
        /// </summary>
        public virtual bool Disabled
        {
            get; set;
        }

        /// <summary>
        /// nameSpell
        /// </summary>
        public virtual string NameSpell
        {
            get; set;
        }
    }
}
