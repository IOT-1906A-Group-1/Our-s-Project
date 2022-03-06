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
        /// <summary>
        /// 固定资产借用流程
        /// </summary>
        /// <param name="assetborrow"></param>
        /// 
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartAssetborrow")]
        public int StartAssetborrow(InputAssetborrow assetborrow)
        {
            var xml = CollectionToSqlXml<AssetborrowModel>(assetborrow.AssetborrowData);
            StartProccess(xml, assetborrow);
            return 1;
        }
        /// <summary>
        /// 固定资产交接
        /// </summary>
        /// <param name="assetconnect"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartAssetconnect")]
        public int StartAssetconnect(InputAssetconnect assetconnect)
        {
            var xml = CollectionToSqlXml<AssetconnectModel>(assetconnect.AssetconnectData);
            StartProccess(xml, assetconnect);
            return 1;
        }
        [HttpPost]
        [Route("api/StartAssetAp")]
        public int StartAssetAp(InputAssetApModel inputAssetAp)
        {
            var xml = CollectionToSqlXml<AssetFdModel>(inputAssetAp.AssetFoundation);
            var xmls = CollectionToSqlXml<AssetDtModel>(inputAssetAp.AssetDetailed);
            var xmla = CollectionToSqlXml<AssetDaModel>(inputAssetAp.AssetAnnex);
            StartProccess(xml+xmls+xmla,inputAssetAp);
            return 1;
        }

    }
}
