using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class QuickSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr) => arr = Sort(arr).ToArray();

        private static List<T> Sort(T[] arr) 
        {
            if (arr.Length <= 1)
                return arr.ToList<T>();
            Random rand = new();
            int p = rand.Next(arr.Length);
            List<T> smaller = new();
            List<T> greaterOrEq = new();
            foreach (T t in arr)
            {
                if (t.CompareTo(arr[p]) < 0)
                    smaller.Add(t);
                else
                    greaterOrEq.Add(t);
            }
            smaller = Sort(smaller.ToArray());
            greaterOrEq = Sort(greaterOrEq.ToArray());
            smaller.AddRange(greaterOrEq);
            return smaller;
        }

        public static string BigO()
        {
            Console.WriteLine("Quick Sort: O(nlog(n))");
            return "O(nlog(n))";
        }
    }
}
