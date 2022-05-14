using Xunit;
using CustomsTracker_Monitor.Services.APIAccess;
using CustomsTracker_Monitor.Model.APIModel;

namespace CustomsTracker_Tests
{
    public class FetchMatches
    {
        [Theory(DisplayName = "Fetch Past 5 Matches from API")]
        [InlineData("btslover615", "2944", "na")]
        [InlineData("Zua", "CHONK", "eu")]
        [InlineData("yari","zard","ap")]
        [InlineData("Cameron","345","eu")]
        [InlineData("lilac", "bean", "na")]
        public async void FetchPastMatches(string username, string tag, string region)
        {
            // Arrange
            MatchAccess access;
            MatchResponse response;
            
            //Act
            access = new MatchAccess();

            response = await access.GetAll(username, tag, region);

            //Assert

            Assert.NotNull(response);
            Assert.Equal(5, response.data.Count);
        }
    }
}