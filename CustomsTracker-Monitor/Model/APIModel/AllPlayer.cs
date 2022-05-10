using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    internal class AllPlayer
    {
        public string Puuid { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Team { get; set; }
        public int Level { get; set; }
        public string Character { get; set; }
        public int CurrentTier { get; set; }
        public string CurrentTier_Patched { get; set; }
        public string Player_Card { get; set; }
    }
}
