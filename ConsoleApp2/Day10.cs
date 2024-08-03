using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Day10
    {
        //Day10
        //Example1 BlockingCollections
        public void Day10Example2_BlockingCollections()
        {
            BlockingCollection<int> blkCollection = new BlockingCollection<int>();
            blkCollection.Add(1);
            blkCollection.Add(2);

            if (blkCollection.TryAdd(3, TimeSpan.FromSeconds(5)))
            {
                Console.WriteLine("Item added");
            }
            else
            {
                Console.WriteLine("Item is not added");
            }

            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(1);
            stack.Push(2);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }


        //Day10
        //Example2 FileHandling
        public void Day10Example2_FileHandling()
        {
            string filePath = "c:\a.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            byte[] byteData = Encoding.Default.GetBytes("Hello I'm Sangeeth");
            fileStream.Write(byteData, 0, byteData.Length);
            fileStream.Close();
        }

        //Day11
        //Example3 FileHandling1
        public void Day10Example3_FileHandling1()
        {
            string filePath = "d:\\sample.txt";
            StreamWriter streamWriter = new StreamWriter(filePath);
            Console.WriteLine("Please enter the text to write");
            string inputData = Console.ReadLine();
            streamWriter.WriteLine(inputData);
            streamWriter.Flush();
            streamWriter.Close();
        }

        //Day10
        //Example3 ReadFromFile
        public void Day10Example3_ReadFromFile()
        {
            string filePath = "d:\\sample.txt";
            StreamReader streamReader = new StreamReader(filePath);
            Console.WriteLine("Data from file...");
            StreamWriter streamWriter = new StreamWriter(filePath);
        }


        //Day10
        //Example3 CopyFile
        public void Day10Example3_CopyFile()
        {
            string sourceFilePath = "d:\\file1.txt";
            string destinationFilePath = "d:\\demo\file1.txt";
            string newFilePath = "d:\\demo\file1New.txt";
        }
    }
}
