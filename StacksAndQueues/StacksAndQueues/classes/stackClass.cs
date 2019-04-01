using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace StacksAndQueues.classes
{
    public class StackClass<T> : IEnumerable
    {
        int size;
        public int Top { get; set; }
        T[] values;
        
        //got info from c-sharpercorner
        public void MyStack(int maxElements)
        {
            size = maxElements;
            values = new T[size];
        }
        StackClass<T> stack = new StackClass<T>();
        int count;

        /*
        int count = 0;

        public void Add(T value)
        {
            if (count == values.Length)
            {
                Array.Resize(ref values, (values.Length * 2));
            }
            values[count++] = value;
        }*/

        public virtual int Push(T item)
        {
            if (Top == size - 1)
            {
                //means overflow
                return -1;
            }
            else
            {
                Top = Top + 1;
                values[Top] = item;
            }
            return 0;
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
