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
    /// 刻章管理
    /// </summary>
    [ApiController]
    public class ChapterController : BaseController
    {
        public ChapterController(IConfiguration configuration) : base(configuration)
        {

        }
        /// <summary>
        /// 用章申请
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/StartChapter")]
        public int StartChapter(BPMChapterModels models)
        {
            var UseChapter = CollectionToSqlXml<ChapterModels>(models.ChapterData);
            StartProccess(UseChapter, models);
            return 1;
        }
    }
}
