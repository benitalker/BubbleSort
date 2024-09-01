using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10,5,8,3,9,1,2,7,4,6 };

            var sortedArray = BubbleSort(arr);

            Console.WriteLine("Sorted:");
            Console.WriteLine(string.Join(" ", sortedArray));
        }

        static int[] BubbleSort(int[] array)
        {
            int[] arr = array.ToArray();
            bool swapped;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return arr;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
