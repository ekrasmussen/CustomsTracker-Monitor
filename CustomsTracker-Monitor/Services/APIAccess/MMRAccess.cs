using CustomsTracker_Monitor.Model.APIMMR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Services.APIAccess
{
    public class MMRAccess : Connection
    {
        public async Task<MMRResponse> GetRankByUsername(string username, string tag, string region)
        {
            MMRResponse response = await GetFromAPI<MMRResponse>($"/valorant/v1/mmr/{region}/{username}/{tag}");
            return response;
        }

        public async Task<MMRResponse> GetRankByPUUID(string puuid, string region)
        {
            MMRResponse response = await GetFromAPI<MMRResponse>($"valorant/v1/by-puuid/mmr/{region}/{puuid}");
            return response;
        }
    }
}
