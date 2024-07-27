using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EmployeeCRUD
    {
        public Employee NewEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter employee Id");
            employee.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee Name");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter employee Gender");
            employee.Gender = Console.ReadLine();

            Console.WriteLine("Enter employee Address");
            employee.Address = Console.ReadLine();

            return employee;

        }

        public Employee[] Delete(int employeeId, Employee[] employees)
        {
            int indexToRemove = Array.IndexOf(employees, employeeId);
            Employee[] employees1 = new Employee[10];

            Array.Copy(employees, 0, employees1, 0, indexToRemove);
            Array.Copy(employees, indexToRemove + 1, employees1, indexToRemove, employees.Length - indexToRemove - 1);
            return employees1;
        }

        public Employee Update()
        {
            Employee employee = new Employee();

            //Console.WriteLine("Enter employee Id");
            //employee.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee Name");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter employee Gender");
            employee.Gender = Console.ReadLine();

            Console.WriteLine("Enter employee Address");
            employee.Address = Console.ReadLine();

            return employee;

        }

        public void PrintEmployees(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine("Employee details");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Id       : " + employee.Id);
                    Console.WriteLine("Name     : " + employee.Name);
                    Console.WriteLine("Gender   : " + employee.Gender);
                    Console.WriteLine("Address  : " + employee.Address);
                    Console.WriteLine("--------------------------");
                }

            }

        }
    }

}
