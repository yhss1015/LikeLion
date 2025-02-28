using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion12
{
    internal class Program
    {
        //전역변수
        static int stNum = 20;


        // 1. 매개 변수, 반환값이 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        // 2. 매개변수만 있는 함수
        static void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        // 3. 반환값만 있는 함수
        static int GetNumber()
        {
            return 42;
        }

        // 4. 매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 5. 기본값을 가진 매개 변수 (디폴트 매개 변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요 , {name}");
        }

        // 6. 오버로딩(Overloading)
        /// <summary>
        /// 두 수를 곱하는 함수
        /// </summary>
        /// <param name="a">int,double 오버로딩</param>
        /// <param name="b">int,double 오버로딩</param>
        /// <returns></returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        // 7. out 키워드 (여러값을 반환할때)
        static void Divide(int a, int b,out int quotient,out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        // 8. ref 키워드 (값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num+=10;
        }


        static void Main(string[] args)
        {

            // PrintHello();
            // PrintMessage("어서오세요.");
            ////로컬 변수
            //int num = GetNumber();
            //Console.WriteLine(num);

            //Console.WriteLine(Add(3, 5));

            //Greet();
            //Greet("해린");

            //Console.WriteLine(Multiply(3, 4));
            //Console.WriteLine(Multiply(2.5, 3.5));

            //int q, r;
            //Divide(10,3,out q,out r);
            //Console.WriteLine($"몫 : {q}, 나머지 : {r}");

            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);


        }
    }
}
