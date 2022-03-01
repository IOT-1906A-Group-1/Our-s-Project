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
    /// 车辆管理
    /// </summary>
    [ApiController]
    public class CarController : BaseController
    {
        public CarController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
