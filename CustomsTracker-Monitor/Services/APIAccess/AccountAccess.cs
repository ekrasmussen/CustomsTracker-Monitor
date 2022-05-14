using CustomsTracker_Monitor.Model.APIAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Services.APIAccess
{
    public class AccountAccess : Connection
    {
        public AccountAccess() : base()
        {

        }

        public async Task<AccountResponse> GetAccount(string username, string tag)
        {
            AccountResponse response = await GetFromAPI<AccountResponse>($"valorant/v1/account/{username}/{tag}");

            return response;
        }
    }
}
