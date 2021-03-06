﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class RunnerManger
    {
        public static Dictionary<int, Runner> _dbRunners = new Dictionary<int, Runner>();
        /// <summary>
        /// Hardcoded DB - now useless
        /// </summary>
        //public static void PopulateDB()
        //{

        //    _dbRunners.Add(28, new Runner(28, "Martin", "Lapihuska", "Slovakia", 25, true));
        //    _dbRunners.Add(206, new Runner(206, "Jakub", "Lapihuska", "Slovakia", 22, true));
        //    _dbRunners.Add(75, new Runner(75, "Martin", "Bielik", "Slovakia", 24, true));
        //    _dbRunners.Add(2, new Runner(2, "Andrej", "Balaz", "Slovakia", 30, true));
        //    _dbRunners.Add(7, new Runner(7, "James", "Bond", "Slovakia", 35, true));
        //    _dbRunners.Add(55, new Runner(55, "John", "Doe", "Slovakia", 35, true));
        //    _dbRunners.Add(666, new Runner(666, "Bruce", "Wayne", "Slovakia", 35, true));
        //    _dbRunners.Add(15, new Runner(15, "Clark", "Kent", "Slovakia", 35, true));
        //    _dbRunners.Add(1, new Runner(1, "Ragnar", "Lothbrock", "Slovakia", 35, true));
        //}
        /// <summary>
        /// It will return actual Database
        /// </summary>
        /// <returns>Databese of runners</returns>
        public static Dictionary<int, Runner> GetRunnerDb()
        {
            if (_dbRunners.Count != 0)
            {
                return _dbRunners;
            }
            else
            {
                FileManager.LoadRunners();
                return _dbRunners;
            }
        }
        /// <summary>
        /// Create runner into dictionary with choosen ID and saves it to Txt
        /// </summary>
        /// <param name="id">Id of runner</param>
        /// <param name="firstName">Firstname of runner</param>
        /// <param name="lastName">Lastname of runner</param>
        /// <param name="country">Country of runner</param>
        /// <param name="age">Runner's age</param>
        /// <param name="isMale">Runner's sex</param>
        public static void RunnerAdd(int id, string firstName, string lastName, string country, int age, bool isMale)
        {
            _dbRunners.Add(id, new Runner(id, firstName, lastName, country, age, isMale));
            FileManager.SaveRunners();
        }
        /// <summary>
        ///  Delete Runner from DB by id and saves is to Txt
        /// </summary>
        /// <param name="id">Id of deleted runner</param>
        public static void RunnerDelete(int id)
        {
            _dbRunners.Remove(id);
            FileManager.SaveRunners();
        }
    }
}
