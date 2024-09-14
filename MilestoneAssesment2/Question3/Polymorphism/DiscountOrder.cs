namespace Polymorphism
{
    public class DiscountOrder : Order
    {
        public double Discount { get; set; }

        public DiscountOrder(double discount)
        {
            Discount = discount;
        }


        public override double CalculateTotalAmount()
        {
            Console.WriteLine("Calculating total amount with discount.");
            double discountAmount = TotalAmount * (Discount / 100);
            return TotalAmount - discountAmount;
        }
    }
}
