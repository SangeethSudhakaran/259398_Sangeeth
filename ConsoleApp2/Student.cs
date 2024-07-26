namespace ConsoleApp2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /*public Student NewStudent()
        {
            Student Student = new Student(0,"");

            Console.WriteLine("Enter Student Id");
            Student.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            Student.Name = Console.ReadLine();

            Console.WriteLine("Enter Student Email");
            Student.Email = Console.ReadLine();

            return Student;

        }*/

        public void PrintStudent(Student Student)
        {
            Console.WriteLine("Student details");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Id : " + Student.Id);
            Console.WriteLine("Name" + Student.Name);
            Console.WriteLine("Email" + Student.Email);
            Console.WriteLine("--------------------------");
        }
    }
}
