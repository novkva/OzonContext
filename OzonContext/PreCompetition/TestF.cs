namespace OzonContext.PreCompetition
{
    public class TestF
    {
        public static void Main(string[] args)
        {
            var testCaseCount = int.Parse(Console.ReadLine());
            for (int c = 0; c < testCaseCount; c++)
            {
                var count = int.Parse(Console.ReadLine());
                var di = new Diapazon();
                for (int i = 0; i < count; i++)
                {
                    TimeOnly[] diap = new TimeOnly[2];
                    try
                    {
                        diap = Console.ReadLine().Split('-').Select(d => TimeOnly.Parse(d)).ToArray();
                    }
                    catch
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(1);
                    }
                    CheckDiap(diap);
                    di.Add(new Interval(diap));
                }
            }
        }

        public static void CheckDiap(TimeOnly[] diap)
        {
            if (diap[0] > diap[1])
            {
                Console.WriteLine("NO");
                Environment.Exit(1);
            }
        }

    }
    public class Diapazon
    {
        List<Interval> Intervals { get; set; }

        public bool Add(Interval interval)
        {
            Intervals ??= new List<Interval>();
            var startCount = Intervals.Count;
            var day = new TimeOnly(0, 0, 0);
            var night = new TimeOnly(23, 59, 59);
            for (int i = 0; i < Intervals.Count - 1; i++)
            {
                if (interval.Start > Intervals[i].End && interval.End < Intervals[i + 1].Start && interval.Start >= day && interval.End <= night)
                {
                    Intervals.Insert(i + 1, interval);
                    break;
                }
            }
            if (startCount == Intervals.Count)
            {
                return false;
            }
            return true;
        }
    }

    public class Interval
    {
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }
        public Interval(TimeOnly[] interval)
        {
            Start = interval[0];
            End = interval[1];
        }
    }
}

