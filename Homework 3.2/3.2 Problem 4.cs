using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Ordering
{
    class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            var splitedInput = input.Split().ToList();

            
            int pos = 0;
            int minPos = 0;
            string buff = string.Empty;

            while (pos < splitedInput.Count)
            {
                string minWord = splitedInput[pos];
                for (int i = pos + 1; i < splitedInput.Count; i++)
                {
                    if (string.Compare(minWord, splitedInput[i], false) > 0)
                    {
                        minWord = splitedInput[i];
                        minPos = i;
                    }
                }
                buff = splitedInput[pos];
                splitedInput[pos] = minWord;
                splitedInput[minPos] = buff;
                pos++;
                minPos = pos;

            }
            foreach (var word in splitedInput)
            {
                Console.Write(word + " ");
            }
        }
    }
}
