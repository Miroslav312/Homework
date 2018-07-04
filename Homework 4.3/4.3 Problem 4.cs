using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inversions = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j] && i < j)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                        inversions++;
                    }
                }
            }
            if (inversions == 0)
            {
                Console.WriteLine($"array alredy sorted");
            }
            else
            {
                Console.WriteLine($"number of inversions {inversions}");
            }
        }
    }
}
