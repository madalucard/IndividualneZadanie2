using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class ViewModel
    {
        RunnerManger _rm = new RunnerManger();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public bool IsMale { get; set; }

        public void AddRunner()
        {
            _rm.RunnerAdd(Id, FirstName, LastName, Country, Age, IsMale);
        }
        public List<Runner> GetRunnersDb()
        {
            return _rm.GetRunnerDb();
        }


    }
}
