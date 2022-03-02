using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.InputModels;
using Model;

namespace Api.Controllers
{
    /// <summary>
    /// 日用品管理
    /// </summary>
    [ApiController]
    public class NecessitiesController : BaseController
    {
        public NecessitiesController(IConfiguration configuration) : base(configuration)
        {
           
        }
        /// <summary>
        /// 日常用品采购
        /// </summary>
        /// <param name="InputProcurement"></param>
        [HttpPost]
        [Route("api/StarProcurement")]
        public int StarProcurement(BPMProcurementModel models)
        {
            var plan = CollectionToSqlXml<Procurement>(models.Procurement);
            var info = CollectionToSqlXml<ProcurementPlus>(models.ProcurementPlus);
            StartProccess(plan + info,models);
            return 1;
        }
    }
}
