using BPMAPI.OtherApi;
using bpmdemoapi.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

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
        /// 获取table
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected  DataSet GetDataSet(Object data)
        {
            Type type = data.GetType();
            DataSet formDataSet = new DataSet("FormData");

            DataTable table = new DataTable(type.Name.Replace("Input",""));
            string IsNotField = "Action,BPMUser,BPMUserPass,FullName,ProcessName";
            foreach (var property in type.GetProperties())
            {
                if (!IsNotField.Contains(property.Name))
                    table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
            }
            DataRow add_row = table.NewRow();
            foreach (var property in type.GetProperties())
            {
                if (!IsNotField.Contains(property.Name))
                    add_row[property.Name] = property.GetValue(data);
            }
            table.Rows.Add(add_row);
            formDataSet.Tables.Add(table);
            return formDataSet;
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
