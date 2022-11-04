using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithms
{
    internal class QuickSort
    {
        static void Swap(IList<int> arr, int i, int j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        static int Part(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] >= pivot)
                {
                    continue;
                }
                i++;
                Swap(arr, i, j);
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        public static void Sort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int pi = Part(arr, low, high);

            Sort(arr, low, pi - 1);
            Sort(arr, pi + 1, high);
        }
    }
}
