using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class Race
    {
        static List<Runner> _winners = new List<Runner>();
        public static decimal LapDistance { get; set; }
        public static decimal LapNumber { get; set; }
        public static decimal WinnersCount { get; set; }
        public static List<Statistic> _stats = new List<Statistic>();
        public static Dictionary<int, Runner> _dbRunners = new Dictionary<int, Runner>();

        //public Race(decimal lapDistance, decimal lapNumber, decimal winnersCount, Dictionary<int, Runner> dbRunners)
        //{
        //    LapDistance = lapDistance;
        //    LapNumber = lapNumber;
        //    WinnersCount = winnersCount;
        //    _dbRunners = dbRunners;
        //}

    }
}
