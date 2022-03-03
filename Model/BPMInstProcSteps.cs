using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BPMInstProcSteps
    {
        [Key]
        public int StepID { get; set; }

        public int TaskID { get; set; }

        [Required]
        [StringLength(30)]
        public string ProcessName { get; set; }

        [Required]
        [StringLength(30)]
        public string NodeName { get; set; }

        [StringLength(50)]
        public string OwnerAccount { get; set; }

        [StringLength(50)]
        public string AgentAccount { get; set; }

        public DateTime ReceiveAt { get; set; }

        public DateTime? FinishAt { get; set; }

        [StringLength(30)]
        public string SelAction { get; set; }

        public bool Share { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        public bool HumanStep { get; set; }

        [StringLength(50)]
        public string HandlerAccount { get; set; }

        [StringLength(30)]
        public string SubNodeName { get; set; }

        public bool AutoProcess { get; set; }

        public string Comments { get; set; }

        public int? UsedMinutes { get; set; }

        public int? UsedMinutesWork { get; set; }

        public int? RecedeFromStep { get; set; }

        public int TimeoutNotifyCount { get; set; }

        public int? RisedConsignID { get; set; }

        public int? BelongConsignID { get; set; }

        [StringLength(50)]
        public string ConsignOwnerAccount { get; set; }

        public DateTime? TimeoutFirstNotifyDate { get; set; }

        public DateTime? TimeoutDeadline { get; set; }

        public int? StandardMinutesWork { get; set; }

        public bool BatchApprove { get; set; }

        public bool Posted { get; set; }

        public bool FormSaved { get; set; }

        public int? ParentStepID { get; set; }

        [StringLength(200)]
        public string NodePath { get; set; }

        public int? ExtYear { get; set; }

        public int? ExtStepYear { get; set; }

        [StringLength(50)]
        public string ExtRecipient { get; set; }

        public bool ExtDeleted { get; set; }

        public int? OwnerPositionID { get; set; }

        [Required]
        [StringLength(10)]
        public string ProcessVersion { get; set; }
    }
}
