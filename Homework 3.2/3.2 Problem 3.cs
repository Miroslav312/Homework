using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedPair
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums1.Sort();
            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums2.Sort();
            List<int> Union = new List<int>();
            Union.AddRange(nums1);
            Union.AddRange(nums2);
            int temp = 0;
            for (int j = 0; j < Union.Count - 1; j++)
            {
                for (int i = 0; i < Union.Count - 1; i++)
                {
                    if (Union[i] > Union[i + 1])
                    {
                        temp = Union[i + 1];
                        Union[i + 1] = Union[i];
                        Union[i] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", Union));
        }
    }
}

