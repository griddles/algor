using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    internal class BubbleSort
    {
        public static List<int> Sort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                } 
            }
            return list;
        }
    }
}
