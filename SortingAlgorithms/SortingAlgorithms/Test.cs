using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Test<T> where T : IComparable<T>
    {
        public static bool IsSorted(T[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        public static uint[] RandomInt(int size)
        {
            uint[] arr = new uint[size];
            Random rand = new();
            for(int i = 0; i < size; i++) 
                arr[i] = (uint)rand.Next();
            return arr;
        }
    }
}
