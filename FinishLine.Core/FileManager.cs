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
        public static List<Country> Countries;

        private const string COUNTRY_CODE = "CountryCode";
        private const string ENGLISH_SHORT_NAME = "EnglishShortName";
        private const string SLOVAK_SHORT_NAME = "SlovakShortName";
        private const char VALUE_SEPARATOR = ';';
        
        /// <summary>
        /// Open CVS file. Load data and create list of countries.
        /// </summary>
        /// <returns>List of Countries</returns>
        public static void LoadCountries()
        {
            using (var streamReader = new StreamReader(@"C:\Users\transformer3\source\repos\W3D5_IndividualProject2\Data\countries.csv"))
            using (var csvReader = new CsvReader(streamReader))
            {
                // CSV had reader record so we read that first
                csvReader.ValueSeparator = VALUE_SEPARATOR;
                csvReader.ReadHeaderRecord();
                while (csvReader.HasMoreRecords)
                {
                    var dataRecord = csvReader.ReadDataRecord();
                    Countries.Add(new Country(dataRecord[0], dataRecord[1], dataRecord[2]));
                    // since reader has a header record we can access data bz column names as well as by index
                    //Console.WriteLine("{0} is nicknamed {1}.", dataRecord[0], dataRecord["Nickname"]);
                }
            }
        
        }
        

    }
}
