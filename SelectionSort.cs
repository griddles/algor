using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    internal class SelectionSort
    {
        public static List<int> Sort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }   
                }
                int temp = list[min];
                list[min] = list[i];
                list[i] = temp;
            }

            return list;
        }
    }
}
