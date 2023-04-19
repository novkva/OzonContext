using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonContext.PreCompetition
{
    internal class TestC
    {
        public static void TestCMain(string[] args)
        {

            var testCaseCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCaseCount; i++)
            {
                var count = int.Parse(Console.ReadLine());
                int k = 1;
                var collection = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToDictionary(c => k++);

                Find(collection);
                Console.WriteLine();
            }
        }

        public static void Find(Dictionary<int, int> mas)
        {
            int numb = mas.Count / 2;
            for (int i = 0; i < numb; i++)
            {
                var one = mas.First();
                mas.Remove(one.Key);
                var two = mas.First();
                int minraz = 100;
                foreach (var m in mas)
                {
                    int now = Math.Abs(one.Value - m.Value);
                    if (now == 0)
                    {
                        two = m;
                        break;
                    }
                    if (now < minraz)
                    {
                        minraz = now;
                        two = m;
                    }
                }
                Console.WriteLine($"{one.Key} {two.Key}");
                mas.Remove(two.Key);
            }
        }
    }
}
