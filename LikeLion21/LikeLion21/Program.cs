using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion21
{
    //클래스시그니처 기본구성
    //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

    //[접근 지정자] [수정자] class 클래스이름  : 부모클래스 , 인터페이스
    //public       abstract                  : BaseClass  ,IComparable
    //private      sealed
    //protected    static
    //             partial

    //기본클래스
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    //상속하는 클래스
    public class Warrior : Player
    {
        public int Strength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    //public class Enemy: IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }

    //}
    //추상 클래스 (abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }


    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
    }
}
