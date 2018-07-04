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
            List<int> encounteredNum = new List<int>();
            nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int MaxEncounters = 1;
            int Encounters = 1;
            int item = 0;
            int pos = 0;
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    Encounters++;
                    if (Encounters > MaxEncounters)
                    {
                        MaxEncounters = Encounters;
                        item = nums[pos];
                    }
                }
                else
                {
                    Encounters = 1;
                }
                pos++;
                if (MaxEncounters == 1)
                {
                    item = nums[0];
                }
            }
            for (int i = 0; i < MaxEncounters; i++)
            {
                encounteredNum.Add(item);
            }
            Console.WriteLine(string.Join(", ", encounteredNum));
        }
    }
}
