using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    internal class MergeSort
    {
        public static void Merge(List<int> list, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = list[left + i];
            }
                
            for (j = 0; j < n2; ++j)
            {
                R[j] = list[middle + 1 + j];
            }
                
            i = 0;
            j = 0;

            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    list[k] = L[i];
                    i++;
                }
                else
                {
                    list[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                list[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                list[k] = R[j];
                j++;
                k++;
            }
        }

        public static void Sort(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Sort(list, left, middle);
                Sort(list, middle + 1, right);

                Merge(list, left, middle, right);
            }
        }
    }
}
