using Xunit;
using CustomsTracker_Monitor.Services.APIAccess;
using CustomsTracker_Monitor.Model.APIModel;

namespace CustomsTracker_Tests
{
    public class FetchMatches
    {
        [Theory(DisplayName = "Fetch Past 5 Matches from API With Username")]
        [InlineData("btslover615", "2944", "na")]
        [InlineData("Zua", "CHONK", "eu")]
        [InlineData("yari","zard","ap")]
        [InlineData("Cameron","345","eu")]
        [InlineData("lilac", "bean", "na")]
        [InlineData("WHO Davud", "noi", "eu")]
        [InlineData("TGH", "FiFi", "eu")]
        public async void FetchPastMatchesByUsername(string username, string tag, string region)
        {
            // Arrange
            MatchAccess access;
            MatchResponse response;
            
            //Act
            access = new MatchAccess();

            response = await access.GetByUsername(username, tag, region);

            //Assert

            Assert.NotNull(response);
            Assert.Equal(5, response.data.Count);
        }

        [Theory(DisplayName = "Fetch Past 5 Matches from API with PUUID")]
        [InlineData("b6e0fb0e-11d3-574e-91bf-1f614c93a205", "na")]
        [InlineData("060d7c3a-0888-5936-b4b4-6896b9dfa389", "eu")]
        [InlineData("49e15449-a22e-5c3b-af36-fd39b9f04d2f", "na")]
        [InlineData("d263df73-82c9-5f6a-89b4-d50b03f0a195", "eu")]
        [InlineData("52262635-d9df-516d-922e-231b014016f6", "eu")]
        [InlineData("3db68e59-cdf6-5057-a020-d0927e03d5a7", "ap")]
        [InlineData("e4c6f6b3-eeae-594c-a6e6-0fcf9e27b0b4", "eu")]
        public async void FetchPastMatchesByPUUID(string puuid, string region)
        {
            // Arrange
            MatchAccess access;
            MatchResponse response;

            //Act
            access = new MatchAccess();

            response = await access.GetByPUUID(puuid, region);

            //Assert

            Assert.NotNull(response);
            Assert.Equal(5, response.data.Count);
        }
    }
}