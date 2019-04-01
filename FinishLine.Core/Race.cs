using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Race
    {
        List<Runner> _winners = new List<Runner>();
        public float LapDistance { get; set; }
        public int LapNumber { get; set; }
        public int WinnersCount { get; set; }
        public List<Statistic> _stats = new List<Statistic>();
        public Dictionary<int, Runner> _dbRunners = new Dictionary<int, Runner>();

        public Race(float lapDistance, int lapNumber, int winnersCount, Dictionary<int, Runner> dbRunners)
        {
            LapDistance = lapDistance;
            LapNumber = lapNumber;
            WinnersCount = winnersCount;
            _dbRunners = dbRunners;
        }

    }
}
