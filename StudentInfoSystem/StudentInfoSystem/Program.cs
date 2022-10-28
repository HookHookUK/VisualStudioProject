using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        // 리스트의 구조는 다음과 같다. 전공 > 학번 > 학생이름
        // 전공 : 순차리스트로 이동 : 전공 리스트 내부에 학번 리스트가 있다?
        // 학번 리스트 안에 

        static void Start()
        {
            bool roof = true; // 반복용

            while(roof)
            {
                Console.WriteLine("1 : insert" + "\n" + "2 : delete" + "\n" + "3 : print_all" + "\n" +
                "4 : print_major" + "\n" + "5 : print_year" + "\n" + "6 : print_name" + "\n" + "7 : exit");
                string[] Keywords = Console.ReadLine().Split(' ');
                int order = int.Parse(Keywords[0]);

                switch (order)
                {
                    case 1:
                        // "전공 학번 이름"을 정확한 자료구조에 추가
                        break;
                    case 2:
                        // "전공 학번 이름"을 정확한 자료구조에 추가
                        break;
                    case 3:
                        // 모든 학생 정보 출력(순서 무관)
                        break;
                    case 4:
                        // 입력받은 전공 내 모든 학생 정보 출력(순서 무관)
                        break;
                    case 5:
                        // 입력받은 학번의 모든 학생 정보 출력(순서 무관)
                        break;
                    case 6:
                        // 이름과 같은 학생을 찾아 출력, 탐색 경로를 출력
                        break;
                    case 7:
                        // 종료
                        roof = false;
                        break;
                }
            }

            
        }
    }
}
