using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model
{
    internal class PlayerScore
    {
        public string Name { get; set; }
        public int? Score { get; set; }
        public string Rank { get; set; }
        public int? Kills { get; set; }
        public int? Deaths { get; set; }
        public int? Assists { get; set; }
    }
}
