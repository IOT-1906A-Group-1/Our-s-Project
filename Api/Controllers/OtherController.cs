using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    /// <summary>
    /// 功能性方法控制器
    /// </summary>
    [ApiController]
    public class OtherController : ControllerBase
    {
        static string fileName;//文件名称
        static string filePath;//文件路径
        static string fileSuffix;//文件后缀名
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
                var fileDir = path + "\\Files";
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
    }
}
