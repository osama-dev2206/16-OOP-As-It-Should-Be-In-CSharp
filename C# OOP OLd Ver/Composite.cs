using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_OLd_Ver
{
    internal class Node
    {
        public int value { get; set;  } 

        public Node ptr;

        public Node(int value)
          {
            this.value = value;
            ptr = null;
        }

    }

    class LinkedList
    {
    Node Head = null; 
        public void  InsertAtTheBegging(int value)
        {
            Node NNode = new Node(value);
            if (Head == null)
            {
                NNode.ptr = null;
                Head = NNode;
            }
            else
            {
             

                 NNode.ptr = Head;

                Head = NNode;


            }
        }
    }
}
