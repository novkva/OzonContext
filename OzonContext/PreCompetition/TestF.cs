namespace OzonContext.PreCompetition
{
    public class TestF
    {
        public static void TestFMain(string[] args)
        {
            var testCaseCount = int.Parse(Console.ReadLine());
            for (int c = 0; c < testCaseCount; c++)
            {
                bool final = true;
                var count = int.Parse(Console.ReadLine());
                string[] strings = new string[count];
                for (int i = 0; i < count; i++)
                {
                    strings[i] = Console.ReadLine();
                }
                var di = new Diapazon();
                for (int i = 0; i < count; i++)
                {
                    TimeOnly[] diap = new TimeOnly[2];
                    try
                    {
                        diap = strings[i].Split('-').Select(d => TimeOnly.Parse(d)).ToArray();
                    }
                    catch
                    {
                        final = false;
                        Console.WriteLine("NO");
                        break;
                    }
                    if (CheckDiap(diap))
                    {
                        if (!di.Add(new Interval(diap)))
                        {

                            final = false;
                            Console.WriteLine("NO");
                            break;
                        }

                    }
                    else
                    {
                        final = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }
                if (final) Console.WriteLine("YES");
            }
        }

        public static bool CheckDiap(TimeOnly[] diap)
        {
            if (diap[0] > diap[1])
            {
                return false;
            }
            return true;
        }

    }
    public class Diapazon
    {
        List<Interval> Intervals { get; set; }
        public readonly TimeOnly day = new TimeOnly(0, 0, 0);
        public readonly TimeOnly night = new TimeOnly(23, 59, 59);

        public bool Add(Interval interval)
        {
            if (Intervals is null)
            {
                Intervals = new List<Interval>
                {
                    interval
                };
                return true;
            }
            var startCount = Intervals.Count;
            for (int i = 0; i < Intervals.Count; i++)
            {
                if (!(Intervals[i].NotIncluding(interval) && interval.Start >= day && interval.End <= night))
                {
                    return false;
                }
            }
            Intervals.Add(interval);
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

        public bool NotIncluding(Interval interval)
        {
            if ((interval.Start < this.Start) && (interval.End < this.Start)) return true;
            if ((interval.Start > this.End) && (interval.End > this.End)) return true;
            return false;
        }
    }
}
//oh no, its just a test comment, i dont have time
