using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임스토리 1
            float attack;
            float speed;
            float mana;
            int select;
            string Job="";

            Console.WriteLine("엔터를 눌러 게임을 시작합니다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("===============인디월드====================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------메뉴----------------------");
            Console.WriteLine("1. 시작하기 ");
            Console.WriteLine();
            Console.WriteLine("2. 종료하기 ");
            Console.WriteLine();
            Console.Write("메뉴 선택 : ");
            int Menu =int.Parse(Console.ReadLine());            
            if (Menu==2)
            {
                Console.Clear();
                Console.WriteLine("게임을 종료하였습니다.");
                Environment.Exit(0);
            }

            bool selecting = true;
            


            while (selecting)
            {
                Console.Clear();
                Console.WriteLine("원하는 직업을 입력 해주세요.");
                Console.WriteLine();
                Console.WriteLine("워리어\n아처\n매지션");
                Console.WriteLine();
                Console.Write("직업 입력 : ");
                Job = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"당신의 직업은 {Job}입니다.");
                switch (Job)
                {
                    case "워리어":
                        attack = 100f;
                        speed = 10f;
                        mana = 5f;
                        Console.WriteLine($"{Job}는 슈사이어 지역에서 노예 생활을 겪으면서 강인한 힘을 단련해왔습니다.");
                        Thread.Sleep(3000);
                        Console.WriteLine("아래와 같은 능력치를 가졌습니다.");
                        Console.WriteLine("\n\n\n");
                        select = StatInfo(attack,speed,mana);
                        if(select==1)
                        {
                            selecting= false;
                        }
                        break;
                    case "아처":
                        attack = 50f;
                        speed = 50f;
                        mana = 10f;
                        Console.WriteLine($"{Job}는 다양한 월드를 탐험하며 민첩함을 단련해 왔습니다.");
                        Thread.Sleep(3000);
                        Console.WriteLine("아래와 같은 능력치를 가졌습니다.");
                        Console.WriteLine("\n\n\n");
                        select = StatInfo(attack, speed, mana);
                        if (select == 1)
                        {
                            selecting = false;
                        }
                        break;
                    case "매지션":
                        attack = 20f;
                        speed = 3f;
                        mana = 50f;
                        Console.WriteLine($"{Job}은 로헨델에서 마법을 수련하여 강력한 마나를 가지고 있습니다.");
                        Thread.Sleep(3000);
                        Console.WriteLine("아래와 같은 능력치를 가졌습니다.");
                        Console.WriteLine("\n\n\n");
                        select = StatInfo(attack, speed, mana);
                        if (select == 1)
                        {
                            selecting = false;
                        }
                        break;
                    default:
                        Console.WriteLine("해당 게임에 존재하는 직업을 선택하셨습니다.\n 다시 선택해주세요.");
                        Thread.Sleep(3000);
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine($"{Job}는(은) 월드를 여행하며 자유를 만끽하며 지내고 있었다.");
            Thread.Sleep(1000);
            Console.WriteLine("어느날 평화롭던 월드에 악마와 군단장들이 등장하여 위험이 닥쳤다.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine($"그들을 저지하고 마을을 다시 평하롭게 하기 위해 {Job}는(은) 단련시켜온 힘을 사용하여 마을에 평화를\n되찾기로 마음을 먹는다.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("그렇게 모험을 시작하게 되는데... 이어서");
            Console.WriteLine();
            Thread.Sleep(1000);



        }
        public static int StatInfo(float attack, float speed, float mana)
        {
            Console.WriteLine($" 공격력 : {attack}\n\n 이동속도 : {speed}\n\n 마나 : {mana}\n\n");
            Thread.Sleep(1000);
            Console.WriteLine("직업을 다시 고르시겠습니까?");
            Console.WriteLine(" 1. 그대로 진행 \n\n 2. 다시 선택");
            int select = int.Parse(Console.ReadLine());
            return select;
        }

    }
}
