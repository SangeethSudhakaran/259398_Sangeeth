namespace Interface
{
    public class ShippingProcessor : IOrderProcessor
    {
        private string shippingStatus;


        public void ProcessOrder()
        {
            shippingStatus = "Order Shipped";
            Console.WriteLine(shippingStatus);
        }


        public void CancelOrder()
        {
            shippingStatus = "Shipping Cancelled";
            Console.WriteLine(shippingStatus);
        }
    }
}
