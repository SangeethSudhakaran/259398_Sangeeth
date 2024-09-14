namespace InheritanceDemo
{
    public class Admin : Person
    {
        public int EmployeeID { get; set; }

        public Admin(string name, string email, int employeeID) : base(name, email)
        {
            EmployeeID = employeeID;
        }


        public void ManageUser(Customer customer)
        {
            Console.WriteLine($"{Name} (EmployeeID: {EmployeeID}) is managing customer: {customer.Name}");
        }
    }
}
