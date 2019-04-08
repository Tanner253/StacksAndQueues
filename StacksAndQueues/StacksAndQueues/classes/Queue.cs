using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.classes;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace StacksAndQueues.classes
{
    public class Queue<T>
    {

        Queue<T> queue = new Queue<T>();
        Node<T> Front { get; set; }
        Node<T> Rear { get; set; }
        
        public void MyQueue(Node<T> node)
        {
            Front = node;
            Rear = node;
            
        }
        public void EnQueue(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            Rear.Next = node;
            Rear = node;
            
        }
        public Node<T> DeQueue(T value)
        {
            Node<T> temp = Front;

            Front = Front.Next;
            temp.Next = null;
            return temp;

        }
        public T Peek()
        {
            return Front.Value;
        }

    }
}
