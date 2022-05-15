using CustomsTracker_Monitor.Model.APIMMR;
using CustomsTracker_Monitor.Services.APIAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomsTracker_Tests
{
    public class FetchMMR
    {
        [Theory (DisplayName = "Fetch Account MMR By Username")]
        [InlineData("btslover615", "2944", "na")]
        [InlineData("Zua", "CHONK", "eu")]
        [InlineData("yari", "zard", "ap")]
        [InlineData("Cameron", "345", "eu")]
        [InlineData("lilac", "bean", "na")]
        [InlineData("WHO Davud", "noi", "eu")]
        [InlineData("TGH", "FiFi", "eu")]
        public async void FetchUserMMR(string username, string tag, string region)
        {
            // Arrange
            MMRAccess access;
            MMRResponse response;

            // Act
            access = new MMRAccess();
            response = await access.GetRankByUsername(username, tag, region);
            
            // Assert
            Assert.NotNull(response);
            Assert.Equal(username, response.Data.Name);
            Assert.Equal(tag, response.Data.Tag);
        }
    }
}
