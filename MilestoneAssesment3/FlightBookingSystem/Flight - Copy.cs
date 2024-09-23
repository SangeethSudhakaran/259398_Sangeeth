namespace FlightBookingSystem
{
    abstract class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public decimal BaseFare { get; set; }

        public abstract decimal CalculateFare();
        public abstract void DisplayDetails();
    }

    class DomesticFlight : Flight
    {
        public override decimal CalculateFare()
        {
            return BaseFare;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Domestic Flight {FlightNumber} to {Destination} - Fare: {CalculateFare()}");
        }
    }

    class InternationalFlight : Flight
    {
        public override decimal CalculateFare()
        {
            return BaseFare * 1.5m; // Increased fare for international
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"International Flight {FlightNumber} to {Destination} - Fare: {CalculateFare()}");
        }
    }

    interface IBooking
    {
        void BookTicket(Flight flight, Passenger passenger);
        void CancelBooking(int bookingId);
        Booking GetBookingDetails(int bookingId);
        void ListBookings();
    }

    class OnlineBooking : IBooking
    {
        private static List<Booking> bookings = new List<Booking>();
        private static int nextBookingId = 1;

        public void BookTicket(Flight flight, Passenger passenger)
        {
            var booking = new Booking
            {
                BookingId = nextBookingId++,
                Flight = flight,
                Passenger = passenger
            };
            bookings.Add(booking);
            Console.WriteLine("Booking confirmed! Your Booking ID: " + booking.BookingId);
        }

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

        public Booking GetBookingDetails(int bookingId)
        {
            return bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }

        public void ListBookings()
        {
            Console.WriteLine("Current Bookings:");
            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.BookingId}, Flight: {booking.Flight.FlightNumber}, Passenger: {booking.Passenger.Name}");
            }
        }
    }

    class AgencyBooking : IBooking
    {
        private static List<Booking> bookings = new List<Booking>();
        private static int nextBookingId = 1;

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

        public Booking GetBookingDetails(int bookingId)
        {
            return bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }

        public void ListBookings()
        {
            Console.WriteLine("Agency Current Bookings:");
            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.BookingId}, Flight: {booking.Flight.FlightNumber}, Passenger: {booking.Passenger.Name}");
            }
        }
    }

    class Passenger
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class Booking
    {
        public int BookingId { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
    }

}
