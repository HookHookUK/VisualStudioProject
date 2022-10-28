using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class OneHyungYangBangHyang // 2호선 : 원형 양방향 // 원형 양방향은 tail을 써서는 아니된다.
    {
        public class Node
        {
            public NodeData nodeData;
            public Node prev;
            public Node next;
        }

        Node head = null;
        Node cur = null;

        public void Add(NodeData nodeData)
        {
            Node newNode = new Node();
            newNode.nodeData = nodeData;

            if (head == null)
            {
                head = newNode;
                head.next = newNode;
                //head.prev = newNode;
            }
            else
            {
                head.prev.next = newNode; // head.prev = tail 을 나타낸다. 원형리스트에서 tail.next = head 인 것에서 착안한 역발상 -김영갑-
                newNode.prev = head.prev;
                newNode.next = head;
            }
            head.prev = newNode;
            
        }

        public void Print()
        {
            if (head == null)
                Console.WriteLine("No Data");
            else
            {
                // cur = head;
                cur = head;

                do
                {
                    Console.WriteLine("{0}", cur.nodeData.Name);
                    //cur = cur.next;
                    cur = cur.prev;
                } while (cur != null);
            }
        }

        public int Search(string start, string arrive)
        {
            int exist = 0; // 1 : start , 2 : arrive , 3 : both

            cur = head;
            for(int i = 0; i < 44; i++)
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
            int cycle = 0;

            cur = head;
            while (cycle < 44)
            {
                //Console.WriteLine("현재 위치 : {0}", cur.nodeData.Name);
                if (cur.nodeData.Name == start)
                {
                    saveStart = cur; //시작점이 되는 역을 넣는다
                    //Console.WriteLine("정방향의 시작");
                    while (true) // 시작점에서부터 정방향
                    {

                        if (cur.nodeData.Name == arrive)
                        {
                            break;
                        }
                        //Console.Write(" -> {0}", cur.nodeData.Name);
                        cur = cur.next;
                        ++jung;
                       // Console.WriteLine(jung);
                    }

                    cur = saveStart; //시작지점을 시작점으로 초기화
                    while (true) // 시작점에서부터 역방향
                    {

                        if (cur.nodeData.Name == arrive)
                        {
                            break;
                        }
                        //Console.Write(" -> {0}", cur.nodeData.Name);
                        cur = cur.prev;
                        ++yuck;
                       // Console.WriteLine(yuck);
                    }

                    //========================================================================================================================
                    // 거리 비교 후 조건에 따라 결과 산출 
                    //========================================================================================================================

                    cur = saveStart; //시작지점을 시작점으로 초기화
                    if (jung < yuck) //정방향이 더 빠르면
                    {
                        for (int i = 0; i <= jung; i++)
                        {
                            if (start == cur.nodeData.Name && i == 0)
                            {
                                cur = cur.next;
                                continue;
                            }
                                

                            Console.Write(" -> {0}", cur.nodeData.Name);
                            cur = cur.next;
                        }
                        Console.WriteLine();
                        Console.WriteLine(" 2호선 환승 정거장 : " + jung);
                        return jung;
                    }
                    else // 그 외 같거나 역방향이 더 빠르면
                    {
                        for (int i = 0; i <= yuck; i++)
                        {
                            if (start == cur.nodeData.Name && i == 0)
                            {
                                cur = cur.prev;
                                continue;
                            }

                            Console.Write(" -> {0}", cur.nodeData.Name);
                            cur = cur.prev;
                        }
                        Console.WriteLine();
                        Console.WriteLine(" 2호선 환승 정거장 : " + yuck);
                        return yuck;
                    }

                }
                cur = cur.next; // 이것은 출발역을 찾을 때 까지 도는 용도
                cycle++;
            }
            return 0;

        }

    }
}
