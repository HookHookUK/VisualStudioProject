using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    internal class Graph //LinkedList List
    {
        public LinkedList tail = null;

        public Node A = new Node();
        public Node B = new Node();
        public Node C = new Node();
        public Node D = new Node();
        public Node E = new Node();
        public Node F = new Node();

        LinkedList VisitInfoList = new LinkedList();
        
        public void NodeConnect() // 노드를 연결하라~
        {
            A.AddEdge(A, B);
            A.AddEdge(A, F);
            B.AddEdge(B, C);
            C.AddEdge(C, D);
            C.AddEdge(C, E);
            D.AddEdge(D, C);
            F.AddEdge(F, C);
        }

        public void CheckPath() // 경로가 이동가능한지 확인하는 함수
        {
            
        }


        public void VisitInfo(Node start, Node arrive) // 방문 정보를 기록하는 함수
        {
            
        }

        public void Add()
        {
            LinkedList newLinkedList = new LinkedList();

            if (tail == null)
                tail = newLinkedList;
            else
            {
                tail.prev = newLinkedList;
                newLinkedList.next = tail;
                tail = tail.prev;

            }

        }
    }


}

