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
        /// 员工离职
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost, Route("api/startDepartur")]
        public int StartDeparture(DepartureModel departureModel)
        {
            var xml = CollectionToSqlXml<Departure>(departureModel.Departure);
            StartProccess(xml, departureModel);
            return 1;
        }
      
    }
}
