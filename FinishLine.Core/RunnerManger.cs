using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerManger
    {
        List<Runner> _dbRunners = new List<Runner>();

        public void PopulateDB()
        {
            _dbRunners.Add(new Runner(28, "Martin", "Lapihuska", "Slovakia", 25, true));
            _dbRunners.Add(new Runner(206, "Jakub", "Lapihuska", "Slovakia", 22, true));
            _dbRunners.Add(new Runner(75, "Martin", "Bielik", "Slovakia", 24, true));
            _dbRunners.Add(new Runner(2, "Andrej", "Balaz", "Slovakia", 30, true));
            _dbRunners.Add(new Runner(7, "James", "Bond", "Slovakia", 35, true));
            _dbRunners.Add(new Runner(5, "John", "Doe", "Slovakia", 35, true));
            _dbRunners.Add(new Runner(666, "Bruce", "Wayne", "Slovakia", 35, true));
            _dbRunners.Add(new Runner(15, "Clark", "Kent", "Slovakia", 35, true));
            _dbRunners.Add(new Runner(1, "Ragnar", "Lothbrock", "Slovakia", 35, true));
        }

        public List<Runner> GetRunnerDb()
        {
            return _dbRunners;
            
        }

        public void RunnerAdd(int id, string firstName, string lastName, string country, int age, bool isMale)
        {
            _dbRunners.Add(new Runner(id, firstName, lastName, country, age, isMale));
        }
        public void RunnerDelete(int id)
        {
            foreach (var r in _dbRunners)
            {
                if (r.Id == id)
                {
                    _dbRunners.RemoveAt(id);
                }
            }
        }

        public bool IsIdEmpty(int id)
        {
            foreach (var r in _dbRunners)
            {
                if (r.Id == id)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
