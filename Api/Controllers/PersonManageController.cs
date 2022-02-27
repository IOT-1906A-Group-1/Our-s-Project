﻿using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    public class PersonManageController : BaseController
    {
        public PersonManageController(IConfiguration configuration) : base(configuration)
        {
           
        }
        /// <summary>
        /// 员工录用
        /// </summary>
        /// <param name="inputEmploy"></param>
        [HttpPost,Route("api/startemploy")]
        public int StartEmploy(InputEmployAll inputEmployAll)
        {
            //string a = inputEmployAll.EmployData.Replace("\\", "");
            //string b = inputEmployAll.EmployeeDetail.Replace("\\", "");
            var xml = CollectionToSqlXml<Employ>(inputEmployAll.EmployData);
            var xml1 = CollectionToSqlXml<Employee>(inputEmployAll.EmployeeDetail);
            StartProccess(xml+xml1, inputEmployAll);
            return 1;
        }
    }
}
