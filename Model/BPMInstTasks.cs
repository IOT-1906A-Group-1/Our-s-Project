using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BPMInstTasks
    {
        [Key]
        public int TaskID { get; set; }

        [Required]
        [StringLength(30)]
        public string ProcessName { get; set; }

        [StringLength(50)]
        public string OwnerAccount { get; set; }

        [StringLength(50)]
        public string AgentAccount { get; set; }

        public DateTime CreateAt { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public DateTime? FinishAt { get; set; }

        [Required]
        [StringLength(10)]
        public string State { get; set; }

        [StringLength(50)]
        public string SerialNum { get; set; }

        [StringLength(50)]
        public string OptUser { get; set; }

        public DateTime? OptAt { get; set; }

        [StringLength(50)]
        public string OptMemo { get; set; }

        public int? FormDataSetID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? ExtYear { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(50)]
        public string ExtInitiator { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? ExtDeleted { get; set; }

        public int? OwnerPositionID { get; set; }

        public int? ParentTaskID { get; set; }

        public int? ParentStepID { get; set; }

        [StringLength(50)]
        public string ParentStepName { get; set; }

        [Required]
        [StringLength(10)]
        public string ProcessVersion { get; set; }
    }
}
