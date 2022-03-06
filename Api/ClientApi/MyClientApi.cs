
using bpmdemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Api
{
    public class MyClientApi
    {
        public static async Task<string> OptClientApi(string webapiUrl, BPMModels models)
        {
            var httpResponseMsg = new HttpResponseMessage();

            using (var httpClient = new HttpClient())
            {
                httpResponseMsg = await httpClient.PostAsync<BPMModels>(webapiUrl, models, new JsonMediaTypeFormatter());
            }
            var result = httpResponseMsg.Content.ReadAsAsync<string>().Result;
            return result;
        }
    }
}
