namespace ConsoleApp2
{
    public class Person1
    {
        public string Name { get; set; }

        public Person1(string name)
        {
            Name = name;
        }

        ~Person1()
        {
            Name = string.Empty;
        }

        public override string ToString()
        {
            return "Hello my name is - " + Name;
        }
    }
}
