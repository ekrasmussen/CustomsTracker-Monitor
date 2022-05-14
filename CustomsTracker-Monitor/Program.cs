using CustomsTracker_Monitor.Model.APIModel;
using CustomsTracker_Monitor.Services.APIAccess;
using System.Threading.Tasks;

MatchAccess access = new MatchAccess();

string username = "btslover615";
string tag = "2944";
string region = "na";

MatchResponse matches = await access.GetAll(username, tag, region);

Console.WriteLine(matches.data[0].Is_Available);