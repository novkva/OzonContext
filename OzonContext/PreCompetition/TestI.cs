using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonContext.PreCompetition
{
    public class TestI
    {
        public static void Main(string[] args)
        {

            var testCaseCount = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            var processes = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

            for (int i = 0; i < testCaseCount[1]; i++)
            {
                var process = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray(); 
            }
        }
    }

    public class Tasker
    {
        public int CurrentTime { get; set; }
        public int ProccessorCount { get; set; }

        public Tasker(int procCount)
        {
            CurrentTime = 0;
            ProccessorCount = procCount;
        }
    }
}
