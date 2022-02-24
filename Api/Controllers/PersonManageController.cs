using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    public class PersonManageController : BaseController
    {
        public PersonManageController(IConfiguration configuration) : base(configuration)
        {
           
        }
        /// <summary>
        /// 请假
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/stratBPM")]
        public int stratBPM(InputLeaveNew leaveNew)
        {
            StartProccess<InputLeaveNew>(leaveNew);
            return 1;
        }
        /// <summary>
        /// 员工录用
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost,Route("api/startemploy")]
        public void StartEmploy(InputEmploy inputEmploy)
        {
            StartProccess<InputEmploy>(inputEmploy);
        }
        /// <summary>
        /// 人力资源需求
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartHR")]
        public int StartHR(InputHRModel leaveNew)
        {
            StartProccess(leaveNew);
            return 1;
        }

        /// <summary>
        /// 员工离职
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost, Route("api/startDepartur")]
        public void StartDeparture(InputDeparture inputDeparture)
        {
            StartProccess<InputDeparture>(inputDeparture);
        }
    }
}
