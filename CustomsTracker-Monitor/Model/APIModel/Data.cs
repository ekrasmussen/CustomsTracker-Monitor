﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Model.APIModel
{
    internal class Data
    {
        public MetaData MetaData { get; set; }
        public Players players { get; set; }
        public Teams teams { get; set; }
        public List<Round> Rounds { get; set; }
        public List<Kill> Kills { get; set; }
    }
}
