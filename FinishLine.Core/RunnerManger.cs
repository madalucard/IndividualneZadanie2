using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class RunnerManger
    {
        public static Dictionary<int, Runner> _dbRunners = new Dictionary<int, Runner>();

        public static void PopulateDB()
        {
            //_dbRunners.Add(new Runner(28, "Martin", "Lapihuska", "Slovakia", 25, true));
            //_dbRunners.Add(new Runner(206, "Jakub", "Lapihuska", "Slovakia", 22, true));
            //_dbRunners.Add(new Runner(75, "Martin", "Bielik", "Slovakia", 24, true));
            //_dbRunners.Add(new Runner(2, "Andrej", "Balaz", "Slovakia", 30, true));
            //_dbRunners.Add(new Runner(7, "James", "Bond", "Slovakia", 35, true));
            //_dbRunners.Add(new Runner(55, "John", "Doe", "Slovakia", 35, true));
            //_dbRunners.Add(new Runner(666, "Bruce", "Wayne", "Slovakia", 35, true));
            //_dbRunners.Add(new Runner(15, "Clark", "Kent", "Slovakia", 35, true));
            //_dbRunners.Add(new Runner(1, "Ragnar", "Lothbrock", "Slovakia", 35, true));
        }

        public static Dictionary<int, Runner> GetRunnerDb()
        {
            // test purposes
            _dbRunners.Add(75, new Runner(75, "Martin", "Bielik", "Slovakia", 24, true));

            // TODO if _dbRunners is empty -> load from file
            return _dbRunners;
        }

        public static void RunnerAdd(int id, string firstName, string lastName, string country, int age, bool isMale)
        {
            // TODO save new runner to text file with method
            _dbRunners.Add(id ,new Runner(id, firstName, lastName, country, age, isMale));
        }

        /// <summary>
        ///  Delete Runner from DB by id
        /// </summary>
        /// <param name="id"></param>
        public static void RunnerDelete(int id)
        {
            // TODO remove specific runner from file 
            // -> load all runners
            // -> remove everything from txt
            // -> save all runners from variable to txt
            _dbRunners.Remove(id);
        }
    }
}
