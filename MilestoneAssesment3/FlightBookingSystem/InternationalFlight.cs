namespace FlightBookingSystem
{
    class InternationalFlight : Flight
    {
        public override decimal CalculateFare()
        {
            return BaseFare * 1.5m; //Update fare for international flight
        }

        //Display flight details
        public override void DisplayDetails()
        {
            Console.WriteLine($"International Flight\t\t{FlightNumber} to {Destination}\t Fare: {CalculateFare()}");
        }
    }
}
