using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 0, c = 0;
            string d = "";

            Console.Write("첫번째숫자:");
            a = int.Parse(Console.ReadLine());
            Console.Write("두번째숫자:");
            b = int.Parse(Console.ReadLine());
            Console.Write("사칙연산:");
            d= Console.ReadLine();

            if (d == "+")
            {
                c = a + b;
            }
            else if (d == "-")
            {
                c = a - b;
            }
            else if (d == "*")
            {
                c = a * b;
            }
            else if (d == "/")
            {
                if (a == 0)
                {
                    Console.WriteLine("a==0이 될수없습니다");
                }
                else if (b == 0)
                {
                    Console.WriteLine("분모는 0이 될수 없습니다.");
                }
            }

            Console.WriteLine("결과 값은 :" + c);

        }
    }
}
