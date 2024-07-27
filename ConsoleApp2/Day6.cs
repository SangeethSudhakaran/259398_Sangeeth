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
        
        //Day6
        //Student professor 3 people
        public void Day6Example3_StudentProfessor3People()
        {
            StudentProfessorTest3People test = new StudentProfessorTest3People();
            test.Test3();
        }

        class StudentD6 : Person1
        {
            public StudentD6(string name) : base(name) { }

            public void Study()
            {
                Console.WriteLine("Study");
            }
        } 
        
        class TeacherD6 : Person1
        {
            public TeacherD6(string name) : base(name) { }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }


        public class StudentProfessorTest3People
        {
            public void Test3()
            {
                string[] name = new string[3];

                Console.WriteLine("Enter the first person name");
                name[0] = Console.ReadLine();
                Console.WriteLine("Enter the second person name");
                name[1] = Console.ReadLine();
                Console.WriteLine("Enter the third person name");
                name[2] = Console.ReadLine();

                Person1[] people = new Person1[3];
                people[0] = new StudentD6(name[0]);
                people[1] = new StudentD6(name[1]);
                people[2] = new TeacherD6(name[2]);

                foreach (var p in people)
                {
                    if(p is StudentD6 student)
                    {
                        student.Study();
                    }
                    if(p is TeacherD6 teacher)
                    {
                        teacher.Explain();
                    }
                }
                 
            }

        }

    }
}
