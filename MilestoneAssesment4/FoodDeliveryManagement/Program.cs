using FoodDeliveryManagement;
using RestaurantAPI.Models;
using System.Net.Http.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string xmlPath = "restaurants.xml";
        string csvPath = "menu.csv";
        string excelPath = "restaurants.xlsx";
        string jsonPath = "restaurants.json";
        string boxFileName;
        bool exit = false;
        while (!exit)
        {
            //Menu
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  Welcome to the Food Delivery System");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("     1.  Create Restaurents   (XML)");
            Console.WriteLine("     2.  Display Restaurents  (XML)");
            Console.WriteLine("     3.  Create menu items    (CSV)");
            Console.WriteLine("     4.  Display menu items   (CSV)");
            Console.WriteLine("     5.  Create Restaurents   (EXCEL)");
            Console.WriteLine("     6.  Display Restaurents  (EXCEL)");
            Console.WriteLine("     7.  Create Restaurents   (JSON)");
            Console.WriteLine("     8.  Display Restaurents  (JSON)");
            Console.WriteLine("     9.  REST API Consumption");
            Console.WriteLine("     10. ServiceNow API");
            Console.WriteLine("     11. Box API Upload file");
            Console.WriteLine("     12. Box API Download file");
            Console.WriteLine("     13. Exit");
            Console.WriteLine("     Please select an option: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": XMLHandler.CreateRestaurants(xmlPath); break;
                case "2": XMLHandler.DisplayRestaurants(xmlPath); break;
                case "3": CSVHandler.CreateMenuItems(csvPath); break;
                case "4": CSVHandler.ParseCSV(csvPath); break;
                case "5": ExcelHandler.CreateExcelFile(excelPath); break;
                case "6": ExcelHandler.ReadExcelFile(excelPath); break;
                case "7": JSONHandler.CreateJson(jsonPath); break;
                case "8": JSONHandler.ParseJSON(jsonPath); break;
                case "9": await RestaurantDataRestAPI(); break;
                case "10": await ServiceNowAPI(); break;
                case "11": await BoxAPIUploadFile(); break;
                case "12": await BoxAPIDownloadFile(); break;
                case "13": exit = true; break;
                default: Console.WriteLine("Invalid option, please try again."); break;
            }
            Console.WriteLine();
        }

        //Calling Restaurant Data RestAPI
        async Task RestaurantDataRestAPI()
        {
            ShowDelayedMessage("fetching data from API.");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7076/");

                var response = await client.GetAsync("api/Restaurants/GetAll");

                if (response.IsSuccessStatusCode)
                {
                    var restaurants = await response.Content.ReadFromJsonAsync<List<Restaurant>>();

                    Console.WriteLine("\n-------------------------------------");
                    foreach (var restaurant in restaurants)
                    {
                        Console.WriteLine($"Restaurant Name: {restaurant.Name},\t Address: {restaurant.Address},\t Rating: {restaurant.Rating}");
                    }
                }
                else
                {
                    Console.WriteLine("Error retrieving data.");
                }
            }
        }

        //Upload file to box
        async Task BoxAPIUploadFile()
        {
            Console.WriteLine("please enter file path (Full path required)");
            boxFileName = Console.ReadLine();
            BoxAPI boxAPI = new BoxAPI();
            var status = await boxAPI.UploadFileToBox(boxFileName);
            Console.WriteLine(status);
        }

        //Download file from box
        async Task BoxAPIDownloadFile()
        {
            Console.WriteLine("please enter file Id");
            boxFileName = Console.ReadLine();
            BoxAPI boxAPI = new BoxAPI();
            var status = await boxAPI.DownloadFileFromBox(boxFileName);
            Console.WriteLine(status);
        }

        //fetch data from ServiceNow API
        async Task ServiceNowAPI()
        {
            ShowDelayedMessage("fetching data from ServiceNow API.");
            var api = new ServiceNowApi();
            var incidents = await api.GetIncidentData();

            if (incidents != null)
            {
                foreach (var incident in incidents)
                {
                    Console.WriteLine($"Incident ID: {incident.Number}, Short Description: {incident.Short_description.Replace("-Restaurant", "")}");
                }
            }
        }

        //Custom console message for styling
        void ShowDelayedMessage(string val)
        {
            Console.Write(val);
            Console.Write("."); Thread.Sleep(500);
            Console.Write("..."); Thread.Sleep(500);
            Console.Write("......"); Thread.Sleep(1000);
            Console.Write(".........."); Thread.Sleep(2000);
            Console.WriteLine("");
        }
    }
}