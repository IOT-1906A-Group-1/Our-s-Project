using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    /// <summary>
    /// 日用品总结
    /// </summary>
    [ApiController]
    public class ProcurementController : ControllerBase
    {
        //连接服务
        private readonly IServiceDB db;
        public ProcurementController(IServiceDB db)
        {
            this.db = db;
        }

        /// <summary>
        /// 日用品显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/ProcurementShow")]
        public ActionResult Procurement()
        {
            return Ok(db.QueryProcurement());
        }
    }
}
