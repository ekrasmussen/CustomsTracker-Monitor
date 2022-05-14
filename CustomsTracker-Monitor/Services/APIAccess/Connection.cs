using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Services.APIAccess
{
    public abstract class Connection
    {
        const string baseurl = "api.henrikdev.xyz/";
        
        readonly HttpClient client;
        readonly JsonSerializer serializer;

        protected Connection()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri("https://" + baseurl);

            serializer = new JsonSerializer();
        }

        protected async Task<GetResult> GetFromAPI<GetResult>(string path)
        {
            var response = await client.GetAsync(path);

            if(response.IsSuccessStatusCode)
            {
                using(var stream = await response.Content.ReadAsStreamAsync())
                using(var sr = new StreamReader(stream))
                using(var textReader = new JsonTextReader(sr))
                {
                    return serializer.Deserialize<GetResult>(textReader);
                }
            }

            return default;
        }
    }
}
