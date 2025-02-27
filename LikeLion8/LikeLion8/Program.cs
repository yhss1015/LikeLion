using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// switch 문

            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일입니다.");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일입니다.");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;

            //}

            //Console.Write("직업을 선택하세요\n1.검사 2.마법사 3.도적 : ");
            //string select = Console.ReadLine();
            //string job = default;
            //float attack = 0.0f;
            //float armor = 0.0f;
            //switch (select)
            //{
            //    case "1":
            //        job = "검사";
            //        attack = 100;
            //        armor = 90;
            //        break;
            //    case "2":
            //        job = "마법사";
            //        attack = 110;
            //        armor = 80;
            //        break;
            //    case "3":
            //        job = "도적";
            //        attack = 115;
            //        armor = 70;
            //        break;
            //}

            //Console.WriteLine($"\n\n당신의 직업은 {job}입니다.\n공격력 : {attack}\n방어력 : {armor}");



            //// for 문

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int sum = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    sum+= i;
            //}
            //Console.WriteLine("1~10의 합은 "+sum+" 입니다.");


            //// while문

            //int count = 1;
            //while(count<=5)
            //{
            //    Console.WriteLine("count : "+count);
            //    count++;

            //    if(count==3)
            //    {
            //        Console.WriteLine("count가 3일때 종료");
            //        break;
            //    }
            //}



            //// 랜덤

            //Random rand = new Random();

            //int randomInRange = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    randomInRange = rand.Next(5, 15);
            //    Console.WriteLine("5~14 사이의 랜덤 값 : " + randomInRange);
            //}

            ////대장장이 키우기
            ////도끼등급 SSS 10%
            ////도끼등급 SS  40%
            ////도끼등급 S   50%

            //Random rand = new Random();
            //int randvalue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    randvalue = rand.Next(1, 101); // 1~100

            //    if(randvalue <=10)
            //    {
            //        Console.WriteLine("도끼등급 SSS");
            //    }
            //    else if(randvalue>10&&randvalue<=40)
            //    {
            //        Console.WriteLine("도끼등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 S");
            //    }

            //    Thread.Sleep(500);
            //}


            //// do-while

            //int x = 5;
            //do
            //{
            //    x--;
            //}while(x<0);
            //Console.WriteLine("x : " + x);


            // breal 문

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            // continue

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i);   // 홀수만 출력
            //}


            //// goto

            //int n = 1;

            //start:

            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동
            //}


            int pmoney = 1000;
            int input = 0;
            Random rand = new Random();
            int rnd;

            Thread.Sleep(500);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); // input에 키로 눌린 숫자 담기

                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }

                }
                else if (input == 2)
                {
                    // 장비 뽑기
                    if (pmoney > 1000) // 돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;

                        // 20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }

                            Thread.Sleep(200); // 0.5초 딜레이
                        }
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(2000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
                

            }

        }
    }
}
