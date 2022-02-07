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
}
