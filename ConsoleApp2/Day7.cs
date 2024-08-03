using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public void Day7Example2_OperatorOverloading()
        {
            Sample s1 = new Sample(1,2);
            Sample s2 = new Sample(2,3);
            Sample s3 = s1 * s2;
            s3.Print();
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

    public class Sample
    {
        public int Number1, Number2;
        public Sample(int a, int b)
        {
            Number1 = a; Number2 = b;
        }

        public void Print()
        {
            Console.WriteLine("Number 1 is " + Number1 + "Number 2 is " + Number2);
        }

        public static Sample operator *(Sample s1, Sample s2)
        {
            Sample s3 = new Sample(0,0);
            s3.Number1 = s1.Number1 * s2.Number1;
            s3.Number2 = s1.Number2 * s2.Number2;
            return s3;
        }
    }
}
