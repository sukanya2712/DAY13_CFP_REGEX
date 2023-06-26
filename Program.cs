
﻿using System.Text.RegularExpressions;

namespace RegEx

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn REGEX ");

            Console.WriteLine();

            //uc1
            UserReg.FirstName();

            //uc2
            UserReg.LastName();

            //uc3
            UserReg.ValidEmail();

            //uc4
            UserReg.ValidMobile();

            //uc5
            UserReg.ValidPassword();

        }
        
    }
}