namespace ClassesAndObjects
{
    class Order
    {
        //Maintain list of products
        public List<Product> Products = new List<Product>();

        //Adding product total
        public double OrderTotal
        {
            get
            {
                double total = 0;
                foreach (var product in Products)
                {
                    total += product.Price;
                }
                return total;
            }
        }

        //Adding product to the list
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //Print order details
        public void ShowOrderDetails()
        {
            Console.WriteLine("Order Details");
            Console.WriteLine("---------------------------------------------");
            foreach (var product in Products)
            {
                Console.WriteLine($" Product Name: {product.Name}, Category: {product.Category}, Price: {product.Price}");
            }
            Console.WriteLine($" Order Total: {OrderTotal}");
        }
    }
}
