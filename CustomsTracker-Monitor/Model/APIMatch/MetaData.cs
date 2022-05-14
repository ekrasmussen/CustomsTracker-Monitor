using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class MetaData
    {
        public string Map { get; set; }
        public string Game_Version { get; set; }
        public int Game_Length { get; set; }
        public int Game_Start { get; set; }
        public string Game_Start_Patched { get; set; }
        public int Rounds_Played { get; set; }
        public string Mode { get; set; }

        public string Season_ID { get; set; }
        public string Platform { get; set; }
        public string MatchID { get; set; }
        public string Region { get; set; }
        public string Cluster { get; set; }

    }
}
