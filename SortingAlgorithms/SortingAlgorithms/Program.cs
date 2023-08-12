using SortingAlgorithms;
using SortingAlgorithms.Algorithms;
using System;
using System.Diagnostics;
using System.Reflection;


Stopwatch t = new();
uint[] arr = Test<int>.RandomInt(1000000);

t.Start();
InsertionSort<uint>.Sort(ref arr);
t.Stop();


//InsertionSort<int>.BigO();
Console.WriteLine((Test<uint>.IsSorted(arr) ? "OK" : "Not sorted corectly") +
    $"\nSorting took {t.ElapsedMilliseconds}ms" +
    $"\nfor an array of size {arr.Length}");