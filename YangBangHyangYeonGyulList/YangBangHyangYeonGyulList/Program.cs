using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace DataStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            

            StreamReader line1text = new StreamReader("Line_1.txt");
            StreamReader line2text = new StreamReader("Line_2.txt");

            YangBangHyang yangbang = new YangBangHyang();
            OneHyungYangBangHyang oneHyung = new OneHyungYangBangHyang();

            string line1;
            string line2;

            int isline1;
            int isline2;

            while ((line1 = line1text.ReadLine()) != null)
            {
                yangbang.Add(new NodeData { Name = line1 });
            }

            while ((line2 = line2text.ReadLine()) != null)
            {
                oneHyung.Add(new NodeData { Name = line2 });
            }

            // yangbang.Print();
            // oneHyung.Print();
            Console.Write("출발역 : ");
            string startStation = Console.ReadLine();
            Console.Write("도착역 : ");
            string arriveStation = Console.ReadLine();

            isline1 = yangbang.Search(startStation, arriveStation);
            isline2 = oneHyung.Search(startStation, arriveStation);

            int dist1 = 0;
            int dist2 = 0;
            



            if (isline1 == 3)
            {
                Console.WriteLine("이것은 1호선 안에서 이동한다");
                dist1 = yangbang.Calculate(startStation, arriveStation);
                Console.WriteLine("총 환승 횟수 : " + dist1);
            }
            else if (isline2 == 3)
            {
                Console.WriteLine("이것은 2호선 안에서 이동한다");
                dist2 = oneHyung.Calculate(startStation, arriveStation);
                Console.WriteLine("총 환승 횟수 : " + dist2);
            }
            else if (isline1 == 1 && isline2 == 2) // 출발지 : 1호선 / 도착지 : 2호선
            {
                dist1 = yangbang.Calculate(startStation, "시청");
                Console.WriteLine();
                dist2 = oneHyung.Calculate("시청", arriveStation);
                Console.WriteLine();
                Console.WriteLine("총 환승 횟수 : " + (dist1 + dist2));
            }
            else if (isline2 == 1 && isline1 == 2) // 출발지 : 2호선 / 도착지 : 1호선
            {
                dist2 = oneHyung.Calculate(startStation, "시청");
                Console.WriteLine();
                dist1 = yangbang.Calculate("시청", arriveStation);
                Console.WriteLine();
                Console.WriteLine("총 환승 횟수 : " + (dist2 + dist1));
            }

        }
    }
}
