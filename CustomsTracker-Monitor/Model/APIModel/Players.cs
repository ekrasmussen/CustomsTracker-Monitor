using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    internal class Players
    {
        public List<AllPlayer> All_Players { get; set; }
        public List<Red> Red { get; set; }
        public List<Blue> Blue { get; set; }
    }
}
