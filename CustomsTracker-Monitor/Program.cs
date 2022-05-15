using CustomsTracker_Monitor.Model.APIAccount;
using CustomsTracker_Monitor.Model.APIModel;
using CustomsTracker_Monitor.Services.APIAccess;
using System.Threading.Tasks;

MatchAccess access = new MatchAccess();
AccountAccess accountAccess = new AccountAccess();


AccountResponse response = await accountAccess.GetAccountByUsername("Zua", "CHONK");

Console.WriteLine(response.Data.Puuid);