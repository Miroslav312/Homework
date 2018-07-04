using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Plat = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Tc_Ts = new int[2];
            Tc_Ts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Ec_Es = new int[2];
            Ec_Es = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort(Plat, Tc_Ts, Ec_Es);

        }

        public static void Sort(int[] items,int[] Tc_Ts, int[] Ec_Es)
        {
            int CC = 0;
            int CS = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length-1; j++)
                {
                    CC++;
                    if (items[j] > items[j + 1])
                    {
                        CS++;
                        int temp = 0;
                        temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
            int time = Tc_Ts[0] * CC + Tc_Ts[1] * CS;
            int effort = Ec_Es[0] * CC + Ec_Es[1] * CS;
            Console.WriteLine($"броят сравнения {CC}, броят размествания {CS} ");
            Console.WriteLine($"общото време за сортиране на масива {time} ");
            Console.WriteLine($"общото усилие за сортиране на масива  {effort} ");
        }
    }
}
