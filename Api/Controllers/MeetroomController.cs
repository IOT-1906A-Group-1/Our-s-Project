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
    /// 会议室管理
    /// </summary>
    [ApiController]
    public class MeetroomController : BaseController
    {
        public MeetroomController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
