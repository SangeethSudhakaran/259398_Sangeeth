namespace ConsoleApp2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

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

        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Employee details");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Id : " + employee.Id);
            Console.WriteLine("Name" + employee.Name);
            Console.WriteLine("Gender" + employee.Gender);
            Console.WriteLine("Address" + employee.Address);
            Console.WriteLine("--------------------------");
        }
    }
}
