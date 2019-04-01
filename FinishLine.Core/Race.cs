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

        public Race(List<Runner> winners, int lapDistance, int lapNumber, int winnersCount)
        {
            this.winners = winners;
            LapDistance = lapDistance;
            LapNumber = lapNumber;
            WinnersCount = winnersCount;
        }
    }
}
