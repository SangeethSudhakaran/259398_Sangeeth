using System.Net.Security; 

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            Employee employee = new Employee();
            Day2 day2 = new Day2();
            Day3 day3 = new Day3();
            Day4 day4 = new Day4();
            Day5 day5 = new Day5();
            //Day3Question1_Swap();
            //prg.Day3Question1_Swap();
            //prg.ElectricityCalc();
            //prg.OddOrEven();
            //prg.sumFun();


            //prg.Question1_Salary();
            #region Day2
            //day2.Day2Question1_Salary();
            #endregion

            #region Day3
            //day3.Day3Question3_2DArraySum();
            //day3.Day3Question2_OutKeyword();
            //day3.Day3Question1_Swap();
            #endregion


            #region Day4
            //day4.Day4Example1_TryParse(); 
            //day4.Day4Example2_StringAndStringBuilder(); 
            //day4.Day4Question1_Paliendrome();

            //Employee class 
            employee = employee.NewEmployee();
            employee.PrintEmployee(employee);
            #endregion

            #region Day5
            day5.Day5Example1_Constructor();
            #endregion


        }







        void ElectricityCalc()
        {
            Console.WriteLine("Electricity bill calculation");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the electricity consumption units");

            int elecUnits = Convert.ToInt32(Console.ReadLine());
            double amount = 0;

            if (elecUnits >= 250)
            {
                amount = elecUnits * 1.5;
            }
            else if (elecUnits >= 100)
            {
                amount = elecUnits * 1.2;
            }
            else if (elecUnits >= 75)
            {
                amount = elecUnits * .75;
            }
            else if (elecUnits >= 50)
            {
                amount = elecUnits * .50;
            }
            Console.WriteLine("The electricity bill amount for the units-" + elecUnits + " and the amount is - " + (amount + (amount * .20)));


        }
        void OddOrEven()
        {
            Console.WriteLine("Odd or Even");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter a number to check Odd or Even");

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("The input number " + num1 + " is Even!");
            }
            else
            {
                Console.WriteLine("The input number " + num1 + " is Odd!");
            }


        }
        void sumFun()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter number 1");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is " + (num1 + num2));
        }
    }
}