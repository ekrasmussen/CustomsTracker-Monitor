using CustomsTracker_Monitor.Model.APIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Services.APIAccess
{
    public class MatchAccess : Connection
    {
        public async Task<MatchResponse> GetAll(string username, string tag, string region)
        {
            MatchResponse matches = await GetFromAPI<MatchResponse>($"valorant/v3/matches/{region}/{username}/{tag}");

            return matches;
        }
    }
}
