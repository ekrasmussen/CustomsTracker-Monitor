using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Red
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
        public string Player_Title { get; set; }
        public string Party_ID { get; set; }
        public SessionPlaytime Session_Playtime { get; set; }
        public Behavior Behavior { get; set; }
        public Platform Platform { get; set; }
        public AbilityCasts AbilityCasts { get; set; }
        public Assets Assets { get; set; }
        public Stats Stats { get; set; }
        public Economy Economy { get; set; }
        public int Damage_Made { get; set; }
        public int Damage_Recieved { get; set; }
        public bool? Has_Won { get; set; }
        public int? Rounds_Won { get; set; }
        public int? Rounds_Lost { get; set; }
    }
}
