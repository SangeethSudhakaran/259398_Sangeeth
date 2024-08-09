namespace ConsoleApp2
{
    internal class Day12
    {
        //Example Linq
        public void Day12Example1_Linq()
        {
            List<Day12Employee> employeeList = new List<Day12Employee>()
            { new Day12Employee(){Id=101,Name="Anil",Gender="Male",Salary=100000},
                 new Day12Employee(){Id=102,Name="Soniya",Gender="Female",Salary=200000},
                 new Day12Employee(){Id=102,Name="Soniya",Gender="Female",Salary=200000},
                new Day12Employee(){Id=103,Name="Rohit",Gender="Male",Salary=700000},
                new Day12Employee(){Id=104,Name="Rakesh",Gender="Male",Salary=809000},
                 new Day12Employee(){Id=105,Name="Vikash",Gender="Male",Salary=200009},
                new Day12Employee(){Id=106,Name="Manju",Gender="Female",Salary=806409},
                new Day12Employee(){Id=107,Name="Kapil",Gender="Male",Salary=110300},
                 new Day12Employee(){Id=108,Name="Anil",Gender="Male",Salary=120210},
                new Day12Employee(){Id=109,Name="Rocky",Gender="Male",Salary=150201},
            };


            var res = employeeList.GroupBy(x => x.Gender).ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item.Key + "\n");
                foreach (Day12Employee e in item)
                {
                    Console.WriteLine(e.Name);
                }
                Console.WriteLine("=============================");
            }


            //Console.WriteLine("=============================");
            Console.WriteLine("\nAverage Salary");
            var res1 = employeeList.Average(x => x.Salary);
            Console.WriteLine(res1);
            Console.WriteLine("=============================");

        }


        public class Day12Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public double Salary { get; set; }
        }
    }
}
