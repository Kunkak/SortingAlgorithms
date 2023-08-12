using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingAlgorithms.Algorithms
{
    internal class BubbleSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr)
        {
            if (arr.Length <= 1)
                return;

            for (int sorted = arr.Length - 1; sorted >= 1; sorted--)
            {
                for (int i = 0; i < sorted; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                }
            }
        }

        public static new string BigO()
        {
            Console.WriteLine("Bubble Sort: O(n^2)");
            return "n^2";
        }
    }
}
