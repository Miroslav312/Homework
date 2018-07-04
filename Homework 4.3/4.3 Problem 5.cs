using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Encounters = 1;
            int MaxEncounters = 1;
            int item = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Encounters++;
                    }
                }
                if (Encounters >= MaxEncounters && arr[i] > item)
                {
                    MaxEncounters = Encounters;
                    item = arr[i];
                }
                Encounters = 0;
            }
            Console.WriteLine($"{MaxEncounters} {item}");
        }
    }
}
