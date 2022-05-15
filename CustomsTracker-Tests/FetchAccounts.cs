using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CustomsTracker_Monitor.Services.APIAccess;
using CustomsTracker_Monitor.Model.APIModel;
using CustomsTracker_Monitor.Model.APIAccount;

namespace CustomsTracker_Tests
{
    public class FetchAccounts
    {
        [Theory(DisplayName = "Fetch Account Data")]
        [InlineData("btslover615", "2944")]
        [InlineData("Zua", "CHONK")]
        [InlineData("yari", "zard")]
        [InlineData("Cameron", "345")]
        [InlineData("lilac", "bean")]
        [InlineData("WHO Davud", "noi")]
        [InlineData("TGH", "FiFi")]
        public async void FetchAccountData(string username, string tag)
        {
            AccountAccess access = new AccountAccess();

            AccountResponse response = await access.GetAccountByUsername(username, tag);

            Assert.NotNull(response);
            Assert.Equal(username, response.Data.Name);
        }
    }
}
