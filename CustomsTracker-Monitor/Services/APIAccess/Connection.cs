using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Services.APIAccess
{
    internal abstract class Connection
    {
        const string baseurl = "api.henrikdev.xyz/";
        
        readonly HttpClient client;
        readonly JsonSerializer serializer;
    }
}
