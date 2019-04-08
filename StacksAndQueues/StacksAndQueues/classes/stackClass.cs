using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace StacksAndQueues.classes
{
    public class StackClass<T> 
    {
        int count;
        
        public Node<T> Top { get; set; }
        public int Count()
        {
            return count;
        }
        
        
        
        //got info from c-sharpercorner
        public void MyStack(Node<T> node)
        {
            Top = node;
        }

        
        public void Push(T item)
        {
            Node<T> node = new Node<T>();
            node.Value = item;

            node.Next = Top;
            Top = node;
        }

        public Node<T> Peek()
        {
            return Top;
            
        }



        public Node<T> Pop()
        {
            Node<T> temp = Top;

            Top = Top.Next;

            temp = null;

            return temp;
        }

    }
}
