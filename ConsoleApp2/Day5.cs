using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day5
    {
        //Day5
        //Constructor
        public void Day5Example1_Constructor()
        {
            Console.WriteLine("Constructor");
            Console.WriteLine("-------------------------------------------");

            Student student = new Student(100, "Sangeeth Sudhakaran");
            student.PrintStudent(student);

        }


    }
}
