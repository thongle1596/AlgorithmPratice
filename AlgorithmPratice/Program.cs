using System;
using static AlgorithmPratice.Sort.SortAlgorithm;

namespace AlgorithmPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 2, 8, 5, 1, 6, 4, 15 };
            int[] b = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n = a.Length;
            int m = b.Length;

            Console.WriteLine("Before: " + "[{0}]", string.Join(", ", a));

            InterchangeSort(a, n);
            BubbleSort(a, n);
            InsertionSort(a, n);
            SelectionSort(a, n);
            QuickSort(a, 0, 7);

            Console.WriteLine("After: " + "[{0}]", string.Join(", ", a));
            Console.ReadKey();
        }
    }
}
