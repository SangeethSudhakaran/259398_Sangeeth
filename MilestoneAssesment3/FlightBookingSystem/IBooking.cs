namespace FlightBookingSystem
{
    interface IBooking
    {
        void BookTicket(Flight flight, Passenger passenger);
        void CancelBooking(int bookingId);
        Booking GetBookingDetails(int bookingId);
        void ListBookings();
    }
}
