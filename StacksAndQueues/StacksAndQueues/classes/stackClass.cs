using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.classes
{
    public class StackClass<T> : IEnumerable
    {
        public void Initiation()
        {
            StackClass<int> MyStackk = new StackClass<int>();
            Console.WriteLine("Stack initiated");
        }

        T[] values = new T[10];

        int count = 0;

        public void Add(T value)
        {
            if (count == values.Length)
            {
                Array.Resize(ref values, (values.Length * 2));
            }
            values[count++] = value;
        }

        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
