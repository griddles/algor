using System;
using System.Collections.Generic;
using System.Reflection;

namespace algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            List<int> smallList = MakeList(10);
            List<int> normalList = MakeList(100);
            List<int> bigList = MakeList(1000);
            List<int> biggerList = MakeList(10000);
            List<int> longAssList = MakeList(100000);

            List<List<int>> listlist = new List<List<int>>() { smallList, normalList, bigList, biggerList, longAssList };

            Console.WriteLine("Testing Bubble Sort:");

            foreach (List<int> list in listlist)
            {
                watch.Start();
                BubbleSort.Sort(list);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
            }

            Console.WriteLine("Testing Quick Sort:");

            foreach (List<int> list in listlist)
            {
                int[] arr = list.ToArray();
                watch.Start();
                QuickSort.Sort(arr, 0, arr.Length - 1);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
            }

            Console.WriteLine("Testing Selection Sort:");

            foreach (List<int> list in listlist)
            {
                watch.Start();
                SelectionSort.Sort(list);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
            }

            Console.WriteLine("Testing Merge Sort:");

            foreach (List<int> list in listlist)
            {
                watch.Start();
                MergeSort.Sort(list, 0, list.Count - 1);
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
            }

            Console.WriteLine("Testing Binary Search:");

            int i = 1;
            foreach (List<int> list in listlist)
            {
                watch.Start();
                BinarySearch.Search(list, Convert.ToInt32(new string('7', i)));
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
                i++;
            }

            Console.WriteLine("Testing Linear Search:");

            i = 1;
            foreach (List<int> list in listlist)
            {
                watch.Start();
                LinearSearch.Search(list, Convert.ToInt32(new string('7', i)));
                watch.Stop();
                Console.WriteLine($"Execution Time: {watch.Elapsed}");
                watch.Reset();
                i++;
            }
        }

        public static List<int> MakeList(int len)
        {
            List<int> list = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < len; i++)
            {
                int num = -1;
                while (num == -1 || list.Contains(num))
                {
                    num = rnd.Next(0, len);
                }
                list.Add(num);
            }

            return list;
        }

        static void printArray(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
