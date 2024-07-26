using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day2
    {
        //Day2
        //Question1
        public void Day2Question1_Salary()
        {
            Console.WriteLine("Gross Salary calculation");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the Basic Salary");

            double basicSalary = Convert.ToDouble(Console.ReadLine());
            double amount = 0;
            double hra = 0;
            double da = 0;

            if (basicSalary <= 10000)
            {
                amount = basicSalary + (basicSalary * .2) + (basicSalary * .8);
            }
            else if (basicSalary <= 20000)
            {
                amount = basicSalary + (basicSalary * .25) + (basicSalary * .9);
            }
            else if (basicSalary > 20000)
            {
                amount = basicSalary + (basicSalary * .3) + (basicSalary * .95);
            }

            Console.WriteLine("The salary after the calculation is -" + amount);
        }
    }
}
