using System.Xml.Linq;

namespace FoodDeliveryManagement
{
    public class XMLHandler
    {
        //Method to create and write an XML file
        public static void CreateRestaurants(string filePath)
        {
            XElement restaurants = new XElement("restaurants",
                new XElement("restaurant",
                    new XElement("name", "Pizza Place"),
                    new XElement("address", "123 Main St"),
                    new XElement("rating", 4.5)
                ),
                new XElement("restaurant",
                    new XElement("name", "Pasta House"),
                    new XElement("address", "456 Elm St"),
                    new XElement("rating", 4.2)
                )
            );

            //Save the XML file
            restaurants.Save(filePath);
            Console.WriteLine("XML file created: " + filePath);
        }

        //Parse and display the restaurant data from the XML file
        public static void DisplayRestaurants(string filePath)
        {
            XElement restaurants = XElement.Load(filePath);
            foreach (var restaurant in restaurants.Elements("restaurant"))
            {
                string name = restaurant.Element("name").Value;
                string address = restaurant.Element("address").Value;
                string rating = restaurant.Element("rating").Value;
                Console.WriteLine($"Restaurant: {name},\t Address: {address},\t Rating: {rating}");
            }
        }
    }
}