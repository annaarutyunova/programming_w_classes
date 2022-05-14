public class Board 
{
    List<Quote> quotes = new List<Quote>();

    public void NicePrint(string item)
    {

    }

    public void ShowQuotes()
    {
        foreach(Quote quote in quotes)
        {
            Console.WriteLine(quote.GetQuote());
        }
    }

    public void AddQuote(Quote quote)
    {
        quote.Add(quote);
    }

    public void GetRandomQuote()
    {
        var random = new Random();
    
    }

    public void StartBoard()
    {
        string response = "";
    }
}