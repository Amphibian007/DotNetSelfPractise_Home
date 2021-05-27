using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractise
{
    public class ShootsFiredEventArgs:EventArgs
    {
        public DateTime TimeOfKill { get; set; }
        public ShootsFiredEventArgs()
        {

        }
        public ShootsFiredEventArgs(DateTime time)
        {
            this.TimeOfKill = time;
        }
    }
}
