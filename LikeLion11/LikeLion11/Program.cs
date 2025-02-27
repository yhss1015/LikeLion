using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion11
{
    internal class Program
    {
        //1단계함수
        //반환형 함수이름 (매개변수)
        //{
        //}
        //1단계 기본형
        static void Loading()
        {

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }

        //3단계
        //출력
        static int BaseAttack()
        {
            //기본공격력 10
            int attack = 10;

            return attack;
        }

        static int Add(int a,int b)
        {
            return a + b;
        }

        static int size(string str)
        {
            return str.Length;
        }

        static int thr_max(int a,int b, int c)
        {
            int max = 0;
            if(a>b && a>c)
            {
                max = a;
            }
            else if(b>a && b>c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            return max;
        }

        static void Main(string[] args)
        {
            //int Attack = 0;
            //int bAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본공격력
            //bAttack = BaseAttack();

            //AttackFunction(Attack+bAttack);

            //// 두 수를 더하는 함수를 만들어서 오류를 해결하세요.

            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 = {result}");


            ////반복문
            //string[] fruits = { "사과", "바나나", "체리" };

            //foreach (string fruit in fruits )
            //{
            //    Console.WriteLine(fruit);
            //}

            //문제1
            int[] input = new int[5];
            int sum = 0 ;
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i+1}번째 숫자 입력 : ");
                input[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " + ");
                sum += input[i];
            }
            Console.WriteLine(" = " + sum);
            int max = 0;
            for (int i= 0; i < input.Length-1; i++)
            {
                int a = input[i];
                int b = input[i+1];                

                if (a < b)
                {
                    max = b;
                }

            }
            Console.WriteLine("최대값 : " + max);
            

            //문제2

            for(int i = 1;i<=10;i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            int[] arrays = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int array in arrays)
            {
                Console.Write(array);
            }

            //문제3

            Console.WriteLine();
            Console.Write("두 수의 합을 구합니다.\n첫 번째 입력 : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("두 번째 입력 : ");
            int second = int.Parse(Console.ReadLine());

            int _sum = Add(first, second);
            Console.WriteLine($"{first} + {second} = {_sum} 입니다.");

            Console.Write("길이를 구할 문자열 입력 : ");
            string str = Console.ReadLine();
            int str_size = size(str);
            Console.WriteLine("문자열 길이 : " + str_size);

            Console.Write("세 개의 숫자 중에서 최대값을 구합니다.\n첫 번째 입력 : ");
            int mfirst = int.Parse(Console.ReadLine());
            Console.Write("두 번째 입력 : ");
            int msecond = int.Parse(Console.ReadLine());
            Console.Write("세 번째 입력 : ");
            int mthird = int.Parse(Console.ReadLine());
            int _max = thr_max(mfirst, msecond, mthird);
            Console.WriteLine("가장 큰 수 : " + _max);


        }
    }
}
