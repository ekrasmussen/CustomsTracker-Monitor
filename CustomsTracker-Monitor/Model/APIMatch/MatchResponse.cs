using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    public class MatchResponse
    {
        public int Status { get; set; }
        public List<Data> data { get; set; }
    }
}
