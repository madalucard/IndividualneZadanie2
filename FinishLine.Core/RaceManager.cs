using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RaceManager
    {
        //public Race RaceEvent { get; set; }
        public DateTime Start { get { return DateTime.Now; } private set { } }

        
        /// <summary>
        /// Sets starting time
        /// </summary>
        public void StartRace()
        {
            Start = DateTime.Now;
        }



        public TimeSpan DoLap(int id)
        {
            var timeElapsed = DateTime.Now - Start;
            // race._stats.Where(x => x.id == id).Count()

            int lapCount = 1;
            Statistic lastStatistic = null;
            foreach (var item in Race._stats)
            {
                if (item.id == id)
                {
                    lapCount++;
                    lastStatistic = item;
                }
            }

            TimeSpan asdf = new TimeSpan();
            if (lastStatistic != null)
            {
                asdf = DateTime.Now - lastStatistic.lapTime;
            }
            else
            {
                asdf = DateTime.Now - Start;
            }


            Race._stats.Add(new Statistic(lapCount, asdf, timeElapsed, DateTime.Now, id));

            // return also lap count
            return asdf;
        }
    }
}
