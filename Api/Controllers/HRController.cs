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
    public class HRController : BaseController
    {
        public HRController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
