using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hi welcome ");
        }

        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            Age = age;
        }

    }

    public class Student1 : Person
    {
        public void Study()
        {
            Console.WriteLine("Im studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is " + GetAge() + " years old");
        }

    }
    
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Im explaining");
        }
    }

    public class StudentProfessorTest 
    {
        public void Test()
        {
            Person person = new Person();
            person.Greet();

            Student1 student = new Student1();
            student.SetAge(25);
            student.Greet();
            student.GetAge();
            student.Study();


            Teacher teacher = new Teacher();
            teacher.SetAge(25);
            teacher.Greet();
            teacher.GetAge();
            teacher.Explain();
        }

    }
}
