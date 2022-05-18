using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIMMR
{
    public class Data
    {
        public int? CurrentTier { get; set; }
        public string CurrentTierPatched { get; set; }
        public int? Ranking_In_Tier { get; set; }
        public int? MMR_Change_To_Last_Game { get; set; }
        public int? Elo { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

    }
}
