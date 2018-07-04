using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[2];
            nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool firstcylceEnd = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (firstcylceEnd == true)
                {
                    for (int j = 0; j <= nums[i - 1]; j++)
                    {
                        Console.WriteLine($"[{j}, {nums[i]}]");
                    }
                }
                else 
                {
                    for (int j = 0; j <= nums[i + 1]; j++)
                    {
                        Console.WriteLine($"[{nums[i]}, {j}]");
                    }
                }
                firstcylceEnd = true;
            }
        }
    }
}
