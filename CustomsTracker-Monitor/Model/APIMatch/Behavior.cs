using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Behavior
    {
        public int AFK_Rounds { get; set; }
        public FriendlyFire Friendly_Fire { get; set; }
        public int Rounds_In_Spawn { get; set; }
    }
}
