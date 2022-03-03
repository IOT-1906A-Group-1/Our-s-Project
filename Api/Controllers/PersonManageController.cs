using Api;
using bpmdemoapi.models;
using Domain.InputModels;
using IService;
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
    /// <summary>
    /// 人事管理
    /// </summary>
    [ApiController] 
    public class PersonManageController : BaseController
    {
        public IServiceDB service;
        public PersonManageController(IConfiguration configuration, IServiceDB service) : base(configuration)
        {
            this.service = service;
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
        /// <summary>
        /// 员工录用
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost, Route("api/startemploy")]
        public int StartEmploy(InputEmployAll inputEmployAll)
        {
            var employ = CollectionToSqlXml<Employ>(inputEmployAll.EmployData);
            var employee = CollectionToSqlXml<Employee>(inputEmployAll.EmployeeDetail);
            StartProccess(employ + employee, inputEmployAll);
            return 1;
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
        /// <summary>
        /// 获取用户部门
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("GetUsersRole")]
        public ActionResult GetUsersRole(string name)
        {
            var objMember = service.QueryOUMembers().FirstOrDefault(x => x.UserAccount == name);
            var memberOus = service.QueryOUs().FirstOrDefault(x => x.Ouid == objMember.Ouid);
            return Ok(memberOus.OUName);
        }
    }
}
