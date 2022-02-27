using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController] 
    public class PersonManageController : BaseController
    {
        static string fileName;//文件名称
        static string filePath;//文件路径
        static string fileSuffix;//文件后缀名
        public PersonManageController(IConfiguration configuration) : base(configuration)
        {
           
        }
        //上传文件
        [HttpPost, Route("FileUpload")]
        public int FileUpload(IFormFile file)
        {
            if (file != null)
            {
                var path = Directory.GetCurrentDirectory();
                int indexDot = file.FileName.IndexOf(".");
                int nameLength = file.FileName.Length;
                var date = DateTime.Now;
                fileSuffix = file.FileName.Substring(indexDot, nameLength - indexDot);
                fileName = file.FileName.Substring(0, indexDot) + "_Time=" + date.Year + date.Month + date.Day + "_GUID=" + Guid.NewGuid().ToString("N");
                var fileDir = path+"\\Files";
                if (!Directory.Exists(fileDir))
                {
                    Directory.CreateDirectory(fileDir);
                }
                //文件名称
                string projectFileName = fileName + fileSuffix;
                filePath = fileDir + $@"\{projectFileName}";
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 请假
        /// </summary>
        /// <param name="leaveNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/stratLeave")]
        public int stratLeave( BPMLeaveModels leave)
        {
            var xml = CollectionToSqlXml<Leave>(leave.LeaveData);
            StartProccess(xml,leave);
            return 1;
        }
    }
}
