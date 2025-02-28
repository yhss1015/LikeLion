using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion13
{
    internal class Program
    {
        // params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }


        // 재귀함수
        static int Factorial(int n)
        {           
            if(n<=1) return 1;
            return n *Factorial(n-1);

        }


        static void Main(string[] args)
        {
            // Console.WriteLine(Sum(1,2,3));

            Console.WriteLine(Factorial(5));


        }
    }
}
