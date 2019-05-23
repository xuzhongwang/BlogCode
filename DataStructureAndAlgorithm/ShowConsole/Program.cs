using DataStructureAndAlgorithm;
using DataStructureAndAlgorithm.Chapter1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CArray cArray = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
            {
                cArray.Insert(rnd.Next(0, 1000));
            }
            Console.WriteLine("Before Sorting:");
            cArray.DisplayElements();
            Console.WriteLine("During Sorting:");
            cArray.SelectionSort();            
            Console.WriteLine("After Sorting:");
            cArray.DisplayElements();
            Console.ReadKey();
        }
    }
}
