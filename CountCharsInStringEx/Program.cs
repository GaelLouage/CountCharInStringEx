internal class Program
{
    private static void Main(string[] args)
    {
        var charCounter = Count("Hello, World!");
        foreach (var item in charCounter)
        {
            Console.WriteLine($"Key: {item.Key} - Count: {item.Value}");
        }
    }

    public static Dictionary<char, int> Count(string str)
    {
        var charCounter = new Dictionary<char, int>();
        foreach (var c in str) 
        {
            if (charCounter.ContainsKey(c))
            {
                charCounter[c]++;
            }
            else
            {
               charCounter.Add(c, 1);
            }
        }
        return charCounter;
    }
    public static Dictionary<char, int> CountLinq(string str)
    {
        return str.GroupBy(x => x).ToDictionary(c => c.Key, c => c.Count());
    }
}