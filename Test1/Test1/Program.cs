using System;
using System.Collections.Generic;

namespace LeagueOfLegends
{
    // 부모 클래스 (기본 챔피언)
    class Champion
    {
        public string Name;
        protected int Health;
        protected int Mana;

        public Champion(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 합니다.");
        }

        public virtual void UseSkill()
        {
            Console.WriteLine($"{Name}은(는) 스킬을 사용할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다.");
        }
    }

    // 원거리 딜러 챔피언 (예: 애쉬)
    class Ashe : Champion
    {
        public Ashe() : base("Ashe", 600, 280) { }

        public override void Attack()
        {
            Console.WriteLine("Ashe가 활로 원거리 공격을 합니다.");
        }

        public override void UseSkill()
        {
            Console.WriteLine("Ashe가 다중 화살을 사용하여 다수의 적을 둔화시킵니다.");
        }
    }

    // 마법사 챔피언 (예: 라이즈)
    class Ryze : Champion
    {
        public Ryze() : base("Ryze", 575, 300) { }

        public override void Attack()
        {
            Console.WriteLine("Ryze가 마법 구체를 발사합니다.");
        }

        public override void UseSkill()
        {
            Console.WriteLine("Ryze가 룬 감옥을 사용하여 적을 속박합니다!");
        }
    }

    // 전사 챔피언 (예: 가렌)
    class Garen : Champion
    {
        public Garen() : base("Garen", 650, 0) { }

        public override void Attack()
        {
            Console.WriteLine("Garen이 대검으로 적을 내려칩니다.");
        }

        public override void UseSkill()
        {
            Console.WriteLine("Garen이 빛의 심판을 사용하여 적을 처형합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>();
            champions.Add(new Ashe());
            champions.Add(new Ryze());
            champions.Add(new Garen());

            foreach (var champ in champions)
            {
                champ.Move();
                champ.Attack();
                champ.UseSkill();
                Console.WriteLine();
            }
        }
    }
}
