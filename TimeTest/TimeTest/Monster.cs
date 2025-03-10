using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTest
{
    public class Monster
    {
        public INFO m_Info;

        public void SetDamage(int damage) { m_Info.Hp -= damage; }
        
        public void SetMonster(INFO monster) { m_Info = monster; }
        public INFO GetMonster() { return m_Info; }

        public void Render()
        {
            Console.WriteLine("===================");
            Console.WriteLine("몬스터 이름 : " + m_Info.strName);
            Console.WriteLine("체력 : " + m_Info.Hp + " 공격력 : "+m_Info.Attack);

        }

    }
}
