using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public struct NodeData
    {
        public int num;
        public string name;
    }

    public class Node
    {
        public NodeData nodeData;
        public Node connect;
        public List<Node> nodeList;
        public LinkedList<Node> linkedNodeList;
        public Node next;
        public Node prev;

        public Node head = null;
        public Node tail = null;
        public Node cur = null;

        public void Add(NodeData nodeData)
        {
            Node newNode = new Node();
            newNode.nodeData = nodeData;
            
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;

            }
            tail = newNode;
        }

        public void AddEdge(Node First, Node Second) // Graph 라는 거대 노드 안에 A, B, C, D 노드들의 리스트들 안에 연결정보(리스트)를 추가한다
        {
            

            if (!cur.nodeList.Contains(First))
            {
                nodeList.Add(First);
            }
            else
            {
                cur.AddEdge(Second, First);
            }

            if (!cur.nodeList.Contains(Second))
            {
                cur.nodeList.Add(Second);
            }
            else
            {
                cur.AddEdge(Second, First);
            }

        }

        public void CheckEdge(Node Num) // 연결 여부 확인 함수
        {
            for(int i = 0; i < nodeList.Count; i++)
            {
                if (nodeList[i].nodeData.name == Num.nodeData.name)
                {
                    
                }
            }
        }

    }

    internal class LinkedList
    {
        public Node tailNode = null;
        public LinkedList prev = null;
        public LinkedList next = null;

        

        
    }
}
