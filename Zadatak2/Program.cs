using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> listOfX = new GenericList<int>();
            ListExample(listOfX);
        }

        public static void ListExample(GenericList<int> listOfX)
        {
            listOfX.Add(1); // [1]
            Console.WriteLine(listOfX.Count);
            Console.ReadKey();
            listOfX.Add(2); // [1 ,2]
            Console.WriteLine(listOfX.Count);
            Console.ReadKey();
            listOfX.Add(3); // [1 ,2 ,3]
            Console.WriteLine(listOfX.Count);
            Console.ReadKey();
            listOfX.Add(4); // [1 ,2 ,3 ,4]
            Console.WriteLine(listOfX.Count);
            Console.ReadKey();
            listOfX.Add(5); // [1 ,2 ,3 ,4 ,5]
            Console.WriteLine(listOfX.Count);
            Console.WriteLine(listOfX._internalStorage[4]);
            Console.ReadKey();
            listOfX.RemoveAt(0); // [2 ,3 ,4 ,5]
            Console.WriteLine(listOfX.Count);
            Console.WriteLine(listOfX._internalStorage[4]);
            Console.ReadKey();
            listOfX.Remove(5); // [2 ,3 ,4];
            Console.WriteLine(listOfX._internalStorage[4]);
            Console.WriteLine(listOfX.Contains(100));
            Console.WriteLine(listOfX.Count); // 3
            Console.ReadKey();

            Console.WriteLine(listOfX.Remove(100)); // false
            Console.WriteLine(listOfX.RemoveAt(5)); // false
            listOfX.Clear(); // []
            Console.WriteLine(listOfX.Count); // 0
            Console.ReadKey();
        }
    }
}
