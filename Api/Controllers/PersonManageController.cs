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
        /// 请假
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/stratLeave")]
        public int stratLeave(BPMLeaveModels leave)
        {
            var xml = CollectionToSqlXml<Leave>(leave.LeaveData);
            StartProccess(xml, leave);
            return 1;
        }
        /// <summary>
        /// 招聘计划
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
        /// <summary>
        /// 员工录用
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost, Route("api/startemploy")]
        public int StartEmploy(InputEmployAll inputEmployAll)
        {
            //string a = inputEmployAll.EmployData.Replace("\\", "");
            //string b = inputEmployAll.EmployeeDetail.Replace("\\", "");
            var xml = CollectionToSqlXml<Employ>(inputEmployAll.EmployData);
            var xml1 = CollectionToSqlXml<Employee>(inputEmployAll.EmployeeDetail);
            StartProccess(xml + xml1, inputEmployAll);
            return 1;
        }
    }
}
