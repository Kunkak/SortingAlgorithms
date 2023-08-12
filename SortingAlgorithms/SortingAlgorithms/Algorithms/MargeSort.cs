using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class MargeSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr)
        {
            arr = Split(arr);
        }

        private static T[] Split(T[] arr)
        {
            if (arr.Length == 1)
                return arr;
            int half = arr.Length / 2;
            T[] arr1 = new T[half];
            T[] arr2 = new T[arr.Length - half];

            int i = -1;
            foreach (T t in arr)
            {
                if(++i < half)
                    arr1[i] = t;
                else 
                    arr2[i - half] = t;
            }
            
            var s1 = Split(arr1);
            var s2 = Split(arr2);

            return Marge(s1 , s2);
        }
        private static T[] Marge(T[] arr1, T[] arr2)
        {
            int i = 0;
            int j = 0;
            T[] arr = new T[arr1.Length + arr2.Length];

            while (i < arr1.Length || j < arr2.Length)
            {
                if (i == arr1.Length)
                    arr[i + j] = arr2[j++];
                else if (j == arr2.Length)
                    arr[i + j] = arr1[i++];
                else
                {
                    if (arr1[i].CompareTo(arr2[j]) < 0)
                        arr[i + j] = arr1[i++];
                    else
                        arr[i + j] = arr2[j++];
                }
            }
            return arr;
        }

        public static new string BigO()
        {
            Console.WriteLine("Marge Sort: O(nlog(n))");
            return "nlog(n)";
        }
    }
}
