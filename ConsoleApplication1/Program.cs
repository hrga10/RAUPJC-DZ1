using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IntegerList listOfIntegers = new IntegerList();
            ListExample(listOfIntegers);
        }

        public static void ListExample(IntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            Console.WriteLine(listOfIntegers.Count);
            Console.ReadKey();
            listOfIntegers.Add(2); // [1 ,2]
            Console.WriteLine(listOfIntegers.Count);
            Console.ReadKey();
            listOfIntegers.Add(3); // [1 ,2 ,3]
            Console.WriteLine(listOfIntegers.Count);
            Console.ReadKey();
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            Console.WriteLine(listOfIntegers.Count);
            Console.ReadKey();
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            Console.WriteLine(listOfIntegers.Count);
            Console.WriteLine(listOfIntegers._internalStorage[4]);
            Console.ReadKey();
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            Console.WriteLine(listOfIntegers.Count);
            Console.WriteLine(listOfIntegers._internalStorage[4]);
            Console.ReadKey();
            listOfIntegers.Remove(5); // [2 ,3 ,4];
            Console.WriteLine(listOfIntegers._internalStorage[4]);
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.ReadKey();

            Console.WriteLine(listOfIntegers.Remove(100)); // false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
            Console.ReadKey();
        }
    }
}        

