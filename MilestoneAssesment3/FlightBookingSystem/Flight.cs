namespace FlightBookingSystem
{
    abstract class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; } 
        public decimal BaseFare { get; set; }

        public abstract decimal CalculateFare();
        public abstract void DisplayDetails();
    }

    

    

    

    


   

    

}
