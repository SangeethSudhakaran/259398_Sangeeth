using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Day8;

namespace ConsoleApp2
{
    public class Day9
    {
        //Day9
        //Example1 DictionaryAndHashSet
        public void Day9Example3_DictionaryAndHashSet()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Sangeeth");
            myDictionary.Add(2, "Sam");
            myDictionary.Add(3, "Joseph");

            HashSet<int> myHashset = new HashSet<int>();
            myHashset.Add(1);
            myHashset.Add(2);
            myHashset.Add(3);
            myHashset.Add(4);
            myHashset.Add(5);

            Queue<int> myQueue = new Queue<int>();
            Stack<int> myStack = new Stack<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);


            Console.WriteLine("Printing Dictionary....");
            foreach (var item in myDictionary)
            {
                Console.WriteLine("Slno:{0} -- Name {1}",item.Key,item.Value);
            }
            Console.WriteLine("------------------------------");


            Console.WriteLine("Printing Hashset....");
            foreach (var item in myHashset)
            {
                Console.WriteLine("Value:{0} ", item);
            }
            Console.WriteLine("------------------------------");

            Console.WriteLine("Printing Queue....");
            foreach (var item in myQueue)
            {
                Console.WriteLine("Queue Value:{0} ", item);
            }
            Console.WriteLine("------------------------------");


            Console.WriteLine("Printing Stack....");
            foreach (var item in myStack)
            {
                Console.WriteLine("Queue Value:{0} ", item);
            }
            Console.WriteLine("------------------------------");
        }
    }
}
