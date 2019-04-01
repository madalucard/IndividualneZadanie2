using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class FileManager
    {
        public static List<Country> Countries = new List<Country>();
        
        private const string COUNTRY_CODE = "CountryCode";
        private const string ENGLISH_SHORT_NAME = "EnglishShortName";
        private const string SLOVAK_SHORT_NAME = "SlovakShortName";
        private const char VALUE_SEPARATOR = ';';
        private static string _filePath = @"C: \Users\madal\source\repos\IndividualneZadanie2\Data\dbRunners.txt";

        /// <summary>
        /// Open CVS file. Load data and create list of countries.
        /// </summary>
        /// <returns>List of Countries</returns>
        public static void LoadCountries()
        {
            // loading link from home computer
            using (var streamReader = new StreamReader(@"C: \Users\madal\source\repos\IndividualneZadanie2\Data\countries.csv"))
            // Loading link from work computer
            //using (var streamReader = new StreamReader(@"C:\Users\transformer3\source\repos\W3D5_IndividualProject2\Data\countries.csv"))
            using (var csvReader = new CsvReader(streamReader))
            {
                // CSV had reader record so we read that first
                csvReader.ValueSeparator = VALUE_SEPARATOR;
                csvReader.ReadHeaderRecord();
                while (csvReader.HasMoreRecords)
                {
                    var dataRecord = csvReader.ReadDataRecord();
                    Countries.Add(new Country(dataRecord[COUNTRY_CODE], dataRecord[SLOVAK_SHORT_NAME], dataRecord[ENGLISH_SHORT_NAME]));
                    // since reader has a header record we can access data bz column names as well as by index
                    //Console.WriteLine("{ 0} is nicknamed {1}.", dataRecord[0], dataRecord["Nickname"]);
                }
            }
        }

        /// <summary>
        ///  Saves dictionary to txt.
        /// </summary>
        public static void SaveRunners()
        {
            using (StreamWriter file = new StreamWriter(_filePath))
            {
                foreach (var entry in RunnerManger._dbRunners)
                {
                    file.WriteLine($"{entry.Key.ToString()};{entry.Value.FirstName.ToString()};{entry.Value.LastName.ToString()};{entry.Value.Country.ToString()};{entry.Value.Age.ToString()};{entry.Value.IsMale}");
                }
            }
            
        }

        /// <summary>
        /// Load *.txt, split it and create dictionary.  Key =  index, value  =  new Runner
        /// </summary>
        public static void LoadRunners()
        {
            using (File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite)) {}
            List<string> tempList = new List<string>();
            tempList = File.ReadAllLines(_filePath).ToList();
            foreach (var lines in tempList)
            {
                string[] temp = lines.Split(VALUE_SEPARATOR);
                bool tempBool;
                if (temp[5] == "male")
                {
                    tempBool = true;
                }
                else
                {
                    tempBool = false;
                }

                RunnerManger._dbRunners.Add(int.Parse(temp[0]), new Runner(int.Parse(temp[0]), temp[1], temp[2], temp[3], int.Parse(temp[4]), tempBool));
            }

        }
    }
}
