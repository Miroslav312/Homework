using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            double Sum = 0;
            double Average = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                Sum += nums[i];
            }
            Average = Sum / nums.Count;
            Console.WriteLine($"Sum of the numbers is {Sum} and the average is {Average,00}");
        }
    }
}
