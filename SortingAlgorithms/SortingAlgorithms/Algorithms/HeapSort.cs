using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class HeapSort<T> where T : IComparable<T>
    {
        public static void Sort(ref T[] arr)
        {
            if (arr.Length < 3)
            {
                InsertionSort<T>.Sort(ref arr);
                return;
            }

            BuildHeap(ref arr, arr.Length - 1);
            for (int i = arr.Length - 1; i > 3; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(ref arr, i);
            }
            (arr[0], arr[3]) = (arr[3], arr[0]);
            SortLast3(ref arr);
        }

        public static string BigO()
        {
            Console.WriteLine("Heap Sort: O(n^2)");
            return "O(n^2)";
        }

        private static void BuildHeap(ref T[] arr, int end)
        {
            bool hasChanged = true;
            int parent;

            while (hasChanged)
            {
                hasChanged = false;

                for(int i = end; i > 0; i--)
                {
                    parent = (i + 1) / 2 - 1;
                    if (arr[i].CompareTo(arr[parent]) > 0)
                    {
                        hasChanged = true;
                        (arr[i], arr[parent]) = (arr[parent], arr[i]);
                    }
                }
            }
        }

        private static void Heapify(ref T[] arr, int end)
        {
            int i = 0, next = arr[1].CompareTo(arr[2]) < 0 ? 2 : 1;
            while(next <= end)
            {
                if(arr[i].CompareTo(arr[next]) < 0)
                {
                    (arr[i], arr[next]) = (arr[next], arr[i]);
                    i = next;
                    if(i * 2 + 2 < end)
                        next = arr[i * 2 + 1].CompareTo(arr[i * 2 + 2]) < 0 ? i * 2 + 2 : i * 2 + 1;
                    else if(i * 2 == end)
                        next = i * 2 + 1;
                }
                else
                    break;
            }
        }

        private static void SortLast3(ref T[] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                int j = i;
                while (j > 0 && arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }
    }
}