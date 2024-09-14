namespace Encapsulation
{
    // Product Class with encapsulation
    public class Product
    {
        // Private fields
        private string name;
        private double price;
        private string category;

        // Public property for Name (read-only)
        public string Name
        {
            get { return name; }
        }

        // Public property for Category (read-only)
        public string Category
        {
            get { return category; }
        }

        // Public property for Price (read and write with validation)
        public double Price
        {
            get { return price; }
            private set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Error: Price cannot be negative.");
            }
        }

        // Constructor to initialize fields
        public Product(string name, double price, string category)
        {
            this.name = name;
            this.category = category;
            Price = price;
        }

        // Method to update the product price (encapsulating the logic)
        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"Product price updated to: ${Price}");
        }
    }
}
