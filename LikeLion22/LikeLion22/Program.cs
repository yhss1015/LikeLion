using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion22
{
    class Program
    {
        static void Main(string[] args)
        {

            ////값 형식과 참조 형식
            ////값 형식은 스택에 저장되고, 참조형식은 힙에 저장됩니다.

            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}");
            //Console.WriteLine($"ReferenceType : {referenceType}");


            ////박싱 언박싱
            ////값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value; //박싱
            //int unboxed = (int)boxed; //언박싱

            //Console.WriteLine($"Boxed : {boxed}, unboxed : {unboxed}");


            ////is연산자
            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); //false

            //as 연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다.

            //object obj = "Hello";
            //string str = obj as string;
            //Console.WriteLine(str is string);


            //object obj = 42;

            //if(obj is int number)
            //{
            //    Console.WriteLine($"Number : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}


            ////문자열 다루기

            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); //Hello,Alice

            //Console.WriteLine($"Length of name : {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper : {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring : {name.Substring(1)}"); //부분 문자열 1부터


            ////string 다양한 aotjem
            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C# : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replacec 'awesome' with 'great' : {text.Replace("awesome", "great")}");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());


            ////String과 StringBuilder클래스 성능차이 비교
            ////반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.

            //int iterations = 10000;

            //Stopwatch sw = Stopwatch.StartNew();

            //string text = "";

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}

            //sw.Stop();
            //Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");

            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch 



            //while (true)
            //{

            //    try
            //    {
            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]); //오류 발생
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Error : {ex.Message}");
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        int number = int.Parse("NotANumber"); //오류발생
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine($"Format Error: {ex.Message}");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("항상실행됩니다.");
            //    }
            //}


            ////Exception 클래스 
            ////모든예외의 기본 클래스입니다.

            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}


            //try
            //{
            //    int age = -5;
            //    if (age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}


            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}



            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기


            //while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current);//현재 요소 출력
            //}

            //var collection = new SimpleCollection();

            //foreach (var i in collection)
            //{
            //    Console.WriteLine(i);
            //}


            //int? nullableInt = null;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");



            //string str = null;

            //if (str == null)
            //{
            //    Console.WriteLine("DefaultValue");
            //}

            //Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value


            ////LINQ는 확장메서드 형태로 제공된다. 
            ////LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}


            Warrior warrior = new Warrior();
            warrior.Name = "용사";
            warrior.Score = 50;
            warrior.Strength = 100;
            Console.WriteLine($"이름 : {warrior.Name}\n점수 : {warrior.Score}\n힘 : {warrior.Strength}");

            Console.Write("숫자를 입력하세요 : ");
            
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"입력하신 숫자는 {input} 입니다.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format Error: {ex.Message}");
            }


            List<string> fruits = new List<string>{ "사과", "바나나", "포도" };
            foreach(string str in fruits)
            {
                Console.WriteLine(str);
            }
            Queue<string> jobs = new Queue<string> ();
            jobs.Enqueue("첫 번째 직업");
            jobs.Enqueue("두 번째 직업");
            jobs.Enqueue("세 번째 직업");
            while(jobs.Count>0)
            {
                Console.WriteLine(jobs.Dequeue());
            }
            Stack<int> numbers = new Stack<int>();
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);
            while(numbers.Count>0)
            { 
                Console.WriteLine(numbers.Pop());
            }


            Console.Write("문자열 입력 : ");
            string text = Console.ReadLine();
            text = text.ToUpper();
            Console.WriteLine(text.Replace("C#", "CSharp"));


            int[] numberss = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numberss.Where(n => n % 2 == 0);

            int sum = 0;

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            foreach (var num in numberss)
            {
                sum += num;
            }

            Console.WriteLine($"총합 : {sum}");
            
            
        }

        


    }

    class Warrior
    {
        public string Name;
        public int Score;
        public int Strength;

    }


    class SimpleCollection : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
