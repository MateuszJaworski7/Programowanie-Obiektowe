using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5zad6
{
    public partial class MyList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next;
        }

        private Node first = null;
        private Node last = null;
        private int count = 0;

        public void Add(T element)
        {
            if (first == null)
            {
                first = last = new Node { Value = element };
            }
            else
            {
                last = last.Next = new Node { Value = element };
            }
            count++;
        }

        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
            {
                e = e.Next;
            }
            if (e == null)
            {
                throw new IndexOutOfRangeException();
            }
            return e;
        }

        public T this[int i]
        {
            get => Get(i).Value;
            set => Get(i).Value = value;
        }

        public int Count
        {
            get { return count; }
        }

        public void Insert(int i, T element)
        {
            if (i == 0)
            {
                var newNode = new Node { Value = element, Next = first };
                first = newNode;
                if (count == 0)
                {
                    last = first;
                }
            }
            else
            {
                var prev = Get(i - 1);
                var newNode = new Node { Value = element, Next = prev.Next };
                prev.Next = newNode;
                if (prev == last)
                {
                    last = newNode;
                }
            }
            count++;
        }

        public bool Remove(T element)
        {
            Node current = first, previous = null;
            while (current != null)
            {
                if (current.Value.Equals(element))
                {
                    if (previous == null)
                    {
                        first = first.Next;
                        if (first == null)
                        {
                            last = null;
                        }
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (previous.Next == null)
                        {
                            last = previous;
                        }
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public bool RemoveAt(int i)
        {
            if (i >= count)
            {
                return false;
            }

            if (i == 0)
            {
                first = first.Next;
                if (first == null)
                {
                    last = null;
                }
            }
            else
            {
                var prev = Get(i - 1);
                prev.Next = prev.Next.Next;
                if (prev.Next == null)
                {
                    last = prev;
                }
            }
            count--;
            return true;
        }
        public void PrintList()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void PrintEvenNumbers()
        {
            Node current = first;
            while (current != null)
            {
                if (current.Value is int intValue && intValue % 2 == 0)
                {
                    Console.WriteLine(intValue);
                }
                current = current.Next;
            }
        }

    }
}