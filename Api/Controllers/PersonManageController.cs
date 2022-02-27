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
        /// 人力资源需求
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartHR")]
        public int StartHR(BPMHRModels leaveNew)
        {
            var xml = CollectionToSqlXml<HRModel>(leaveNew.HRdata);
            StartProccess(xml, leaveNew);
            return 1;
        }

    }
}
