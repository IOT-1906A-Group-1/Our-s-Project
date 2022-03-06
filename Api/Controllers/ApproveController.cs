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
            if (process == "Leave")
            {
                return Ok(service.QueryLeave().FirstOrDefault(x => x.taskId == taskId));
            }
            else if (process == "Employ")
            {
                return Ok(service.QueryEmploy().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if(process== "departure")
            {
                return Ok(service.QuerDeparture().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if (process == "HR")
            {
                return Ok(service.QUeryHR().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if (process == "Asset")
            {
                return Ok(service.QUeryAsset().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if (process == "Assetborrow")
            {
                return Ok(service.QueryAssetborrow().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if (process == "Assetconnect")
            {
                return Ok(service.QueryAssetconnect().FirstOrDefault(x => x.TaskId == taskId));
            }
            else if (process == "Acceptance") 
            {
                var list = (from a in service.QUeryAssetDa().ToList() join b in service.QueryAssetDt().ToList() on a.TaskId equals b.TaskId join c in service.QueryAssetFd().ToList() on b.TaskId equals c.TaskId select new OutputAcceptance {
                    Id=b.Id,
                    TaskId=a.TaskId,
                    Fd_Applicant=c.Fd_Applicant,
                    Fd_Department=c.Fd_Department,
                    Fd_Data=c.Fd_Data,
                    Fd_Numbering=c.Fd_Numbering,
                    Fd_Type=c.Fd_Type,
                    Fd_Deposit=c.Fd_Deposit,
                    Fd_Number=c.Fd_Number,
                    Fd_Project=c.Fd_Project,
                    Fd_User=c.Fd_User,
                    Fd_Affiliationdp=c.Fd_Affiliationdp,
                    Dt_Name=b.Dt_Name,
                    Dt_Model=b.Dt_Model,
                    Dt_Num=b.Dt_Num,
                    Dt_Price=b.Dt_Price,
                    Dt_Amount=b.Dt_Amount,
                    Dt_Unit=b.Dt_Unit,
                    Dt_Purchaser=b.Dt_Purchaser,
                    Da_Illustrate=a.Da_Illustrate,
                    Da_Unit=a.Da_Unit,
                    Da_Num=a.Da_Num,
                    Da_Custodian=a.Da_Custodian,
                    Da_Annex=a.Da_Annex,
                    Da_remark=a.Da_remark,
                }).ToList();
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
