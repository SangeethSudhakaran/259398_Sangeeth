namespace FoodDeliveryManagement
{
    public class CSVHandler
    {
        //Method to create and write a CSV file with menu items
        public static void CreateMenuItems(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                //Writing the header
                writer.WriteLine("Item,Price");

                //Writing menu items
                writer.WriteLine("Margherita Pizza,9.99");
                writer.WriteLine("Garlic Bread,3.99");
                writer.WriteLine("Spaghetti Bolognese,12.99");
                writer.WriteLine("Caesar Salad,7.49");

                Console.WriteLine("CSV file created: " + filePath);
            }
        }

        //Method to parse and display menu items from the CSV file
        public static void ParseCSV(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[0] != "Item") //Skipping header row
                    {
                        Console.WriteLine($"Item: {values[0]},\t Price: {values[1]}");
                    }
                }
            }
        }
    }
}