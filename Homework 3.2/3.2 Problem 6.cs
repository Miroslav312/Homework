using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_OR_Add_Method
{
    class Program
    {
        static void Main(string[] args)
        {
   
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int input = int.Parse(Console.ReadLine());
            List<int> newNumbers = new List<int>(numbers);
            bool exist = false; 

            for (int i = 0; i < newNumbers.Count; i++)
            {
                if (input == newNumbers[i])
                {
                    newNumbers.RemoveAt(i);
                    exist = true;
                }
            }
            if (!exist)
            {
                if (input > newNumbers[newNumbers.Count - 1])
                {
                    newNumbers.Insert(newNumbers.Count, input);
                };

                for (int i = 0; i < newNumbers.Count; i++)
                {
                    if (input < newNumbers[i])
                    {
                        newNumbers.Insert(i, input);
                        break;
                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            
            foreach (var number in newNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
