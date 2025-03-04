using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion19
{
    //마린 클래스
    //이름 미네랄
    //기본생성자, 인자있는 생성자
    class Marin
    {
        public string name;
        public int mineral;

        public Marin()
        {
            name = "마린";
            mineral = 50;
            Console.WriteLine("기본생성자 돌아감");
        }

        public Marin(string Name, int Mineral)
        {
            name= Name;
            mineral = Mineral;
            Console.WriteLine("매개변수 생성자 돌아감");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
        }
    }

    class SCV
    {
        public string name;
        public int mineral;

        public SCV()
        {
            name = "SCV";
            mineral = 50;
            Console.WriteLine("기본생성자 돌아감");
        }

        public SCV(string Name, int Mineral)
        {
            name = Name;
            mineral = Mineral;
            Console.WriteLine("매개변수 생성자 돌아감");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
        }
    }

    //배럭클래스 만들기
    class Barracks
    {
        public string name;
        public int mineral;

        public Barracks()
        {
            name = "Barracks";
            mineral = 150;
            Console.WriteLine("기본생성자 돌아감");
        }

        public Barracks(string Name, int Mineral)
        {
            this.name = Name;
            this.mineral = Mineral;
            Console.WriteLine("매개변수 생성자 돌아감");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
        }
    }

    //미네랄클래스
    // Mineral 1500
    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }

    }


    //Game클래스를 만들어보자.
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구수 : {charCount}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Marin marin = new Marin();
            //SCV scv = new SCV();

            //marin.ShowInfo();
            //scv.ShowInfo();

            //Marin marin1 = new Marin("아드마린",100);
            //SCV scv1 = new SCV("고급scv",100);
            //marin1.ShowInfo();
            //scv1.ShowInfo();

            //Barracks barracks = new Barracks();
            //barracks.ShowInfo();
            //Barracks barracks1 = new Barracks("고급배럭",200);
            //barracks1.ShowInfo();

            ////클래스 배열
            //Mineral[] mineral = new Mineral[7];
            ////클래스 배열안에 있는 클래스들에 생성자 할당 객체화
            //for (int i = 0; i < mineral.Length; i++)
            //{
            //    mineral[i] = new Mineral();
            //    mineral[i].ShowInfo();
            //}


            Game.mineral = 50;
            Game.gas = 10;
            Game.charCount = 5;

            Game.ShowInfo();

        }
    }
}
