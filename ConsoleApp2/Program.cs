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
            Day6 day6 = new Day6();
            Day7 day7 = new Day7();
            Day8 day8 = new Day8();
            Day9 day9 = new Day9();
            Day10 day10 = new Day10(); 
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
            //employee = employee.NewEmployee();
            //employee.PrintEmployee(employee);
            #endregion

            #region Day5
            //day5.Day5Example1_Constructor();
            //prg.EmployeeCrudOperation();
            #endregion

            #region Day6
            //day6.Day6Example1_ConstructorDestructor();
            //day6.Day6Example2_MultilevelInheritance();
            //day6.Day6Example2_StudentProfessor();
            //day6.Day6Example3_StudentProfessor3People();
            #endregion

            #region Day7
            //day7.Day7Example1_AbstractClass();
            //day7.Day7Example2_MethodOverloading();
            day7.Day7Example2_OperatorOverloading();
            #endregion

            #region Day8
            //day8.Day8Example2_ClassLibrary();
            #endregion

            #region Day9
            //day9.Day9Example3_DictionaryAndHashSet();
            #endregion

            #region Day10
            day10.Day10Example3_FileHandling1();

            #endregion

        }



        void EmployeeCrudOperation()
        {
            Employee[] employees = new Employee[10];
            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            int userInput = 0;
            int empCounter = 0;

            //employees[0] = employeeCRUD.NewEmployee();
            //employees[1] = employeeCRUD.NewEmployee();

            //employeeCRUD.PrintEmployees(employees);


            while (userInput < 5)
            {
                Console.WriteLine("Please enter a choice");
                Console.WriteLine("Employee management");
                Console.WriteLine(" 1. Add \n 2. Update \n 3. Delete \n 4. List \n 5. Exit \n");
                userInput = Convert.ToInt16(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        employees[empCounter] = employeeCRUD.NewEmployee();
                        empCounter++;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        employeeCRUD.PrintEmployees(employees);
                        break;
                    case 5:
                        
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;
                }
            }


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