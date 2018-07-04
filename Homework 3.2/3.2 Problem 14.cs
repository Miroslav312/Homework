using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int Encounters = 1;
            List<int> Majorants = new List<int>();
            int pos = 0;
            bool ListNotEmpty = false;
            int N = (nums.Count / 2) + 1;
            nums.Sort();
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    Encounters++;
                    if (Encounters == N)
                    {
                        Majorants.Add(nums[pos]);
                        ListNotEmpty = true;
                    }
                }
                else
                {
                    Encounters = 1;
                }
                pos++;
            }
            if (ListNotEmpty == false)
            {
                Console.WriteLine("the majorant does not exist!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", Majorants));
            }
        }
    }
}
