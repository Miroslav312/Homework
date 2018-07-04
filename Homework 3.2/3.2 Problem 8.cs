using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticStack<int> stack = new StaticStack<int>();
            stack.Push(4); stack.Push(2); stack.Push(3); stack.Push(6);
            Console.WriteLine(string.Join(" ", stack.ToArray()));
            Console.WriteLine(string.Join(" ", stack.Reverse()));
        }
    }
    class StaticStack<T>
    {
        public StaticStack()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }
        private T[] items;

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public void Push(T item)
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
                T[] itemsCopy = new T[Capacity];
                Array.Copy(items, itemsCopy, Count);
                items = new T[Capacity];
                items = itemsCopy;
            }
            items[Count] = item;
            Count++;
        }

        public T Peak()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty!");
            }
            return items[Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty!");
            }
            T element = this.items[Count - 1];
            this.items[Count - 1] = default(T);
            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        public T[] ToArray()
        {
            T[] returnArray = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                returnArray[i] = items[i];
            }
            return returnArray;
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public T[] Reverse()
        {
            T[] copy = new T[this.items.Length];
            int pos = 0;
            for (int i = items.Length - 1; i <= this.items.Length && i >= 0 ; i--)
            {
                copy[pos] = this.items[i];
                pos++;
            }
            return copy;
        }
    }
}
