using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    public class EmployeeDay11
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    
    public class DepartmentDay11
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class Day11
    {


        //Example4 Linq
        public void Day11Example4_LinqSalary()
        {
            List<EmployeeDay11> employeeList = new List<EmployeeDay11>();
        }

        //Example3 Linq
        public void Day11Example3_Linq()
        {
            string[] languages = { "C", "C++", "C#", "Java", "Go Lang", "Ruby", "Pearl", "PHP" };

            var result = languages.Where(x => x.Contains("C")).ToList();
            //var result = from lang in languages where lang.Contains("C") select lang;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //Example2 RegExpr
        public void Day11Example1_RegEx1()
        {
            string pattern = "a*b";
            string pattern1 = "a+b";
            string pattern2 = "a?b";
            string x = "";

            Regex reg = new Regex(pattern2);

            while (x != "0")
            {
                Console.WriteLine("Enter a word includes a and b, to exit enter 0");
                x = Console.ReadLine();

                if (reg.IsMatch(x))
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }

        }

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
