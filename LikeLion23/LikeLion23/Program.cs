using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion23
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }
            
            var firstName = names.First(n => n.StartsWith("A"));

            Console.WriteLine($"First name starting with A: {firstName}");

            int[] data = { 10, 20, 30 };
            int target = 22;
            int nearest = data[0];
            
            foreach(var d in data)
            {
                if(Math.Abs(target-nearest)>Math.Abs(target - d))
                {
                    nearest = d;
                }
            }

            Console.WriteLine($"Nearest to {target} : {nearest}");

            int[] scores = { 90, 70, 50, 70, 60 };

            for (int i = 0; i < scores.Length; i++)
            {
                int rank = 1;

                for(int j=0; j<scores.Length;j++)
                {
                    if (scores[j] > scores[i])
                    {
                        rank++;
                    }
                }
                Console.WriteLine($"Score: {scores[i]}, Rank: {rank}");
            }



        }
    }
}
