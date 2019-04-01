using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner
    {
        public int Id { get; }
        public string IdToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Id > 0 && Id < 10)
                {
                    sb.Append("00").Append(Id);
                }
                else if (Id >= 10 && Id <= 99)
                {
                    sb.Append("0").Append(Id);
                }
                else if (Id > 99 && Id <= 999)
                {
                    sb.Append(Id);
                }
                return sb.ToString();
            }
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string Country { get; }
        public int Age { get; }
        public bool IsMale { get; }
        public string IsMaleToString
        {
            get
            {
                if (IsMale)
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }

            }
        }

        public Runner(int id, string firstName, string lastName, string country, int age, bool isMale)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            Age = age;
            IsMale = isMale;
        }



    }
}
