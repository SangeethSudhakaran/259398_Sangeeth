namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new customer
            Customer customer1 = new Customer("Sangeeth Sudhakaran", "sangeethcs@gmail.com", 9978);
            customer1.DisplayPersonInfo(); 
            customer1.PlaceOrder(); 

            Console.WriteLine();
            
            //Creating a admin account
            Admin admin1 = new Admin("System Admin", "admin@ust.com", 10);
            admin1.DisplayPersonInfo(); 
            admin1.ManageUser(customer1); 
        }
    }
}
