using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion20
{

    //class Person
    //{
    //    private string name; // 내부 변수

    //    // 값 설정하기 (Setter)
    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}


    //class Person
    //{
    //    private string name; //내부변수

    //    public string Name //프로퍼티
    //    {
    //        get { return name; } //Getter
    //        set { name = value; } //Setter
    //    }
    //}


    //class Person
    //{
    //    private int count = 100;
    //    public string Name { get; set; } // 자동 구현 프로퍼티
    //    public int Count
    //    {
    //        get { return count; }
    //    }
    //    public float Balance { get;private set; } // 외부 변경 불가
    //    public void AddBal()
    //    {
    //        Balance += 100;
    //    }
    //}

    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 50;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //c#에서 get/set 방식의 함수와 프로퍼티 비교
            //c#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 매서드) 또는
            //**프로퍼티(property)**를 사용할 수 있다.
            //Person p = new Person();
            //p.SetName("홍길동");

            //Console.WriteLine("이름 : "+ p.GetName());

            //Person p = new Person();
            //p.Name = "홍길동";
            //Console.WriteLine(p.Name);

            //Person p = new Person();

            //p.Name = "홍길동";
            //p.AddBal();
            //Console.WriteLine("이름 : " + p.Name + " Count : " + p.Count + " Balance " + p.Balance);

            Marin m = new Marin();
            Console.WriteLine("이름 : " + m.Name + " 미네랄 : "+ m.Mineral);


        }
    }
}
