using Domain.InputModels;
using IService;
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
    public class ApproveController : BaseController
    {
        public IServiceDB service;
        public ApproveController(IConfiguration configuration, IServiceDB service) : base(configuration)
        {
            this.service = service;
        }
    }
}
