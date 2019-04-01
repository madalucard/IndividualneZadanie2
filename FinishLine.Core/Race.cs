using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    class Race
    {
        List<Runner> winners = new List<Runner>();
        public int LapDistance { get; set; }
        public int LapNumber { get; set; }
        public int WinnersCount { get; set; }

        
    }
}
