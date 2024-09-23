namespace FlightBookingSystem
{
    class AgencyBooking : IBooking
    {
        private static List<Booking> bookings = new List<Booking>();
        private static int nextBookingId = 1;

        //Create a booking for the passenger
        public void BookTicket(Flight flight, Passenger passenger)
        {
            var booking = new Booking
            {
                BookingId = nextBookingId++,
                Flight = flight,
                Passenger = passenger
            };
            bookings.Add(booking);
            Console.WriteLine("Booking confirmed through agency! Your Booking ID: " + booking.BookingId);
        }

        //Cancel a booking for the passenger
        public void CancelBooking(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                bookings.Remove(booking);
                Console.WriteLine("Booking cancelled successfully.");
            }
            else
            {
                Console.WriteLine("Booking ID not found.");
            }
        }

        //Get booking details by booking ID
        public Booking GetBookingDetails(int bookingId)
        {
            return bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }

        //List all bookings 
        public void ListBookings()
        {
            Console.WriteLine($"\nCurrent Agency Bookings ({bookings.Count} bookings)");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.BookingId} \tFlight: {booking.Flight.FlightNumber} \tPassenger: {booking.Passenger.Name}");
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
