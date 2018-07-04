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
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int Minimum = int.MaxValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < Minimum)
                {
                    Minimum = nums[i];
                }
            }
            Console.WriteLine(Minimum);
        }
    }
}

