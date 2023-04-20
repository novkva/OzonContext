public class TestB
{
    public static void TestBMain(string[] args)
    {
        
        var testCaseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i< testCaseCount; i++)
        {
            var count = int.Parse(Console.ReadLine());
            var collection = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            Find(collection);
        }
    }

    public static void Find(int[] mas)
    {
        Dictionary<int, int> skus = new Dictionary<int, int>();
        for (int i = 0; i < mas.Length; i++)
        {
            if (!skus.ContainsKey(mas[i]))
            {
                skus.Add(mas[i], 1);
            }
            else
            {
                skus[mas[i]] = skus[mas[i]] + 1;
            }
        }
        int res = 0;
        foreach(var d in skus)
        {
            res += d.Key * (d.Value - d.Value / 3);
        }
        Console.WriteLine(res);
    }
}
