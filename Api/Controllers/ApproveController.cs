using Domain.InputModels;
using Domain.OutPutModels;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class ApproveController : BaseController
    {
        public IServiceDB service;
        public ApproveController(IConfiguration configuration, IServiceDB service) : base(configuration)
        {
            this.service = service;
        }
        /// <summary>
        /// 获取当前账号拥有的流程
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetCurrentProcess")]
        public ActionResult GetCurrentProcess(string account)
        {
            var list = (from a in service.QueryInstTasks()
                        join b in service.QueryInstProcSteps() on a.TaskID equals b.TaskID
                        where a.State == "Running   " && b.FinishAt is null && b.OwnerAccount == account
                        select new OutPutOwnerProcess
                        {
                            key = a.TaskID,
                            SerialNum = a.SerialNum,
                            ProcessName = a.ProcessName,
                            OwnerAccount = a.OwnerAccount,
                            CreateAt = a.CreateAt,
                            NodeName = b.NodeName,
                            TaskID = a.TaskID,
                            StepID = b.StepID,
                            NodeOwnerAccount = b.OwnerAccount,
                        }).ToList();
            return Ok(list);
        }
        [HttpGet, Route("GetProcessInfo")]
        public ActionResult GetProcessInfo(string process,int taskId)
        {
            if (process=="Leave")
            {
                return Ok(service.QueryLeave().FirstOrDefault(x=>x.taskId==taskId));
            }
            else if(process == "Employ")
            {
                return Ok(service.QueryEmploy().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if(process== "departure")
            {
                return Ok(service.QuerDeparture().FirstOrDefault(x => x.TaskId == taskId));
            }
            return Ok(null);
        }
        /// <summary>
        /// 审批流程
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/approveLeave")]
        public int approveLeave(ApproveBPMModels model)
        {
            ApproveProccess(model);
            return 1;
        }
    }
}
