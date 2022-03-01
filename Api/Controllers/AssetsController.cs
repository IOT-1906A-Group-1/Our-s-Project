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
    /// 固定资产管理
    /// </summary>
    [ApiController]
    public class AssetsController : BaseController
    {
        public AssetsController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
