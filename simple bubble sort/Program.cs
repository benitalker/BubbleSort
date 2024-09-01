using System;
using System.Linq;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 5, 8, 3, 9, 1, 2, 7, 4, 6 };

            // Perform Bubble Sort
            var sortedBubble = Sorters.BubbleSort(array);
            Console.WriteLine("Bubble Sorted: " + string.Join(" ", sortedBubble));

            // Perform Selection Sort
            var sortedSelection = Sorters.SelectionSort(array);
            Console.WriteLine("Selection Sorted: " + string.Join(" ", sortedSelection));

            Console.ReadKey();
        }
    }

    public static class Sorters
    {
        public static int[] BubbleSort(int[] sequence)
        {
            var arr = sequence;
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }

            return arr;
        }

        public static int[] SelectionSort(int[] sequence)
        {
            var arr = sequence;
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(ref arr[i], ref arr[minIndex]);
                }
            }

            return arr;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
