using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion25
{
    //메서드 오버라이딩
    //부모 클래스의 메서드를 자식 클래스에서 재정의하여 다른 동작을 수행한다.

    class Animal
    {
        public string Name { get; set; }

        //가상 메서드 : 자식 클래스에서 재정의 가능하게함.
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 낸다.");
        }
    }

    class Dog : Animal
    {
        //부모 클래스의 메서드를 오버라이딩(재정의)
        public override void Speak()
        {
            Console.WriteLine($"{Name}가 짖습니다.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak();


        }
    }
}
