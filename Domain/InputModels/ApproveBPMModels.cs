using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InputModels
{
    public class ApproveBPMModels:BaseModels
    {
        public int TaskID { get; set; }
        public int StepId { get; set; }
        public string Comments { get; set; }
    }
}
