using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion17
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[2];

            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;



            foreach (var point in points)
            {
                Console.WriteLine($"Point: ({point.x},{point.y})");
            }


            Grade[] grades = new Grade[3];

            for(int i = 0;i < grades.Length; i++)
            {
                Console.WriteLine($"{i+1}번째 학생의 성적을 입력합니다.");
                Console.Write("이름 : ");
                grades[i].name = Console.ReadLine();
                Console.Write("국어 성적 : ");
                grades[i].kor = int.Parse(Console.ReadLine());
                Console.Write("영어 성적 : ");
                grades[i].eng = int.Parse(Console.ReadLine());
                Console.Write("수학 성적 : ");
                grades[i].math = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("이름           국어  영어  수학");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"{grades[i].name,-10} {grades[i].kor,5} {grades[i].eng,5} {grades[i].math,5}");
            }
        }
    }

    // 클래스와 비슷하지만, 값 타임이며 가볍고 빠름
    // 주로 간단한 데이터 묵음을 만들때 사용

    struct Point
    {
        public int x;
        public int y;
    }

    struct Grade
    {
        public string name;
        public int kor;
        public int eng;
        public int math;
    }

}
