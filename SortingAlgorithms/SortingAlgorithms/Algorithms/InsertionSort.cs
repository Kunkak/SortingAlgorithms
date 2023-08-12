using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class InsertionSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr) 
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }
        public void SortDescending(ref T[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) > 0)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }
        public static string BigO()
        {
            Console.WriteLine("Insertion Sort: O(n^2)");
            return "O(n^2)";
        }
    }
}
