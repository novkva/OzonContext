using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonContext.PreCompetition
{
    public class TestD
    {
        public static void TestDMain(string[] args)
        {
            TimeOnly time = TimeOnly.Parse("23:34:09");
            Console.WriteLine(time);
            var testCaseCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCaseCount; i++)
            {
                var empt = Console.ReadLine();
                var size = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray(); // size of mas
                List<int> matrix = new List<int>();
                for (int s = 0; s < size[0]; s++)
                {
                    var line = Console.ReadLine().Split(' ').Select(it => int.Parse(it));
                    foreach (var l in line)
                    {
                        matrix.Add(l);
                    }
                }
                var numberOfClicks = int.Parse(Console.ReadLine());
                var clicks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
               // Transponation(matrix);
                Console.WriteLine();
                var d = Console.ReadLine().Split(' ').Select(it => int.Parse(it));
                foreach (var g in d)
                {
                    matrix.Add(g);
                }
            }
        }

        public static void Transponation(List<List<int>> matrix)
        {
            var result = new List<List<int>>();
            var ind = 0;
            foreach (var item in matrix)
            {
                foreach(var i in item)
                {
                    var g = result[ind];
                }
                ind++;
            }
        }
    }
}
