using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Country
    {
        
        public string CountryCode { get; set; }
        public string CountryNameSlovak { get; set; }
        public string CountryNameEnglish { get; set; }
        /// <summary>
        /// Constructor of country names
        /// </summary>
        /// <param name="countryCode">Code of country</param>
        /// <param name="countrynameSlovak">Country name in slovak</param>
        /// <param name="countryNameEnglish">country name in english</param>
        public Country(string countryCode, string countrynameSlovak, string countryNameEnglish)
        {
            CountryCode = countryCode;
            CountryNameSlovak = countrynameSlovak;
            CountryNameEnglish = countryNameEnglish;
        }
    }
}
