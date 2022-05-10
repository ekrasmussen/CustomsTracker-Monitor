using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Economy
    {
        public Spent Spent { get; set; }
        public LoadoutValue Loadout_Value { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public int Remaining { get; set; }
    }
}
