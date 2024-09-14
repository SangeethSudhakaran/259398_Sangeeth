namespace Polymorphism
{
    public class Order
    {
        public List<string> Products { get; set; }
        public double TotalAmount { get; set; }

        public Order()
        {
            Products = new List<string>();
            TotalAmount = 0;
        }


        public virtual double CalculateTotalAmount()
        {
            Console.WriteLine("Calculating total amount without discount.");
            return TotalAmount;
        }


        public void AddProduct(string product, double price)
        {
            Products.Add(product);
            TotalAmount += price;
            Console.WriteLine($"Added product: {product}, Price: ${price}");
        }

        public void AddProduct(string product, int quantity, double unitPrice)
        {
            Products.Add(product);
            double totalProductPrice = quantity * unitPrice;
            TotalAmount += totalProductPrice;
            Console.WriteLine($"Added product: {product}, Quantity: {quantity}, Total Price: ${totalProductPrice}");
        }
    }
}
