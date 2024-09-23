namespace FlightBookingSystem
{
    class DomesticFlight : Flight
    {
        public override decimal CalculateFare()
        {
            return BaseFare * 1.0m;
        }

        //Display flight details
        public override void DisplayDetails()
        {
            Console.WriteLine($"Domestic Flight\t\t\t{FlightNumber} to {Destination}\t Fare: {CalculateFare()}");
        }
    }
}
