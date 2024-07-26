using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day4
    {
        //Day4
        //Example1 - Try parse and parse
        public void Day4Example1_TryParse()
        {
            Console.WriteLine("Enter a number or string");
            string number = Console.ReadLine();
            Console.WriteLine("Try parse");
            Console.WriteLine("-------------------------------------------");

            bool isInt = int.TryParse(number, out int result);
            if (isInt)
            {
                Console.WriteLine("The input is number - " + result);
            }
            else
            {
                Console.WriteLine("The input is not a number - " + number);
            }
        }

        //Day4
        //Example1 - String And StringBuilder
        public void Day4Example2_StringAndStringBuilder()
        {
            Console.WriteLine("String And StringBuilder");
            Console.WriteLine("-------------------------------------------");

            string s = "Sample text";
            StringBuilder sb = new StringBuilder();
            sb = sb.Append(s);

            Console.WriteLine("The appended text is below");
            Console.WriteLine(sb);

            Console.WriteLine();
            Console.WriteLine("For loop through string s");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        
        //Day4
        //Question1 - Paliendrome
        public void Day4Question1_Paliendrome()
        {
            Console.WriteLine("Paliendrome");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Enter a word to check it is Paliendrome or not");
            string s = Console.ReadLine();
            string s1 = "";

            
            Console.WriteLine();
            for (int i = s.Length-1; i >= 0; i--)
            {
                s1 += (s[i]);
            }

            bool isPaliendrome = s == s1 ? true : false;

            if(isPaliendrome)
            {
                Console.WriteLine("The input is a paliendrome");
            }
            else
            {
                Console.WriteLine("The input is not a paliendrome");
            }

            
        }
    }
}
