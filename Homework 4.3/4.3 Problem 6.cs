using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = num; i > 0; i--)
            {
                list.Add(i);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(list);
            stopwatch.Stop();
            Console.WriteLine($"Time for sorted list {stopwatch.Elapsed} : Bubble Sort");
            stopwatch.Reset();

            stopwatch.Start();
            SelectionSort(list);
            stopwatch.Stop();
            Console.WriteLine($"Time for sorted list {stopwatch.Elapsed} : Selection Sort");
            stopwatch.Reset();

            List<int> list1 = new List<int>();
            for (int i = 2; i < num; i++)
            {
                list1.Add(i);
            }
            
            stopwatch.Start();
            BubbleSort(list1);
            stopwatch.Stop();
            Console.WriteLine($"Time for N to 1 list {stopwatch.Elapsed} : Bubble Sort");
            stopwatch.Reset();

            stopwatch.Start();
            SelectionSort(list1);
            stopwatch.Stop();
            Console.WriteLine($"Time for N to 1 list {stopwatch.Elapsed} : Selection Sort");
            stopwatch.Reset();

            List<int> list2 = new List<int>();
            Random rng = new Random();
            
            for (int i = 0; i < num; i++)
            {
                int randomnumber = rng.Next(-1000000000, 1000000000);
                list2.Add(randomnumber);
            }

            stopwatch.Start();
            BubbleSort(list2);
            stopwatch.Stop();
            Console.WriteLine($"Time for random list {stopwatch.Elapsed} : Bubble Sort");
            stopwatch.Reset();

            stopwatch.Start();
            SelectionSort(list2);
            stopwatch.Stop();
            Console.WriteLine($"Time for random list {stopwatch.Elapsed} : Selection Sort");
            stopwatch.Reset();
            int increment = 1;
            List<int> list3 = new List<int>();
            for (int i = 0; i < num; i++)
            {
                if (increment == 11)  increment = 1; 
                list3.Add(increment);
                increment++;
            }
            stopwatch.Start();
            BubbleSort(list3);
            stopwatch.Stop();
            Console.WriteLine($"Time for 1 to 10 list {stopwatch.Elapsed} : Bubble Sort");
            stopwatch.Reset();

            stopwatch.Start();
            SelectionSort(list3);
            stopwatch.Stop();
            Console.WriteLine($"Time for 1 to 10 list {stopwatch.Elapsed} : Selection Sort");
            stopwatch.Reset();

        }

        static void BubbleSort(List<int> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
                {
                    if (items[j].CompareTo(items[j + 1])>0)
                    {
                        int temp = 0;
                        temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(List<int> collection)
        {
            for (int index = 0; index < collection.Count; index++)
            {
                List<int> ListA = new List<int>();
                ListA = collection;
                int min = index;
                for (int curr = index + 1; curr < collection.Count; curr++)
                {
                    if (collection[curr] < collection[min])
                    {
                        min = curr;
                    }
                }
                int temp = collection[index];
                collection[index] = collection[min];
                collection[min] = temp;
            }
        }
    }
}
