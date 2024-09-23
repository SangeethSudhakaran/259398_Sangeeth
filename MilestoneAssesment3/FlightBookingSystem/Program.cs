using FlightBookingSystem;
using System.Text.RegularExpressions;

class Program
{
    //List to manage flights data
    private static List<Flight> flights = new List<Flight>();

    //Flight array of length 5
    static Flight[] flightsArray = new Flight[5];

    //Array count
    static int arrayCount = 0;

    private static IBooking bookingSystem = new OnlineBooking();
    private static IBooking bookingSystemAgency = new AgencyBooking();

    //Flights data - csv file path
    private static string csvPath = "flightsList.csv";

    static void Main(string[] args)
    {
        //Loading flights data from saved csv file
        LoadFlightsFromCsv(csvPath);

        //Load menu
        ShowMenu();
    }

    static void ShowMenu()
    {
        //Menu
        while (true)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     Flight Booking System");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("      1. Display Flights");
            Console.WriteLine("      2. Display Flights - Sort by Fare");
            Console.WriteLine("      3. Display Flights - Group by Category");
            Console.WriteLine("      4. Display Flights - FlightNumber and Destination");
            Console.WriteLine("      5. Book Flight");
            Console.WriteLine("      6. Cancel Booking");
            Console.WriteLine("      7. Search Flights By Destination");
            Console.WriteLine("      8. Search Flights By Category");
            Console.WriteLine("      9. Add Flight");
            Console.WriteLine("     10. Update Flight");
            Console.WriteLine("     11. Remove Flight");
            Console.WriteLine("     12. List Bookings");
            Console.WriteLine("     13. Get Booking details by booking ID");
            Console.WriteLine("     14. Exit");
            Console.Write("     Choose an option: ");

            //User choice
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": DisplayFlights(); break;
                case "2": DisplayFlightsSortByFare(); break;
                case "3": DisplayFlightsGroupByCategory(); break;
                case "4": DisplayFlightsFlightNumberAndDestination(); break;
                case "5": BookFlight(); break;
                case "6": CancelBooking(); break;
                case "7": SearchFlightsByDestination(); break;
                case "8": SearchFlightsByCategory(); break;
                case "9": AddFlight(); break;
                case "10": UpdateFlight(); break;
                case "11": RemoveFlight(); break;
                case "12": bookingSystem.ListBookings(); bookingSystemAgency.ListBookings(); break;
                case "13": GetBookingDetailsByBookingID(); break;
                case "14": SaveFlightsToCsv(csvPath); return;
                default: Console.WriteLine("Invalid choice, please try again."); break;
            }
        }
    }

    //Display flights data
    static void DisplayFlights()
    {
        foreach (var flight in flights)
        {
            flight.DisplayDetails();
        }
    }

    //Sort the flight list by Fare
    static void DisplayFlightsSortByFare()
    {
        //Ordering flights by fare
        var sortedFlights = flights.OrderBy(f => f.BaseFare).ToList();

        Console.WriteLine("Flights available sorted by fare");
        foreach (var flight in sortedFlights)
        {
            string category = flight.GetType() == typeof(InternationalFlight) ? "International" : "Domestic";
            Console.WriteLine($" Flight number:{flight.FlightNumber}\t To:{flight.Destination}\t Fare:{flight.BaseFare}\t Category:{category} ");
        }
    }


    //Display Flights - FlightNumber, Destination
    static void DisplayFlightsFlightNumberAndDestination()
    {
        Console.WriteLine("Flights destination");
        foreach (var flight in flights)
        {
            Console.WriteLine($" Flight number:{flight.FlightNumber}\t To:{flight.Destination}");
        }
    }
    //Group the flight list by category
    static void DisplayFlightsGroupByCategory()
    {
        List<Flight> flightsForGrouping = flights;
        foreach (var flight in flightsForGrouping)
        {
            //Temporary category added for grouping
            flight.Category = (flight.GetType() == typeof(InternationalFlight)) ? "International" : "Domestic";
        }

        //Grouping flights by category
        var groupedFlights = flightsForGrouping.GroupBy(f => f.Category);

        Console.WriteLine("Flights grouped by Category:");
        foreach (var group in groupedFlights)
        {
            Console.WriteLine($"\nCategory: {group.Key}");
            foreach (var flight in group)
            {
                Console.WriteLine($" Flight number:{flight.FlightNumber}\t To:{flight.Destination}\t Fare:{flight.BaseFare}");
            }
        }
    }

    //Book flight
    static void BookFlight()
    {
        Console.Write("Agent booking? (Y/N) ");
        bool isAgentYes = Console.ReadLine().Trim().ToUpper() == "Y" ? true : false;

        //Check existing flight or not
        Console.Write("Enter Flight Number: ");
        var flightNumber = Console.ReadLine();

        if (!IsValidFlightNumber(flightNumber))
        {
            Console.WriteLine("Invalid flight number format.");
            return;
        }

        var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);

        if (flight == null)
        {
            Console.WriteLine("Flight not found.");
            return;
        }

        //Get passenger details        
        var passenger = new Passenger();
        Console.Write("Enter Passenger Name: ");
        passenger.Name = Console.ReadLine();

        Console.Write("Enter Passenger Email: ");
        passenger.Email = Console.ReadLine();

        //Validating passenger Email
        if (!IsValidEmail(passenger.Email))
        {
            Console.WriteLine("Invalid email format.");
            return;
        }

        Console.Write("Enter Passenger Phone: ");
        passenger.Phone = Console.ReadLine();

        //Validating passenger Phone
        if (!IsValidPhone(passenger.Phone))
        {
            Console.WriteLine("Invalid phone format.");
            return;
        }

        //Booking flight with valid flight and passenger data 
        if (isAgentYes)
        {
            bookingSystemAgency.BookTicket(flight, passenger);
        }
        else
        {
            bookingSystem.BookTicket(flight, passenger);
        }
    }

    //Cancel booking by booking Id - Agent or Online
    static void CancelBooking()
    {
        Console.Write("The booking done by Agent ? (Y/N) ");
        bool isAgentYes = Console.ReadLine().Trim().ToUpper() == "Y" ? true : false;

        Console.Write("Enter " + (isAgentYes ? "Agent" : "Online") + " Booking ID: ");
        int bookingId = int.Parse(Console.ReadLine());

        if (isAgentYes)
        {
            bookingSystemAgency.CancelBooking(bookingId);
        }
        else
        {
            bookingSystem.CancelBooking(bookingId);
        }
    }

    //Get booking details by booking Id - Agent or Online
    static void GetBookingDetailsByBookingID()
    {
        Console.Write("The booking done by Agent ? (Y/N) ");
        bool isAgentYes = Console.ReadLine().Trim().ToUpper() == "Y" ? true : false;

        Console.Write("Enter " + (isAgentYes ? "Agent" : "Online") + " Booking ID: ");
        int bookingId = int.Parse(Console.ReadLine());

        if (isAgentYes)
        {
            var booking = bookingSystemAgency.GetBookingDetails(bookingId);
            Console.WriteLine($"\nPassenger name : {booking.Passenger.Name} \tEmail : {booking.Passenger.Email}");
            booking.Flight.DisplayDetails();
        }
        else
        {
            var booking = bookingSystem.GetBookingDetails(bookingId);
            Console.WriteLine($"\nPassenger name : {booking.Passenger.Name} \tEmail : {booking.Passenger.Email}");
            booking.Flight.DisplayDetails();
        }
    }

    //Search flights by destination
    static void SearchFlightsByDestination()
    {
        Console.Write("Enter Destination: ");
        var destination = Console.ReadLine();

        var result = flights.Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase));

        if (!result.Any())
        {
            Console.WriteLine("No flights found for this destination.");
            return;
        }

        foreach (var flight in result)
        {
            flight.DisplayDetails();
        }
    }

    //Search flights by category
    static void SearchFlightsByCategory()
    {
        foreach (var flight in flights)
        {
            //Temporary category added for grouping
            flight.Category = (flight.GetType() == typeof(InternationalFlight)) ? "International" : "Domestic";
        }

        Console.Write("Enter Category (Domestic/International)");
        var category = Console.ReadLine();

        var result = flights.Where(f => f.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

        if (!result.Any())
        {
            Console.WriteLine("No flights found for this category.");
            return;
        }

        foreach (var flight in result)
        {
            flight.DisplayDetails();
        }
    }

    //Add new flight
    static void AddFlight()
    {
        var flight = CreateFlight();
        if (flight != null)
        {
            flights.Add(flight);
            AddFlightToArray(flight);
            Console.WriteLine("Flight added successfully.");
            SaveFlightsToCsv(csvPath);
        }
    }

    //Adding new flight to array
    static void AddFlightToArray(Flight flight)
    {
        if (arrayCount >= flightsArray.Length)
        {
            Console.WriteLine("Array is full, Flights added into list");
            return;
        }
        flightsArray[arrayCount++] = flight;
        Console.WriteLine("Flight added to array.");
    }

    //Update existing flight
    static void UpdateFlight()
    {
        Console.Write("Enter Flight Number to update: ");
        var flightNumber = Console.ReadLine();
        var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);

        if (flight == null)
        {
            Console.WriteLine("Flight not found.");
            return;
        }

        Console.WriteLine("Updating flight...");
        var updatedFlight = CreateFlight();
        if (updatedFlight != null)
        {
            flight.Destination = updatedFlight.Destination;
            flight.BaseFare = updatedFlight.BaseFare;
            Console.WriteLine("Flight updated successfully.");
            SaveFlightsToCsv(csvPath);
        }
    }

    //Remove flight
    static void RemoveFlight()
    {
        Console.Write("Enter Flight Number to remove: ");
        var flightNumber = Console.ReadLine();
        var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);

        if (flight != null)
        {
            flights.Remove(flight);
            RemoveFlightFromArray(flightNumber);
            Console.WriteLine("Flight removed successfully.");
            SaveFlightsToCsv(csvPath);
        }
        else
        {
            Console.WriteLine("Flight not found.");
        }
    }

    //Remove flight from array
    static void RemoveFlightFromArray(string flightNumber)
    {
        for (int i = 0; i < arrayCount; i++)
        {
            if (flightsArray[i].FlightNumber == flightNumber)
            {
                flightsArray[i] = null;
                Console.WriteLine("Flight removed from array.");
                return;
            }
        }
        Console.WriteLine("Flight not found.");
    }

    //Create flight - taking user inputs
    static Flight CreateFlight()
    {
        Console.Write("Enter Flight Number: ");
        var flightNumber = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(flightNumber) || !Regex.IsMatch(flightNumber, @"^FL\d{4}$"))
        {
            Console.WriteLine("Invalid Flight Number format.");
            return null;
        }

        Console.Write("Enter Destination: ");
        var destination = Console.ReadLine();

        Console.Write("Enter Flight Type (Domestic/International): ");
        var flightType = Console.ReadLine();

        Console.Write("Enter Base Fare: ");
        if (!decimal.TryParse(Console.ReadLine(), out var baseFare) || baseFare <= 0)
        {
            Console.WriteLine("Invalid fare.");
            return null;
        }

        //Adding flight as domestic or international
        Flight flight = flightType.Trim().ToUpper().Equals("DOMESTIC", StringComparison.OrdinalIgnoreCase)
            ? new DomesticFlight()
            : (Flight)new InternationalFlight();

        flight.FlightNumber = flightNumber;
        flight.Destination = destination;
        flight.BaseFare = baseFare;

        return flight;
    }

    //Loading flights data from csv file
    static void LoadFlightsFromCsv(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        //Read data 
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            Flight flight = parts[2].Trim().ToUpper() == "DOMESTIC"
                ? new DomesticFlight()
                : (Flight)new InternationalFlight();

            flight.FlightNumber = parts[0];
            flight.Destination = parts[1];
            flight.BaseFare = decimal.Parse(parts[3]);
            flights.Add(flight);
        }
        Console.WriteLine("Flights data loaded from CSV");
    }

    //Saving flight list to csv file
    static void SaveFlightsToCsv(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var flight in flights)
            {
                var line = $"{flight.FlightNumber},{flight.Destination},{flight.GetType().Name},{flight.BaseFare}";
                writer.WriteLine(line);
            }
        }
    }

    //Regex to Validate Flight Number
    static bool IsValidFlightNumber(string flightNumber)
    {
        return Regex.IsMatch(flightNumber, @"^FL\d{4}$");
    }

    //Regex to validate email
    static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    //regex to validate phone number
    static bool IsValidPhone(string phone)
    {
        return Regex.IsMatch(phone, @"^\d{10}$");
    }
}