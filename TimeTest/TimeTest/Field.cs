using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    public class Field
    {
        Player f_player;
        Monster f_monster;

        public void SetPlayer(Player player) { f_player = player;}

        public void Progress()
        {
            //사냥터로 들어왔다.
            int select = 0;

            while (true)
            {
                Console.Clear();

                f_player.Render();
                DrawMap();

                select = int.Parse(Console.ReadLine());

                if (select == 4)
                    break;

                if (select <= 3)
                {
                    
                    CreateMonster(select);
                    //싸운다
                    Fight();
                }

            }
        }

        public void Fight()
        {
            int select = 0;

            while (true)
            {
                Console.Clear();
                f_player.Render();
                f_monster.Render();

                Console.Write("1. 공격 2. 도망 : ");
                select = int.Parse(Console.ReadLine());

                if(select==1)
                {
                    f_monster.SetDamage(f_player.p_Info.Attack);
                    f_player.GetDamage(f_monster.m_Info.Attack);

                    if (f_player.p_Info.Hp <= 0)
                    {
                        f_player.p_Info.Hp = 100; //부활
                        break;
                    }
                }
                if(select ==2 || f_monster.m_Info.Hp<=0)
                {
                    f_monster = null;
                    break;
                }
               
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO t_mInfo = new INFO();

            t_mInfo.strName = _strName;
            t_mInfo.Hp = _iHp;
            t_mInfo.Attack = _iAttack;
            pMonster.SetMonster(t_mInfo);

        }

        public void CreateMonster(int input)
        {
            switch(input)
            {
                case 1:
                    //공장처럼 찍어내준다. 
                    //디자인패턴 팩토리 메서드 패턴
                    Create("초보몹", 20, 4, out f_monster);
                    break;
                case 2:
                    Create("중수몹", 40, 8, out f_monster);
                    break;
                case 3:
                    Create("고수몹", 60, 12, out f_monster);
                    break;
            }
        }


        public void DrawMap()
        {
            Console.WriteLine("1. 초보");
            Console.WriteLine("2. 중수");
            Console.WriteLine("3. 고수");
            Console.WriteLine("4. 이전 단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

    }
}
