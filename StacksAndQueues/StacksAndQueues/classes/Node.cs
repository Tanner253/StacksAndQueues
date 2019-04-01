using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace StacksAndQueues.classes
{
    public class Node
    {
        public Node Current { get; set; }
        public Node Head { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }


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
