using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Filter(list);
        }

        public static void Filter(List<int> list)
        {
            List<int> copy = new List<int>();
            int pos = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > 0)
                {
                   copy.Add(list[i]);
                    pos++;
                }
            }
            Console.WriteLine(string.Join(", ", copy));
        }
    }
}
