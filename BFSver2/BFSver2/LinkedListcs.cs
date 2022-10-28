using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSver2
{



    public class Node
    {
        public Vertex vertex;
        public Node next;
    }

    public class LinkedList
    {
        public Node head = null;
        public Node tail = null;
        public Node cur = null;

        public void Add(Vertex vertex)
        {
            Node newnode = new Node();
            newnode.vertex = vertex;

            if (head == null)
                head = newnode;

            else
            {
                tail.next = newnode;
            }

            tail = newnode;

        }

        public void Print()
        {
            if(head == null)
            {
                Console.WriteLine("노 데이터");
                return;
            }
            else
            {
                cur = head;
                do
                {
                    Console.Write(cur.vertex.name + " -> ");
                    cur = cur.next; 

                } while (cur != null);
                Console.WriteLine();
            }
        }
    }
}
