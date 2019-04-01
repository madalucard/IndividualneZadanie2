using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Statistic
    {
        public int id { get; set; }
        public int lap { get; set; }
        public TimeSpan time { get; set; } // lap time (4:30) per that one lap
        public TimeSpan overalTime { get; set; } // 
        public DateTime lapTime { get; set; } // lap time in normal format (14:34)

        public Statistic(int lap, TimeSpan time, TimeSpan overalTime,DateTime lapTime, int id)
        {
            this.lap = lap;
            this.time = time;
            this.overalTime = overalTime;
            this.lapTime = lapTime;
            this.id = id;
        }
    }
}
