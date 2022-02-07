using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class ValidFirstName
    {
        public static string regex = "^[A-Z]{1}[a-z]{2,}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
    class ValidLastName
    {
        public static string regex = "^[A-Z]{1}[a-z]{2,}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
    class ValidMobileNo
    {
        public static string regex = "^[1-9]{2,3}[ ][1-9][0-9]{9}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
    class ValidPassword
    {
        public static string regex = "^(?=.*[A-Za-z])(?=.*[0-9])(?=.*[@#$%^_,])[a-zA-Z0-9@#$%&^.,]{8,}$";
        public bool RegexPro(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
