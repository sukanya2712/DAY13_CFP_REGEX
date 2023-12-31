﻿using System;
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

        public static void LastName()
        {
            string input = "Naik";
            Regex regex = new Regex("^[A-Z][a-z]{2,}");
            Match match = regex.Match(input);

            if (match.Success)
                Console.WriteLine("Valid lastname");
            else
                Console.WriteLine("Invalid lastname");
        }

        public static void ValidEmail()
        {
            string input = "abc.xyz@bl.co.in";
            Regex regex = new Regex("^[a-z]{3}[.][a-z]{3}@[a-z]{2}[.][a-z]{2}[.][a-z]{2,}");
            Match match = regex.Match(input);

            if (match.Success)
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("Invalid email");
        }

        public static void ValidMobile()
        {
            string input = "+91 9822042799";
            Regex regex = new Regex("^(\\+?\\d{1,3})\\s\\d{10}$");
            Match match = regex.Match(input);

            if (match.Success)
                Console.WriteLine("Valid phone no");
            else
                Console.WriteLine("Invalid phone no");
        }

        public static void ValidPassword()
        {
            string input = "mySecretPassword";
            Regex regex = new Regex("^[A-Za-z]{8,}$");
            Match match = regex.Match(input);

            if (match.Success)
                Console.WriteLine("Valid password_rule1");
            else
                Console.WriteLine("Invalid password_rule1");
        }
    }
}
