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
    /// 公告管理
    /// </summary>
    [ApiController]
    public class NoticeController : BaseController
    {
        public NoticeController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
