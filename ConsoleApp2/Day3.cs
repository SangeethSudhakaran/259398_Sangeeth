using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day3
    {

        //Day3
        //Question3 - Arrays 2D array Sum
        public void Day3Question3_2DArraySum()
        {
            int a = 1, b = 2, result = 0;
            Console.WriteLine("2D Array sum");
            Console.WriteLine("-------------------------------------------");

            int[,] sample2D = new int[2, 2];
            int[,] sample2D1 = new int[2, 2];
            int[,] sample2Dsum = new int[2, 2];

            sample2D = readMatrix(sample2D);
            sample2D1 = readMatrix(sample2D1);


            Console.WriteLine("Matrix 1 is");
            printMatrix(sample2D);

            Console.WriteLine("Matrix 2 is");
            printMatrix(sample2D1);

      
            //calculate sum
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sample2Dsum[i, j] = sample2D[i, j] + sample2D1[i, j];
                }
            }

            Console.WriteLine("And the sum is");
            printMatrix(sample2Dsum);
        }

        void printMatrix(int[,] sample2D)
        {           
            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sample2D[i, j] + "   ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        int[,] readMatrix(int[,] sample2D)
        {
            Console.WriteLine("Please input the array values");
            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sample2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return sample2D;
        }


        //Day3
        //Question2 - Swap numbers using a function
        public static void sumOut(int a, int b, out int result)
        {
            result = a + b;
        }
        public void Day3Question2_OutKeyword()
        {
            int a = 1, b = 2, result = 0;
            Console.WriteLine("Outkeyword");
            Console.WriteLine("-------------------------------------------");

            sumOut(a, b, out result);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("Value of the numbers after sum - " + result);
        }


        //Day3
        //Question1 - Swap numbers using a function
        public static void SwapNumbers(ref int a, ref int b)
        {
            int c = a;
            a = b; b = c;
        }
        public void Day3Question1_Swap()
        {
            int a = 1, b = 2;
            Console.WriteLine("Swap numbers by method");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Value of the numbers a=" + a + " b=" + b);
            SwapNumbers(ref a, ref b);
            Console.WriteLine("Value of the numbers after swap - a=" + a + " b=" + b);
        }
    }
}
