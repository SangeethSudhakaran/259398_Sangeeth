namespace ConsoleApp2
{
    public class Day6
    {
        //Day6
        //Constructor Destructor 
        public void Day6Example1_ConstructorDestructor()
        {
            Console.WriteLine("Constructor Destructor");
            Console.WriteLine("-------------------------------------------");

            Person1[] people = new Person1[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the person-" + (i + 1) + " name ");
                string name = Console.ReadLine();
                people[i] = new Person1(name);
            }

            Console.WriteLine("Persons List");
            foreach (Person1 person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }


        //Day6
        //Constructor Destructor 
        public void Day6Example2_MultilevelInheritance()
        {
            C c = new C();
        }

        //Day6
        //Student professor
        public void Day6Example2_StudentProfessor()
        {
            StudentProfessorTest test = new StudentProfessorTest();
            test.Test();
        }
    }
}
