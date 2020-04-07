using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EorzeanFisher.Services.Http
{
    public class HttpService : IHttpService
    {

        public async Task<object> GetDataAsync(string url)
        {
            HttpResponseMessage req = await url.GetAsync();
            object item = JsonConvert.DeserializeObject(req.Content.ReadAsStringAsync().Result);
            return item;
        }
    }
}
