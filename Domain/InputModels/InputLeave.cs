using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class InputLeave
    {
        public int Id { get; set; }
        public int taskId { get; set; }
        public string applyPeople { get; set; }
        public string applyDepartment { get; set; }
        public string applyDate { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string leaveType { get; set; }
        public string leaveDays { get; set; }
        public string leaveReason { get; set; }
        public string FileName { get; set; }
        public string Remarks { get; set; }
    }
}
