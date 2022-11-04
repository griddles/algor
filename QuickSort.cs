using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithms
{
    internal class QuickSort
    {
        static void Swap(List<int> arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int Part(List<int> arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        public static List<int> Sort(List<int> arr, int low, int? high)
        {
            if (high == null)
            {
                high = arr.Count - 1;
            }

            if (low < high)
            {
                int pi = Part(arr, low, (int)high);

                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }

            return new List<int>();
        }
    }
}
