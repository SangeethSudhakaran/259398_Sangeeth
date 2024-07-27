namespace ConsoleApp2
{
    public class MultilevelInheritance
    {
       
    }
    public class A
    {
        public A() { Console.WriteLine("Class A"); }
    }
    public class B : A
    {
        public B() { Console.WriteLine("Class B"); }
    }
    public class C : B
    {
        public C() { Console.WriteLine("Class C"); }
    }
}
