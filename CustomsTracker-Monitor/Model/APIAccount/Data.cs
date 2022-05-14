using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIAccount
{
    public class Data
    {
        public string Puuid { get; set; }
        public string Region { get; set; }
        public int Account_Level { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public Card Card { get; set; }

        public string Last_Update { get; set; }
    }
}
