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
        /// 招聘计划
        /// </summary>
        /// <param name="models"></param>
        [HttpPost]
        [Route("api/StartPlan")]
        public int StartPlan(BPMPlanModels models)
        {
            var plan = CollectionToSqlXml<PlanModels>(models.PlanData);
            var info = CollectionToSqlXml<InfoModels>(models.PlanInfoDetail);
            StartProccess(plan + info, models);
            return 1;
        }
    }
}
