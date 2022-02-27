﻿using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        /// 员工离职
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost, Route("api/startDepartur")]
        public int StartDeparture(DepartureModel departureModel)
            StartProccess<InputLeaveNew>(leaveNew);
            var xml = CollectionToSqlXml<Departure>(departureModel.Departure);
            StartProccess(xml, departureModel);
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
        /// <summary>
        /// 招聘计划
        /// </summary>
        /// <param name="models"></param>
        [HttpPost]
        [Route("api/StartPlan")]
        public void StartPlan(InputPlanModels models)
        {
            StartProccess<InputPlanModels>(models);
        }
    }
}
