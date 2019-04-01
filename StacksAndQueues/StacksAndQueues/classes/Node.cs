using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace StacksAndQueues.classes
{
    public class Node<T>
    {

      
        public T Value { get; set; }
        
        public Node<T> Current { get; set; }
        public Node<T> Head { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public Node<T> Next { get; set; }

       
      
    }
}
