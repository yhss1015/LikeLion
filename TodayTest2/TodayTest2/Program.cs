using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TodayTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제 1.");
            Console.WriteLine("계산할 숫자 3개를 입력 해주세요");
            Console.Write("첫 번째 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두 번째 입력 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세 번째 입력 : ");
            int c = int.Parse(Console.ReadLine());

            int max = 0;
            if(a>b&&a>c)
            {
                max = a;
            }
            else if(b>a&& b>c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            Console.WriteLine("\n\n최대값은 " + max + " 입니다.");



            Console.WriteLine("\n\n문제2.");
            Console.Write("성적을 입력하세요. : ");
            int grade = int.Parse(Console.ReadLine());

            if(grade>=90)
            {
                Console.WriteLine("A학점");
            }
            else if(grade>=80)
            {
                Console.WriteLine("B학점");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("C학점");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("D학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }

            Console.WriteLine("\n\n문제3.");
            Console.Write("계산할 숫자 두 개를 입력하세요.");
            Console.Write("첫 번째 입력 : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("두 번째 입력 : ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("계산할 사칙연산을 입력하세요. (+,-,*,/) 중 1개 : ");
            string select = Console.ReadLine();
            Console.WriteLine("\n\n");

            float result = 0.0f;
            if(select=="+")
            {
                result = (float)first+second;
            }
            else if (select == "-")
            {
                result = (float)first - second;
            }
            else if (select == "*")
            {
                result = (float)first * second;
            }
            else if (select == "/")
            {
                result = (float)first / second;
            }
            else
            {
                Console.WriteLine("존재하지 않는 연산을 선택하였습니다.");
            }

            Console.WriteLine($"{first}{select}{second} = {result}");
        }
    }
}
