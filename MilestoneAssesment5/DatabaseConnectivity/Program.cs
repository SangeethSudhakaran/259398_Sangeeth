using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseConnectivity
{
    class Program
    {
        static void Main(string[] args)
        {
            //SQL server connection string
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SampleDB;Trusted_Connection=True;TrustServerCertificate=True;";

            //Fetch query
            string sqlQuery = "SELECT Id,Name,Email FROM Users";

            //List of users
            List<User> usersList = new List<User>();

            //Connecting to SQL server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Creating a connection
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                Console.WriteLine("Connecting to the Database");


                //Establishing connection
                try
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to Database!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting database\n" + ex.Message);
                }


                if (connection.State == ConnectionState.Open)
                {
                    //Execute the query and fetching data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read data until the end of data
                        Console.Write("Getting data from database");
                        while (reader.Read())
                        {
                            //Assgin the query results into class object
                            User user = new User
                            {
                                Id = reader.GetInt32(0), //Id is the first column
                                Name = reader.GetString(1), //Name is the second column
                                Email = reader.GetString(2) //Email is the third column
                            };

                            //Adding user into the list
                            usersList.Add(user);
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine("");
                }
            }

            //For loop through the list of users and print
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (var user in usersList)
            {
                Console.WriteLine($"Id: {user.Id}\t Name: {user.Name}\t Email: {user.Email}");
            }
        }
    }
}