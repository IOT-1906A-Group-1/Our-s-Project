﻿using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
 public   class InputLeaveNew:BaseModels
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Day { get; set; }
    }
}
