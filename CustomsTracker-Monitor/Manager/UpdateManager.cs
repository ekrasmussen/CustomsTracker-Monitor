using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomsTracker_Monitor.Manager
{
    internal class UpdateManager
    {
        public int Interval { get; set; }
        // Add private controllers

        public UpdateManager(int interval, CancellationToken token)
        {
            Interval = interval;
            Task.Run(() => StartTimer(token));
        }

        async Task StartTimer(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                await OnTick(token);
                await Task.Delay(Interval);
            }
        }

        async Task OnTick(CancellationToken token)
        {
            // Do the Database Stuff here every tick
        }
    }


}
