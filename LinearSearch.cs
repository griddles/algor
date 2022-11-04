using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace algorithms
{
    internal class LinearSearch
    {
        public static int Search(List<int> list, int num)
        {
            int i = 0;
            while (true)
            {
                if (list[i] == num)
                {
                    return i;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
