using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class Assets
    {
        public Card card { get; set; }
        public Agent agent { get; set; }
        public string Display_Icon { get; set; }
        public string Killfeed_Icon { get; set; }

    }
}
