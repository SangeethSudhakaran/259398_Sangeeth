using RestaurantAPI.Models;

namespace RestaurantAPI.Data
{
    public static class RestaurantRepository
    {

        //Restaurant data
        private static List<Restaurant> Restaurants = new List<Restaurant>
    {
        new Restaurant {Id = 100, Name = "Pizza Place", Address = "123 Main St", Rating = 4.5 },
        new Restaurant {Id = 101, Name = "Common Grill", Address = "456 Elm St 5", Rating = 4.2 },
        new Restaurant {Id = 102, Name = "The Modern", Address = "457 Elm St6", Rating = 3.8 },
        new Restaurant {Id = 103,  Name = "Gramercy", Address = "458 Elm St7", Rating = 4.0 },
        new Restaurant {Id = 104,  Name = "Little Italy", Address = "459 Elm St8", Rating = 3.9 },
        new Restaurant {Id = 105,  Name = "Trinity Place", Address = "460 Elm St9", Rating = 4.1 },
        new Restaurant {Id = 106,  Name = "Schilling", Address = "461 Elm St11", Rating = 5.0 },
        new Restaurant {Id = 107,  Name = "Le Coucou", Address = "462 Elm St12", Rating = 3.5 }
    };

        //Get all data 
        public static List<Restaurant> GetAll() => Restaurants;

        //Get Restaurant by name
        public static Restaurant Get(string name) => Restaurants.FirstOrDefault(r => r.Name == name);

        //Add new Restaurant
        public static void Add(Restaurant restaurant) => Restaurants.Add(restaurant);

        //Update existing Restaurant
        public static void Update(string name, Restaurant updatedRestaurant)
        {
            var existing = Get(name);
            if (existing != null)
            {
                existing.Name = updatedRestaurant.Name;
                existing.Address = updatedRestaurant.Address;
                existing.Rating = updatedRestaurant.Rating;
            }
        }

        //Delete Restaurant
        public static void Delete(string name)
        {
            var restaurant = Get(name);
            if (restaurant != null)
            {
                Restaurants.Remove(restaurant);
            }
        }
    }

}
