using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Domain.InputModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Api.Controllers
{

    [ApiController]
    public class BaseController : ControllerBase
    {
        private IConfiguration configuration;
        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        /// <summary>
        /// 数据表转换成SQLXML
        /// </summary>
        /// <param name="table">数据表</param>
        /// <returns></returns>
        private SqlXml DataTableToSqlXml(DataTable table)
        {
            SqlXml xml;
            //如果表格名为空，则设置表格名
            if (string.IsNullOrEmpty(table.TableName))
                table.TableName = "TableName";
            //把数据表转换成XML
            using (var ms = new MemoryStream())
            {
                //把数据表转换成XML格式，并写入内存流
                table.WriteXml(ms);
                //把内存流读取标记设置回起点
                ms.Position = 0;
                //使用XmlReader读取内存流，并创建一个SqlXml对象
                xml = new SqlXml(XmlReader.Create(ms));
            }
            return xml;
        }
     
        protected Task<int> StartProccess<T>(T leaveNew) where T : BaseModels, new()
        {
            string formDataSet = ConvertXML.ConvertDataSetToXML(GetDataSet(leaveNew));
            BPMModels models = new BPMModels(configuration)
            {
                Action = leaveNew.Action,

                BPMUser = leaveNew.BPMUser,
                BPMUserPass = leaveNew.BPMUserPass,
                FormDataSet = formDataSet,
                FullName = leaveNew.FullName,
                ProcessName = leaveNew.ProcessName
            };
            return MyClientApi.OptClientApi(models.BpmServerUrl, models);
        }
    }
}
