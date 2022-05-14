public class Source 
{

    private string name = "";
    private string url = "";

    public Source(string name, string url="") //the ="" for url makes that parameter optional. So if the user doent't include it. the default is blank ("");
    {
        this.name = name; //this.name refers to the attribute we declared at the beginning of Source class
        this.url = url;
    }

    public string GetName() 
    {
        return name;
    }

    public string GetUrl() 
    {
        return url;
    }
}