namespace ClassesAndObjects
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            Console.WriteLine("User details");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" Username : " + Username + "\n Email: " + Email);
        }

    }
}
