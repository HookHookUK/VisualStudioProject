using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Graph graph = new Graph();
            graph.NodeConnect(); // 노드들을 연결하라~

            Console.WriteLine("End");
            Console.WriteLine("End");
        }
    }
}
