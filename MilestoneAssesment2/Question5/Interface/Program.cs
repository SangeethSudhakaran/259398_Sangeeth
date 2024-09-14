namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process order and cancel order
            IOrderProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessOrder();
            paymentProcessor.CancelOrder();

            Console.WriteLine();

            IOrderProcessor shippingProcessor = new ShippingProcessor();
            shippingProcessor.ProcessOrder();
            shippingProcessor.CancelOrder();
        }
    }
}
