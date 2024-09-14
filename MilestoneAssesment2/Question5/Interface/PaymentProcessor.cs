namespace Interface
{
    public class PaymentProcessor : IOrderProcessor
    {
        private string paymentStatus;


        public void ProcessOrder()
        {
            paymentStatus = "Payment Processed";
            Console.WriteLine(paymentStatus);
        }


        public void CancelOrder()
        {
            paymentStatus = "Payment Cancelled";
            Console.WriteLine(paymentStatus);
        }
    }
}
