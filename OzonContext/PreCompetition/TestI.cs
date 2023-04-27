using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzonContext.PreCompetition
{
    public class TestI
    {
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
