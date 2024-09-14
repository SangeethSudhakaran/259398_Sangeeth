using Polymorphism;

namespace PolymorphismDemo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Adding items into the order - without discount
            Order regularOrder = new Order();
            regularOrder.AddProduct("HP pavilion", 59999.99);
            regularOrder.AddProduct("Dell mounse", 22, 450);
            Console.WriteLine($"Total amount without discount: {regularOrder.CalculateTotalAmount()}");

            Console.WriteLine();

            //Adding items into the order - with discount
            DiscountOrder discountOrder = new DiscountOrder(10); 
            discountOrder.AddProduct("Samsung S8 Plus", 45000);
            discountOrder.AddProduct("Samsung note 10", 2, 75000);
            Console.WriteLine($"Total amount with discount: {discountOrder.CalculateTotalAmount()}");
        }
    }
}
