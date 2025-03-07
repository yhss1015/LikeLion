using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeLion31
{
    public class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        {

        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 마법 구체를 던집니다!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 화염 폭발을 시전합니다.");
            target.TakeDamage(Attack * 2);
        }
    }
}
