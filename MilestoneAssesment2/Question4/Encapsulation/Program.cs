namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Product instance
            Product product1 = new Product("IPhone 13", 60000, "Electronics");
            Console.WriteLine($"Product: {product1.Name}, Price: ${product1.Price}, Category: {product1.Category}");

            // Updating product price
            product1.UpdatePrice(75000); // Valid price
            product1.UpdatePrice(-600); // Invalid price (negative)

            Console.WriteLine();

            // Creating a User instance
            User user1 = new User("sangeeth", "password", "sangeeth@ust.com");
            Console.WriteLine($"Username: {user1.Username}, Email: {user1.Email}");

            // Updating email
            user1.Email = "sangeeth.sudhakaran@ust.com"; // Valid email
            user1.Email = "invalid-email-test"; // Invalid email

            // Updating password
            user1.UpdatePassword("password", "password123"); // Correct current password
            user1.UpdatePassword("wrongpassword", "password123"); // Incorrect current password
        }
    }
}
