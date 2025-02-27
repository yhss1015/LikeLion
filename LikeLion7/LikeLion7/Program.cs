using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); // 양수 출력 5
            //Console.WriteLine(-number); // 음수 출력 -5

            //Console.WriteLine(!flag);   // 논리 부정 false

            //~비트 반전
            //10 1010 -> ~ -> 0101
            //10 -> ~ -> -11     0000 0000 0000 0000 0000 0000 0000 1010 통째로 반전 == +1후 마이너스

            //int num = 10;
            //int result = ~num;
            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~ 연산자 사용 후 : " + result);

            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi;    // 실수형 -> 정수형으로 변환

            //Console.WriteLine(integerPi);   // 3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;
            //average = (float)sum / 3;

            //Console.WriteLine("총점 : " + sum + " 평균 :" + average);

            //문자열 연결 연산자

            //string firstName = "Alice";
            //string secondName = "Smith";

            //Console.WriteLine(firstName + " " + secondName);    // Alice Smith


            ////대입 연산자
            //int a = 10;
            //a += 5; // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5; // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5; // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5; // a = a / 5;
            //Console.WriteLine(a);

            //Console.Write("국어 점수 입력 :");
            //int Kor_Grade = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수 입력 :");
            //int Math_Grade = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수 입력 :");
            //int Eng_Grade = int.Parse(Console.ReadLine());

            //float average = (float)(Kor_Grade+Math_Grade+Eng_Grade) / 3;
            //Console.WriteLine("평균 : " + Math.Round(average,2));

            //Console.Write("비트 반전 연산을 할 정수를 입력하세요 : ");
            //int intInput =int.Parse(Console.ReadLine());

            //Console.WriteLine($"~{intInput} ->  {~intInput}");


            //// 증감 연산자
            //int b = 3;
            //// 전위 ++b , 후위 b++
            //Console.WriteLine(b++);
            //Console.WriteLine(b);
            //Console.WriteLine(++b);


            //// 비교 연산자
            //int x = 5, y = 10;
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x.GetType() == y.GetType());


            //// 논리 연산자
            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(!a);

            //// 비트 연산자
            //int x = 5; // 0101
            //int y = 3; // 0011 

            //Console.WriteLine(x & y); //AND : 1 (0001)
            //Console.WriteLine(x | y); //OR : 7 (0111)
            //Console.WriteLine(x ^ y); //XOR :6   (0110)
            //Console.WriteLine(~x);    //NOT : -6

            //int value = 4; //0100

            //Console.WriteLine(value << 1);
            //Console.WriteLine(value >> 1);



            //// 삼항 연산자
            //int a = 10,b = 20;
            //int max;
            //max = (a > b) ? a : b;
            //Console.WriteLine(max);

            //int key = 1;
            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문을 열지 못했습니다.";
            //Console.WriteLine(str);


            //int result = 10 + 2 * 5; // 곱 우선 20
            //Console.WriteLine(result);
            //result = (10 + 2) * 5; // 괄호 우선 60
            //Console.WriteLine(result);



            //// 조건문

            //int score = 85;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else
            //{
            //    Console.WriteLine("B학점");
            //}

            //string GameID = "멋사ID";

            //if(GameID=="멋사ID")
            //{
            //    Console.WriteLine("ID 일치");
            //}
            //else
            //{
            //    Console.WriteLine("ID 불일치");
            //}

            //int score = 75;
            //if(score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if(score >=70)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else if(score>=60)
            //{
            //    Console.WriteLine("D학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}


            Console.Write("소지금을 입력하세요 : ");
            int gold = int.Parse(Console.ReadLine());
            float strong = 100;
            float s_strong = 0;
            string sword=default;
            if(gold>600)
            {
                sword = "전설의 검";
                s_strong = 7;
            }
            else if(gold > 500)
            {
                sword = "유령검";
                s_strong = 6;
            }
            else if (gold > 400)
            {
                sword = "엑스칼리버";
                s_strong = 5;
            }
            else if (gold > 300)
            {
                sword = "집판검";
                s_strong = 4;
            }
            else if (gold > 200)
            {
                sword = "진은검";
                s_strong = 3;
            }
            else if (gold > 100)
            {
                sword = "카타나";
                s_strong = 2;

            }
            else if (gold > 0)
            {
                sword = "무한의대검";
                s_strong = 1;
            }
            else
            {
                Console.WriteLine("소지금이 부족합니다.");
            }
            Console.WriteLine($"{sword}를 구입하였습니다.");
            Console.Write("이름을 입력하세요 :");
            string name = Console.ReadLine();

            Console.WriteLine($"\n\n캐릭터 이름 : {name}\n무기 : {sword}\n공격력 : {strong} + {s_strong}");


        }
    }
}
