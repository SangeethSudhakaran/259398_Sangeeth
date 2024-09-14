namespace InheritanceDemo
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }


        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}");
        }
    }
}
