using ClassesAndObjects;
namespace ClassesAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding products
            Product product1 = new Product("Pants", 1100.75, "Fabrics");
            Product product2 = new Product("Jeans", 900, "Fabrics");
            Product product3 = new Product("Saree", 750, "Fabrics");
            Product product4 = new Product("Earbuds", 1499.50, "Electronics");

            //Creating user
            User user = new User("Sangeeth", "admin@123", "sangeeth@ust.com");
            
            //Creating new order
            Order order = new Order();
            
            //Adding products to the order
            order.AddProduct(product1);
            order.AddProduct(product2);
            order.AddProduct(product3);
            order.AddProduct(product4);

            //Print order details
            order.ShowOrderDetails();
        }
    }
}