using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    internal class APIResponse
    {
        public int Status { get; set; }
        public Data data { get; set; }
    }
}
