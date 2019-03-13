using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.Chapter1
{
    public class TimeDuration
    {
        public double GetTime()
        {
            int[] nums = new int[100000];
            //TimeSpan duration;
            Timing timing = new Timing();
            timing.StartTime();
            BuildArray(nums);
            DisplayNums(nums);
            DisplayNums(nums);
            DisplayNums(nums);
            timing.StopTime();
            //duration = Process.GetCurrentProcess().TotalProcessorTime;
            return timing.Result().TotalSeconds;
        }

        public void BuildArray(int[] arr)
        {
            for (int i = 0; i < 99999; i++)
            {
                arr[i] = i;
            }
        }

        public void DisplayNums(int[] arr)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                Console.Write(arr[i] + "");
            }
        }
    }
}
