using Domain.InputModels;
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
    /// <summary>
    /// 固定资产管理
    /// </summary>
    [ApiController]
    public class AssetsController : BaseController
    {
        public AssetsController(IConfiguration configuration) : base(configuration)
        {
          
        }
        /// <summary>
        /// 固定资产申请流程
        /// </summary>
        /// <param name="inputAsset"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartAsset")]
        public int StartAsset(InputAsset inputAsset)
        {
            var xml = CollectionToSqlXml<AssetModel>(inputAsset.AssetData);
            StartProccess(xml, inputAsset);
            return 1;
        }
    }
}
