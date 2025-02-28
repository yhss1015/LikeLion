using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임스페이스
//클래스, 함수, 변수 이름이 충돌하는것을 방지하기위해 사용함.

namespace dev1
{
    class Myclass
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}


namespace LikeLion14
{
    internal class Program
    {

        static void SayHello()
        {
            Console.WriteLine("안녕하세요?");
        }

        static void Main(string[] args)
        {
            dev1.Myclass.SayHello();
            SayHello();
        }
    }
}
