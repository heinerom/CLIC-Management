using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class Report
    {
        public int Received { get; set; }
        public int Claimed { get; set; }
        public int ClaimedDesk { get; set; }
        public int ClaimedLap { get; set; }
        public int Unclaimed { get; set; }
        public int UnclaimedDesk { get; set; }
        public int UnclaimedLap { get; set; }
        public int Denied { get; set; }

        public Report()
        {
            Received = -1;
            Claimed = -1;
            Unclaimed = -1;
            ClaimedDesk = -1;
            ClaimedLap = -1;
            UnclaimedDesk = -1;
            UnclaimedLap = -1;
            Denied = -1;
        }

    }
}
