using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    }
}
