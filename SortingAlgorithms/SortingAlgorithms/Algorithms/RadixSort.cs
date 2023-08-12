using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class RadixSort
    {
        public static void Sort(ref uint[] arr) // im not sure if this works corectly, i mean, time performance is not good
        {
            if (arr.Length < 1)
                return;

            uint max = arr.Max();
            int digits = (int)Math.Floor(Math.Log10(max) + 1);

            arr = Bucket(arr.ToList(), digits).ToArray();
        }

        private static List<uint> Bucket(List<uint> arr, int index)
        {
            if (index < 0 || arr.Count == 0)
                return arr;

            List<uint>[] buckets = new List<uint>[10];
            for(int i = 0; i < 10; i++)
                buckets[i] = new();

            foreach (uint item in arr)
                buckets[(item / (uint)Math.Pow(10, index)) % 10].Add(item);

            index--;
            for (int i = 0; i < 10; i++)
                buckets[i] = Bucket(buckets[i], index);

            for(int i = 1; i < 10; i++)
                buckets[0].AddRange(buckets[i]);

            return buckets[0];
        }
    }
}