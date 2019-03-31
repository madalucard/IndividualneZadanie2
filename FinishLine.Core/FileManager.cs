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
        private static List<Country> countries = new List<Country>();

        private const string COUNTRY_CODE = "CountryCode";
        private const string ENGLISH_SHORT_NAME = "EnglishShortName";
        private const string SLOVAK_SHORT_NAME = "SlovakShortName";
        private const char VALUE_SEPARATOR = ';';
        
        /// <summary>
        /// Open CVS file. Load data and create list of countries.
        /// </summary>
        /// <returns>List of Countries</returns>
        public static List<Country> GetCountries()
        {
            // loading data from work computer
            // using (var streamReader = new StreamReader(@"C:\Users\transformer3\source\repos\W3D5_IndividualProject2\Data\countries.csv"))
            // loading data from home computer
            using (var streamReader = new StreamReader(@"C:\Users\madal\source\repos\IndividualneZadanie2\Data\countries.csv"))
            using (var csvReader = new CsvReader(streamReader))
            {
                // CSV had reader record so we read that first
                csvReader.ValueSeparator = VALUE_SEPARATOR;
                csvReader.ReadHeaderRecord();
                while (csvReader.HasMoreRecords)
                {
                    var dataRecord = csvReader.ReadDataRecord();
                    countries.Add(new Country(dataRecord[0], dataRecord[1], dataRecord[2]));
                    // since reader has a header record we can access data bz column names as well as by index
                    //Console.WriteLine("{0} is nicknamed {1}.", dataRecord[0], dataRecord["Nickname"]);
                }
            }
        return countries;
        }
        
    }
}
