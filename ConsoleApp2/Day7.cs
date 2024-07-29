using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day7
    {
        //Day7
        //Example1 Abstract class
        public void Day7Example1_AbstractClass()
        {
            Day7Cat cat = new Day7Cat();
            cat.Sound();
        }

        //Day7
        //Example2 MethodOverloading
        public void Day7Example2_MethodOverloading()
        {
            OverLoadingExample overLoadingExample = new OverLoadingExample();
            Console.WriteLine("Sum of numbers 1 and 2");            
            overLoadingExample.Sum(1, 2);

            Console.WriteLine("Sum of string Sangeeth and Sudhakaran");
            overLoadingExample.Sum("Sangeeth ", "Sudhakaran");
        }

    }
    public abstract class Day7Animal
    {
        public abstract string Sound();
    }

    public class Day7Cat : Day7Animal
    {
        public override string Sound()
        {
            return "Cats make sound";
        }
    }

    public class OverLoadingExample 
    { 
        public void Sum(int a, int b)
        {
            Console.WriteLine("The sum of numbers are " + (a + b));
        }

        public void Sum(string a, string b)
        {
            Console.WriteLine("The sum of strings are " + a + b);
        }
    }
}
