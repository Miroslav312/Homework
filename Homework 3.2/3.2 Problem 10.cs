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
            List<int> list = new List<int>();
            list = Console.ReadLine().Split().Select(int.Parse).ToList();
            OddFilter(list);
        }

        public static void OddFilter(List<int> list)
        {
            int temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int encounters = 0;
                temp = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (temp == list[j])
                    {
                        encounters++;
                    }
                }
                if (encounters % 2 != 0)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == temp)
                        {
                            list.Remove(temp);
                        }
                    }
                }
            }
         Console.WriteLine(string.Join(", ",list));
        }
    }
}
