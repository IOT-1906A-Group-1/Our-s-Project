using Domain.InputModels;
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
    /// <summary>
    /// 接待管理
    /// </summary>
    [ApiController]
    public class ReceptionController : BaseController
    {
        public ReceptionController(IConfiguration configuration) : base(configuration)
        {

        }
        /// <summary>
        /// 接待申请表
        /// </summary>
        /// <param name="Reception"></param>
        [HttpPost]
        [Route("api/StartReception")]
        public int StartReception(BPMReception models)
        {
            var plan = CollectionToSqlXml<Reception>(models.Reception);
            var info = CollectionToSqlXml<Receptions>(models.Receptions);
            var ccc = CollectionToSqlXml<Receptionplus>(models.Receptionplus);
            StartProccess(plan + info + ccc, models);
            return 1;
        }
    }
}
