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
        public async void FetchUserMMRByUsername(string username, string tag, string region)
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

        [Theory(DisplayName = "Fetch Account MMR By PUUID")]
        [InlineData("b6e0fb0e-11d3-574e-91bf-1f614c93a205", "na", "btslover615", "2944")]
        [InlineData("060d7c3a-0888-5936-b4b4-6896b9dfa389", "eu", "Cameron", "345")]
        [InlineData("49e15449-a22e-5c3b-af36-fd39b9f04d2f", "na", "lilac", "bean")]
        [InlineData("d263df73-82c9-5f6a-89b4-d50b03f0a195", "eu", "TGH", "FiFi")]
        [InlineData("52262635-d9df-516d-922e-231b014016f6", "eu", "WHO Davud", "noi")]
        [InlineData("3db68e59-cdf6-5057-a020-d0927e03d5a7", "ap", "yari", "zard")]
        [InlineData("e4c6f6b3-eeae-594c-a6e6-0fcf9e27b0b4", "eu", "Zua", "CHONK")]
        public async void FetchUserMMRByPUUID(string puuid, string region, string username, string tag)
        {
            // Arrange
            MMRAccess access;
            MMRResponse response;

            // Act
            access = new MMRAccess();
            response = await access.GetRankByPUUID(puuid, region);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(username, response.Data.Name);
            Assert.Equal(tag, response.Data.Tag);
        }
    }
}
