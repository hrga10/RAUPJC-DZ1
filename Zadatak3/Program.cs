using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(4);
            Console.WriteLine(list.Count);
            Console.ReadKey();
            
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}
