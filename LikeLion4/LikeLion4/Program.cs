using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting;    //문자열 변수를 선언
            //greeting = "Hello, World";  //변수에 값을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting);//출력 : Hello, World!

            //// 변수 선언과 초기화를 한번에 수행
            //int score = 100;    // 정수형 변수 선언&100 초기화
            //double temp = 36.6; // 실수형 변수 선언&36.6 초기화
            //string city = "Seoul";  // 문자열 변수 선언&초기화

            ////변수 출력
            //Console.WriteLine(score); // 출력 100
            //Console.WriteLine(temp); // 출력 36.6
            //Console.WriteLine(city); // 출력 Seoul

            //// 같은 데이터 타입의 변수를 쉼표 구분하여 선언
            //int x = 10,y = 20,z = 30;   //정수형 변수 x,y,z 선언&초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159; // 상수 pi선언 및 초기화
            //const int MaxScore = 100;  // 상수 MaxScore 선언 및 초기화

            //// 출력
            //Console.WriteLine("Pi : "+Pi); // 출력 Pi : 3.14159
            //Console.WriteLine("MaxScore : " + MaxScore); // 출력 MaxScore : 100


            int attack = 16755;
            int maxHp = 78103;
            int critical = 36;
            int specialization = 1017;
            int subdue = 41;
            int speed = 611;
            int patience = 22;
            int proficieny = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("최대 생명력 : "+maxHp);
            Console.WriteLine();
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명 : " + critical);
            Console.WriteLine("특화 : " + specialization);
            Console.WriteLine("제압 : " + subdue);
            Console.WriteLine("신속 : " + speed);
            Console.WriteLine("인내 : " + patience);
            Console.WriteLine("숙련 : " + proficieny);



        }
    }
}
