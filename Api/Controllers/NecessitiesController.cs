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
    /// 日用品管理
    /// </summary>
    [ApiController]
    public class NecessitiesController : BaseController
    {
        public NecessitiesController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
