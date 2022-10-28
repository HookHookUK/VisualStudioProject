using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDFS
{
    public class Node
    {
        public string Value;
        public List<Node> nodeList = new List<Node>();

        public Node(string a)
        {
            this.Value = a;
        }
    }


    public class Program
    {
        static List<Node> graph = new List<Node>(); // 전체를 담는 리스트
        static List<Node> visitInfo = new List<Node>(); // 방문 기록
        static void Main(string[] args)
        {

            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");


            #region DFS

            AddEdge(nodeA, nodeB);
            AddEdge(nodeA, nodeF);
            AddEdge(nodeC, nodeB);
            AddEdge(nodeC, nodeF);
            AddEdge(nodeC, nodeD);
            AddEdge(nodeC, nodeE);
            AddEdge(nodeD, nodeE);

            #endregion

            #region BFS
            AddEdge(nodeE, nodeG);


            #endregion

            graph.Add(nodeA);
            graph.Add(nodeB);
            graph.Add(nodeC);
            graph.Add(nodeD);
            graph.Add(nodeE);
            graph.Add(nodeF);

            //DFS(nodeA);
            DFS2();
        }

        static public void AddEdge(Node from, Node to)
        {
            from.nodeList.Add(to);
            to.nodeList.Add(from);
        }

        static public void DFS(Node node) // 재귀함수 ver
        {

            visitInfo.Add(node); //방문 기록남긴다
            Console.WriteLine("노드 : " + node.Value);

            for (int i = 0; i < node.nodeList.Count; i++)
            {
                // 방문 안한 것들만 호출
                if (!visitInfo.Contains(node.nodeList[i]))
                {
                    DFS(node.nodeList[i]);
                    Console.WriteLine("노드 : " + node.Value);
                }
                else
                {
                    Console.WriteLine("여기는 왔었던 노드" + node.nodeList[i].Value);
                }
            }
        }

        static void DFS2() // 스택 사용 ver
        {
            Stack<Node> track = new Stack<Node>(); // 스택 형식 하나 만들고

            //첫번째 설정
            Node targetNode = graph[0]; // A~F 까지의 노드를 담고 있는 리스트를 가져와서 그 리스트의 0번째(A) 를 시작점으로 지정

            // 첫번째 것을 가져와서 방문기록
            visitInfo.Add(targetNode); // 방문정보 리스트에 시작점A를 추가
            Console.WriteLine("방문 :" + targetNode.Value);

            while (targetNode != null) // 시작점이 없어질 때까지
            {
                bool visited = false; // 방문여부를 확인하는 불변수
                // 연결되어 있는 다른 노드들을 대상으로 반복
                for (int i = 0; i < targetNode.nodeList.Count; i++) // 시작점으로 지정한 노드의 리스트의 갯수만큼 반복
                {
                    // 이미 방문한 노드가 아닌지 체크
                    if (!visitInfo.Contains(targetNode.nodeList[i])) // 방문정보 리스트 안에 해당 시작점으로 지정한 노드의 리스트의 i번째 노드가 없다면
                    {
                        // targetNode.nodeList[i] 의 방문기록
                        visitInfo.Add(targetNode.nodeList[i]); // 방문정보에 해당 노드(시작점노드의 리스트의 i번째 노드)를 추가
                        Console.WriteLine("방문 :" + targetNode.nodeList[i].Value);

                        // stack에 넣기
                        track.Push(targetNode); // 경로를 되돌아가기 위해서 스택에 집어넣는다.

                        // targetNode  변수를 targgetNde.neighbors[i] 를 가리키게 바꾼다
                        // 처음 targetNode의 연결되어 있는 노드를 방문하기 시작한다

                        targetNode = targetNode.nodeList[i]; // 시작점을 스택에 집어넣었던 시작점의 리스트의 i번째 노드로 설정.

                        visited = true; // 방문 참거짓 변수는 참이다.

                        break;
                    }

                    else
                    {
                        Console.WriteLine("왔던 곳이니 돌아간다" + targetNode.nodeList[i].Value); // 방문정보 리스트에 해당 시삭점으로 지정한 노드의 리스트의 i번째 노드가 있다면
                        continue;
                    }
                }
                if (!visited) // 방문을 한번도 안했다면
                {
                    if (track.Count == 0) // 스택의 갯수가 0인 상태에서 POP을 하면 에러가 발생하므로 예외처리를 위해 설정함. 카운트가 0이면
                    {
                        targetNode = null; // 시작점을 null 로 설정함으로써 반복문(While)을 벗어난다. 함수 종료
                    }

                    else // 스택의 갯수가 하나라도 있다면(되돌아갈 길이 있다면)
                    {
                        targetNode = track.Pop(); //스택의 가장 마지막에 쌓았던 것을 빼면서 그걸 시작점으로 설정한다.
                    }
                }
            }
        }

        static void BSF()
        {
            Queue<Node> queue = new Queue<Node>();

        }
    


    }

}
