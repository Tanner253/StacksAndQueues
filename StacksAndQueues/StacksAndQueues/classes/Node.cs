using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace StacksAndQueues.classes
{
    public class Node
    {

        Node node = new Node();
        public int Value { get; set; }
        
        public Node Current { get; set; }
        public Node Head { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public Node Next { get; set; }

        public enum FavoriteNumbers
        {
          one,
          two,
          three,
          four,
          five

        }
      
    }
}
