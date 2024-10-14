using Newtonsoft.Json.Linq;
using RestaurantAPI.Models;
using System.Net.Http.Json;

namespace FoodDeliveryManagement
{
    public class JSONHandler
    {
        //Create and write a JSON file with restaurant reviews
        public static void CreateJson(string filePath)
        {
            var reviews = new JObject(
                new JProperty("reviews",
                    new JArray(
                        new JObject(
                            new JProperty("restaurant", "Pizza hut"),
                            new JProperty("review", "Great pizza!"),
                            new JProperty("rating", 4)
                        ),
                        new JObject(
                            new JProperty("restaurant", "Pasta House"),
                            new JProperty("review", "Too spicy."),
                            new JProperty("rating", 2)
                        ),
                        new JObject(
                            new JProperty("restaurant", "Burger hub"),
                            new JProperty("review", "Yummy burgers!"),
                            new JProperty("rating", 5)
                        )
                    )
                )
            );

            //Writing JSON to file
            File.WriteAllText(filePath, reviews.ToString());
            Console.WriteLine("JSON file created: " + filePath);
        }

        //Display reviews from the JSON file
        public static void ParseJSON(string jsonFilePath)
        {
            var json = File.ReadAllText(jsonFilePath);
            JObject data = JObject.Parse(json);

            foreach (var review in data["reviews"])
            {
                string restaurant = review["restaurant"].ToString();
                string reviewText = review["review"].ToString();
                int rating = (int)review["rating"];
                Console.WriteLine($"Review for {restaurant}: {reviewText},\t Rating: {rating}");
            }
        }


        public async Task DisplayRestaurantDataFromAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000");

                var response = await client.GetAsync("api/restaurants");

                if (response.IsSuccessStatusCode)
                {
                    var restaurants = await response.Content.ReadFromJsonAsync<List<Restaurant>>();

                    foreach (var restaurant in restaurants)
                    {
                        Console.WriteLine($"Name: {restaurant.Name}, Address: {restaurant.Address}, Rating: {restaurant.Rating}");
                    }
                }
                else
                {
                    Console.WriteLine("Error retrieving data.");
                }
            }
        }


    }

}
