namespace InheritanceDemo
{
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public Customer(string name, string email, int customerID)
            : base(name, email)
        {
            CustomerID = customerID;
        }


        public void PlaceOrder()
        {
            Console.WriteLine($"{Name} (Customer ID: {CustomerID}) has placed an order.");
        }
    }
}
