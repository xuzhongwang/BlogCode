using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i]+ " ") ;
            }
            Console.Write("\r\n");
        }
        public void Clear()
        {
            for (int i = 0; i < upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        public void BubbleSort()
        {
            for (int outer = 0; outer <= upper-1; outer++)
            {
                for (int inner = 0; inner < upper-outer; inner++)
                {
                    var left = arr[inner];
                    var right = arr[inner+1];
                    if (left>right)
                    {
                        arr[inner] = right;
                        arr[inner + 1] = left;
                    }
                }
                DisplayElements();
            }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        public void SelectionSort()
        {
            for (int outer = 0; outer <= upper; outer++)
            {
                var minIndex = outer;
                for (int inner = outer+1; inner <= upper; inner++)
                {
                    if (arr[inner]<arr[minIndex])
                    {
                        minIndex = inner;
                    }
                }
                var temp = arr[outer];
                arr[outer] = arr[minIndex];
                arr[minIndex] = temp;
                this.DisplayElements();
            }
        }
    }
}
