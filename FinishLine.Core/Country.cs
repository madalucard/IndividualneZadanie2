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

        public Country(string countryCode, string countrynameSlovak, string countryNameEnglish)
        {
            CountryCode = countryCode;
            CountryNameSlovak = countrynameSlovak;
            CountryNameEnglish = countryNameEnglish;
        }
    }
}
