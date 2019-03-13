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
            TimeDuration timeDuration = new TimeDuration();
            var seconds = timeDuration.GetTime();
            Console.WriteLine("Time:" + seconds);
            Console.ReadKey();
        }
    }
}
