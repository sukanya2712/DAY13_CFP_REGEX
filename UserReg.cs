using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    class UserReg
    {
        public static void FirstName()
        {
            //string input = "Sukanya";
            Regex regex = new Regex("^[A-Z][a-z]{2,}");
            Match match = regex.Match("Sukanya");

            if (match.Success)
                Console.WriteLine("Valid firstname");
            else
                Console.WriteLine("Invalid firstname");
        }
    }
}
