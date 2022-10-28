using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSver2
{
    // 그래프 노드 A, B ... 
    public class Vertex
    {
        public string name;
        public LinkedList linkedList;

        public Vertex(string name)
        {
            this.name = name;
            linkedList = new LinkedList();

            linkedList.Add(this);
        }

        public void AddEdge(Vertex vertex)
        {
            linkedList.Add(vertex);
        }
    }

    public class Graph
    {

    }
}
