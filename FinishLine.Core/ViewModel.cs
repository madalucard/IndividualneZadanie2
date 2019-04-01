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

                
        public void AddRunner()
        {
            // if runers id was setted -1  for will looks for lowest free/not used id and sets it and break for loop
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
