public class Program 
{
    static void Main()
    {
        // Source s = new Source("The Living Christ");
        // Console.WriteLine(s.GetName());
        Quote q = new Quote("Paul", "God hath  not given us the spirit of fear; but of power, and of love, and of a sound mind", new Source("2 Timothy 1:7"));
        Console.WriteLine(q.GetQuote());
    }
}