using StacksAndQueues.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;



namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOntoStack()
        {
            StackClass<int> stack = new StackClass<int>();
            Node<int> node = new Node<int>();
            node.Value = 5;
            stack.Push(node.Value);
            Assert.Equal(5, stack.Top.Value);
        }
        [Fact]
        public void CanPushMultipleNodes()
        {
            StackClass<int> stack = new StackClass<int>();
            Node<int> node = new Node<int>();
            node.Value = 5;
            stack.Push(node.Value);
            Node<int> node2 = new Node<int>();
            node.Value = 15;
            stack.Push(node.Value);
            Node<int> node3 = new Node<int>();
            node.Value = 22;
            stack.Push(node.Value);
            Assert.Equal(22, stack.Top.Value);
        }
        [Fact]
        public void CanPopOffStack()
        {
            StackClass<int> stack = new StackClass<int>();
            Node<int> node = new Node<int>();
            node.Value = 5;
            stack.Push(node.Value);
            Node<int> node2 = new Node<int>();
            node.Value = 15;
            stack.Push(node.Value);
            Node<int> node3 = new Node<int>();
            node.Value = 22;
            stack.Push(node.Value);
            stack.Pop();
            Assert.Equal(15, stack.Top.Value);
        }
        //[Fact]
        public void CanEmptyStack()
        {
            StackClass<int> stack = new StackClass<int>();
            Node<int> node = new Node<int>();
            node.Value = 5;
            stack.Push(node.Value);
            Node<int> node2 = new Node<int>();
            node.Value = 15;
            stack.Push(node.Value);
            Node<int> node3 = new Node<int>();
            node.Value = 22;
            stack.Push(node.Value);
            while (node.Next != null)
            {
                stack.Pop();
            }
            stack.Pop();
            var result = stack.Peek();
            var Result = result.Value; 
            Assert.Null(Result);
        }
       // [Fact]
        public void CanPeek()
        {
            StackClass<int> stack = new StackClass<int>();
            Node<int> node = new Node<int>();
            node.Value = 5;
            stack.Push(node.Value);
            Node<int> node2 = new Node<int>();
            node.Value = 15;
            stack.Push(node.Value);
            var output = stack.Peek();
            
        }
    }
}
