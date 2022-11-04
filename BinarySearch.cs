using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    internal class BinarySearch
    {
        public static int Search(List<int> list, int num, int left = 0, int right = 0, int middle = 0)
        {
            if (right == 0)
                right = list.Count - 1;
            if (middle == 0)
                middle = (left + right) / 2;

            if (list[middle] == num)
            {
                return middle;
            }
            else
            {
                if (list[middle] > num)
                {
                    right = middle - 1;
                    middle = (left + right) / 2;

                    return Search(list, num, left, right, middle);
                }
                else
                {
                    left = middle + 1;
                    middle = (left + right) / 2;

                    return Search(list, num, left, right, middle);
                }
            }
        }
    }
}
