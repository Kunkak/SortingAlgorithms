using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class BogoSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr)
        {
            while (true)
            {
                if (IsSorted(arr))
                    return;
                Shuffle(ref arr);
            }
        }

        public static string BigO()
        {
            Console.WriteLine("Bogo Sort: O(n*n!)");
            return "O(n*n!)";
        }

        private static bool IsSorted(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        public static void Shuffle(ref T[] array)
        {
            Random rand = new();
            int i = array.Length, j;
            while (i > 1)
            {
                j = rand.Next(i--);
                (array[j], array[i]) = (array[i], array[j]);
            }
        }
    }
}
