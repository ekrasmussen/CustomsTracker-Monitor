using CustomsTracker_Monitor.Model;
using CustomsTracker_Monitor.Model.APIAccount;
using CustomsTracker_Monitor.Model.APIMMR;
using CustomsTracker_Monitor.Model.APIModel;
using CustomsTracker_Monitor.Services.APIAccess;
using System.Threading.Tasks;

MatchAccess access = new MatchAccess();
MMRAccess mmraccess = new MMRAccess();
CancellationTokenSource tokenSource = new CancellationTokenSource();
CancellationToken token = tokenSource.Token;

string username = "none";
string tag = "none";
string region = "none";
string previousPUUID = "none";
int startTime = 0;

Console.WriteLine("Type 'help' to see all available commands and get started");

while (true)
{
    string command = Console.ReadLine();

    if (command == "stop")
    {
        tokenSource.Cancel();
        previousPUUID = "none";
    }
    else if (command.Contains("register"))
    {
        Console.Write("User: ");
        string user = Console.ReadLine();
        Console.Write("Tag: ");
        string _tag = Console.ReadLine();
        Console.Write("Region (eu/na/ap): ");
        string _region = Console.ReadLine();

        Console.WriteLine($"Monitoring {user} - {_tag} - {_region}");
        username = user;
        tag = _tag;
        region = _region;
    }
    else if (command == "start")
    {
        Task.Run(() => StartTimer(username, tag, region, token));
    }
    else if (command == "help")
    {
        Console.WriteLine("register:");
        Console.WriteLine("    Register user to start tracking");

        Console.WriteLine();

        Console.WriteLine("start:");
        Console.WriteLine("    Start the tracking (refreshes every minute)");

        Console.WriteLine();

        Console.WriteLine("stop: ");
        Console.WriteLine("    Stops the tracking");

        Console.WriteLine();

        Console.WriteLine("help: ");
        Console.WriteLine("    Displays this page again");
    }
}


async Task StartTimer(string user, string tag, string region, CancellationToken token)
{
    startTime = (int)DateTimeOffset.Now.ToUnixTimeSeconds();
    while (!token.IsCancellationRequested)
    {
        await OnTick(user, tag, region, token);
        await Task.Delay(15000);
    }
}

async Task OnTick(string user, string tag, string region, CancellationToken token)
{
    List<PlayerScore> matchResult;
    if (!token.IsCancellationRequested)
    {
        MatchResponse response = await access.GetByUsername(user, tag, region);

        if (response.data[0].Is_Available == true && response.data[0].MetaData.MatchID != previousPUUID && startTime < response.data[0].MetaData.Game_Start)
        {
            matchResult = new List<PlayerScore>();
            Console.WriteLine();
            for (int i = 0; i < response.data[0].players.All_Players.Count; i++)
            {
                PlayerScore player;
                string puuid = response.data[0].players.All_Players[i].Puuid;
                MMRResponse mmr = await mmraccess.GetRankByPUUID(puuid, region);

                player = new PlayerScore
                {
                    Name = response.data[0].players.All_Players[i].Name,
                    Score = response.data[0].players.All_Players[i].Stats.Score,
                    Rank = mmr.Data.CurrentTierPatched,
                    Kills = response.data[0].players.All_Players[i].Stats.Kills,
                    Deaths = response.data[0].players.All_Players[i].Stats.Deaths,
                    Assists = response.data[0].players.All_Players[i].Stats.Assists
                };
                matchResult.Add(player);
                //PrintRank(response.data[0].players.All_Players[i].Name, mmr.Data.CurrentTierPatched);
            }

            previousPUUID = response.data[0].MetaData.MatchID;
            PrintMatch(matchResult);
            Console.WriteLine("----------------------------------------------------------------------------");
        }


    }
}

void PrintMatch(List<PlayerScore> scores)
{
    List<PlayerScore> sorted = scores.OrderByDescending(s => s.Score).ToList();

    for(int i = 0; i < sorted.Count; i++)
    {
        PrintRank(i + 1, sorted[i]);
    }
}

void PrintRank(int position, PlayerScore score)
{
    if (score.Rank == String.Empty || score.Rank == null)
    {
        score.Rank = "Unrated";
    }

    if(score.Kills == null)
    {
        score.Kills = 0;
    }

    if (score.Deaths == null)
    {
        score.Deaths = 0;
    }

    if (score.Assists == null)
    {
        score.Assists = 0;
    }

    string kda = $"{score.Kills}/{score.Deaths}/{score.Assists}";
    string formattedKDA = $"{kda,-9}";

    string formattedPosition = $"{position}.";
    string positionformat = $"{formattedPosition,-4}";
    string userformat = $"{score.Name,-20}";
    string rankformat = $"{score.Rank, -14}";
    rankformat = $"{rankformat,14}";

    Console.Write(positionformat + userformat + "-");
    if (score.Rank.Contains("Iron"))
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    if (score.Rank.Contains("Silver"))
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    if (score.Rank.Contains("Gold"))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    if (score.Rank.Contains("Platinum"))
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    if (score.Rank.Contains("Diamond"))
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
    if (score.Rank.Contains("Immortal"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    if (score.Rank.Contains("Radiant"))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    if (score.Rank.Contains("Unrated"))
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.Write("        " + rankformat, Console.ForegroundColor);
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write($"-        {formattedKDA}");
    Console.WriteLine();
}