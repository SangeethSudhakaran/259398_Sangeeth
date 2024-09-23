namespace FlightBookingSystem
{
    class Booking
    {
        public int BookingId { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
    }
}
