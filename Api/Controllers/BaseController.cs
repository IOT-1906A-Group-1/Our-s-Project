using Domain;
using Domain.InputModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Api.Controllers
{
   
    public class BaseController: ControllerBase
    {
        protected  DataSet dataSet = new DataSet("FormData");
        private const string IsNotField = "Action,BPMUser,BPMUserPass,FullName,ProcessName,Detail";
        private IConfiguration configuration;
        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected string CollectionToSqlXml<T>(string json) where T:class,new()
        {
            List<T> TCollection;
            if (json.IndexOf("[{") > 0)
            {
                TCollection = JsonConvert.DeserializeObject<List<T>>(json);
            }
            
            else
            {
                TCollection = JsonConvert.DeserializeObject<List<T>>("[" + json + "]");
            }

            //先把集合转换成数据表，然后把数据表转换成SQLXML
            return  DataTableToSqlXml(CollectionToDataTable(TCollection)).Value.Replace("<DocumentElement>", "").Replace("</DocumentElement>", "");
            
        }
        private DataTable CollectionToDataTable<T>(List<T> TCollection)
        {
            //获取泛型的具体类型
            Type type = typeof(T);
            //获取类型的公共属性
            PropertyInfo[] properties = type.GetProperties();
            //创建数据表，表名为类型名称
            DataTable table = new DataTable(type.Name);
            //把公共属性转行成表格列，再把表格列添加到表格中
            foreach (var property in properties)
            {
                //创建一个表格列，列名为属性名，列数据类型为属性的类型
                DataColumn column = new DataColumn(property.Name, property.PropertyType);
                //把表格列添加到表格中
                table.Columns.Add(column);
            }
            //把泛型集合元素添加到数据行中
            foreach (var item in TCollection)
            {
                //创建和表格行架构相同的表格行
                DataRow row = table.NewRow();
                //读取元素所有属性列的值，并根据属性名称，把属性值添加到表格行中
                foreach (var property in properties)
                    row[property.Name] = property.GetValue(item, null);
                //把表格行添加到表格中
                table.Rows.Add(row);
            }
            return table;
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
        ///// <summary>
        ///// 获取table
        ///// </summary>
        ///// <param name="data"></param>
        ///// <returns></returns>
        //private static DataSet GetDataSet(Object data)
        //{
        //    Type type = data.GetType();

        //    DataSet formDataSet = new DataSet("FormData");

        //    DataTable table = new DataTable(type.Name);
        //    string IsNotField = "Action,BPMUser,BPMUserPass,FullName,ProcessName";
        //    foreach (var property in type.GetProperties())
        //    {

        //        if (!IsNotField.Contains(property.Name))
        //            table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
        //    }
        //    DataRow add_row = table.NewRow();
        //    foreach (var property in type.GetProperties())
        //    {
        //        if (!IsNotField.Contains(property.Name))
        //            add_row[property.Name] = property.GetValue(data);
        //    }
        //    table.Rows.Add(add_row);
        //    formDataSet.Tables.Add(table);
        //    return formDataSet;
        //}

       
        protected Task<string> StartProccess(string formDataSet, BaseModels baseModels) 
        {
            BPMModels models = new BPMModels(configuration)
            {
                Action = baseModels.Action,

                BPMUser = baseModels.BPMUser,
                BPMUserPass = baseModels.BPMUserPass,
                FormDataSet = "<FormData>"+formDataSet+ "</FormData>",
                FullName = baseModels.FullName,
                ProcessName = baseModels.ProcessName
            };
            return MyClientApi.OptClientApi(models.BpmServerUrl, models);
        }
        protected Task<string> ApproveProccess(ApproveBPMModels baseModels)
        {
            BPMModels models = new BPMModels(configuration)
            {
                TaskID = baseModels.TaskID,
                StepId = baseModels.StepId,
                Comments = baseModels.Comments,
                Action = baseModels.Action,
                BPMUser = baseModels.BPMUser,
                BPMUserPass = baseModels.BPMUserPass,
                FullName = baseModels.FullName,
                ProcessName = baseModels.ProcessName
            };
            return MyClientApi.OptClientApi(models.ApproveServerUrl, models);
        }
    }
}
