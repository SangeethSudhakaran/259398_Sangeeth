using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day11
    {
        //Example1 RegExpr
        public void Day11Example1_RegEx()
        {
            string pattern = "^[0-9]{4}$";

            Regex reg = new Regex(pattern);

            Console.WriteLine("Enter a number with 4 digits");
            string x = Console.ReadLine();

            if (reg.IsMatch(x))
            {
                Console.WriteLine("Its a number with 4 digits");
            }
            else
            {
                Console.WriteLine("Its not a number with 4 digit");
            }            
        }
    }
}
