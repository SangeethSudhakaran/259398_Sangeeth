namespace Encapsulation
{
    // User Class with encapsulation
    public class User
    {
        // Private fields
        private string username;
        private string password;
        private string email;

        // Public property for Username (read-only)
        public string Username
        {
            get { return username; }
        }

        // Public property for Email (read and write with validation)
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    Console.WriteLine("Error: Invalid email format.");
            }
        }

        // Constructor to initialize fields
        public User(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            Email = email;
        }

        // Method to update user password (encapsulated)
        public void UpdatePassword(string currentPassword, string newPassword)
        {
            if (password == currentPassword)
            {
                password = newPassword;
                Console.WriteLine("Password updated successfully.");
            }
            else
            {
                Console.WriteLine("Error: Current password is incorrect.");
            }
        }

        // Private method to check if an email format is valid (encapsulation)
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
