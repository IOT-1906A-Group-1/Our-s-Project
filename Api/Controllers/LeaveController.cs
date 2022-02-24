using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    public class LeaveController : BaseController
    {
        public LeaveController(IConfiguration configuration) : base(configuration)
        {
           
        }
        [HttpPost]
        [Route("api/stratBPM")]
        public int stratBPM(InputLeaveNew leaveNew)
        {
            StartProccess(leaveNew);
            return 1;
        }

        [HttpPost]
        [Route("api/StartPlan")]
        public void StartPlan(InputPlanModels models)
        {
            StartProccess<InputPlanModels>(models);
        }
    }
}
