using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    public class Player
    {
        public INFO p_Info;

        public void GetDamage(int damage) { p_Info.Hp -= damage; }
        public void SetPlayer(INFO player) { p_Info = player; }
        public INFO GetPlayer() { return p_Info; }

        public void SetHp(int hp) { p_Info.Hp = hp; }

        public void SelectJob()
        {
            p_Info = new INFO();

            Console.Write("직업을 선택하세요. 1. 전사 2. 마법사 3. 도둑 : ");
            int select = int.Parse(Console.ReadLine());

            switch(select)
            {
                case 1:
                    JobList("기사", 10, 200, p_Info);
                    break;
                case 2:
                    JobList("마법사", 20, 120, p_Info);
                    break;
                case 3:
                    JobList("도둑", 30, 150, p_Info);
                    break;

            }

        }

        public void Render()
        {
            Console.WriteLine("===============");
            Console.WriteLine("나의 직업 : " + p_Info.strName);
            Console.WriteLine("체력 : " + p_Info.Hp + " \t 공격력 : " + p_Info.Attack);
        }
        

        public void JobList(string name, int attack, int hp, INFO player)
        {
            player.strName = name;
            player.Attack = attack;
            player.Hp = hp;
        }

    }
}
