using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class ViewModel
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public bool IsMale { get; set; }

        public ViewModel()
        {
        }

        public void AddRunner()
        {
            if (Id == -1)
            {
               var asdf =  RunnerManger.GetRunnerDb();
                for (int i = 1; i < 1000; i++)
                {
                    if (!asdf.ContainsKey(i))
                    {
                        Id = i;
                        break;
                    }
                }
            }

            RunnerManger.RunnerAdd(Id, FirstName, LastName, Country, Age, IsMale);
        }
        public Dictionary<int,Runner> GetRunnersDb()
        {
            return RunnerManger.GetRunnerDb();
        }


    }
}
