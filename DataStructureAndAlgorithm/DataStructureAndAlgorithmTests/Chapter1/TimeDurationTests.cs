using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureAndAlgorithm.Chapter1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.Chapter1.Tests
{
    [TestClass()]
    public class TimeDurationTests
    {
        [TestMethod()]
        public void GetTimeTest()
        {
            TimeDuration timeDuration = new TimeDuration();
            var seconds = timeDuration.GetTime();
            Console.WriteLine("Time:" + seconds);
        }
    }
}