using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DataStruct
{
    public struct NodeData
    {
        public string Name;
    }
    internal class YangBangHyang //1호선 : 양뱡향
    {
        
        public class Node
        {
            public NodeData nodeData;
            public Node prev;
            public Node next;
        }

        Node head = null;
        Node tail = null;
        Node cur = null;

        public void Add(NodeData nodeData) // 추가하는 부분
        {
            Node newNode = new Node();

            newNode.nodeData = nodeData;

            if (head== null)
            {
                head = new Node(); // 처음만 가리키는 빈 노드. 첫번째 데이터가 아니고 첫번째 데이터를 가리키는 용도로만 쓰인다.
                tail = new Node();
                head.next = newNode; // 처음이 없을 경우에는 새로운 노드를 헤드로 지정한다.
                tail.prev = newNode;
                newNode.prev = head;
                newNode.next = tail;
            }

            else
            {
                tail.prev.next = newNode; // 테일의 다음에 새로운 노드를 추가한다.
                newNode.prev = tail.prev; // 새로운 노드의 앞에 테일을 추가한다.
                newNode.next = tail;
                tail.prev = newNode;
            }
        }

        public int Search(string start, string arrive)
        {
            int exist = 0;
            cur = head.next;
            while(cur != null)
            {
                if (cur.nodeData.Name == start)
                {
                    exist += 1;
                }
                else if (cur.nodeData.Name == arrive)
                {
                    exist += 2;
                }
                cur = cur.next;
            }
            return exist;
        }

        public int Calculate(string start, string arrive)
        {
            int jung = 0;   // 정방향
            int yuck = 0;   // 역방향
            Node saveStart = null;
            bool canArriveJ = false;
            bool canArriveY = false;

            cur = head.next;
            while (cur != null)
            {
                if (cur.nodeData.Name == start)
                {
                    saveStart = cur;

                    while (cur != null) // 시작점에서부터 정방향
                    {

                        if (cur.nodeData.Name == arrive) //도착지를 찾았다면 탈춝
                        {
                            ++jung;
                            canArriveJ = true;
                            break;
                        }

                        cur = cur.next;
                        ++jung;
                    }


                    cur = saveStart; //시작지점을 시작점으로 초기화

                    while (cur != null) // 시작점에서부터 역방향
                    {
                        if (cur.nodeData.Name == arrive)
                        {
                            ++yuck;
                            canArriveY = true;
                            break;
                        }
                        cur = cur.prev;
                        ++yuck;
                    }
                    
                    //========================================================================================================================
                    // 거리 비교 후 조건에 따라 결과 산출 
                    //========================================================================================================================

                    cur = saveStart; //시작지점을 시작점으로 초기화
                    if ((jung <= yuck && canArriveJ) || (canArriveJ && !canArriveY)) //정방향이 더 가깝고 정방향으로 도달 가능하거나 || 정방향으로만 갈 수 있을 때
                    {
                        for (int i = 0; i < jung; i++)
                        {
                            if(cur.nodeData.Name == start && i == 0)
                            {
                                cur = cur.next;
                                continue;
                            }
                            Console.Write(" -> {0}", cur.nodeData.Name);
                            cur = cur.next;
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine(" 1호선 환승 정거장 : " + jung);
                        return jung;
                    }
                    else if ((yuck <= jung && canArriveY) || (canArriveY && !canArriveJ)) // 역방향이 더 가깝고 역방향으로 갈 수 있거나 || 역방향으로만 갈 수 있을 때
                    {
                        for (int i = 0; i < yuck; i++)
                        {
                            if (cur.nodeData.Name == start && i == 0)
                            {
                                cur = cur.prev;
                                continue;
                            }
                            Console.Write(" -> {0}", cur.nodeData.Name);
                            cur = cur.prev;
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine(" 1호선 환승 정거장 : " + yuck);
                        return yuck;
                    }

                    //break; // 양방향 계산 끝났으니 탈출!
                }
                cur = cur.next; // 이것은 출발역을 찾을 때 까지 도는 용도
            }
            return 0;
        }

        public void Print()
        {
            if (head == null)
                Console.WriteLine("No Data");
            else
            {
                // cur = head;
                cur = head.next;

                do
                {
                    Console.WriteLine("{0}", cur.nodeData.Name);
                    // cur = cur.next;
                    cur = cur.next;
                } while(cur.next != null);
            }
        }
    }
}
