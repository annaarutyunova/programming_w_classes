public class Quote 
{
    private string author = "";
    private string quote = "";
    private Source source;

    public Quote(string person, string quote, Source source) 
    {
        this.author = person;
        this.quote = quote;
        this.source = source;
    }

    public bool HasAuthor(string name) 
    {
        if(author.ToUpper().Contains(name.ToUpper()))
        {
            return true;
        }
        return false;
    }

    public string GetQuote() 
    {
        string url = source.GetUrl();
        url = url != "" ? $"[{url}]" : ""; //if(url!="") {url = $"[{url}]";} else { url = ""}
        return $"\"{quote}\"\n{author} - {source.GetName()}{url}";
    }
}