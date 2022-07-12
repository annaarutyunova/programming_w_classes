/// player is in charge of inputs
public class Player 
{
    List<string> numbers_seen = new List<string>();
    public Player()
    {

    }

    public List<string> GetNumbers(string userinput)
    {
        string t = userinput.Trim();
        t = t.Replace(" ", "");
        numbers_seen = t.Split("").ToList();
        return numbers_seen;
        // foreach(string i in numbers_seen)
        // {
        //     Console.WriteLine(i);
        // }
    }

/// In order to compare easier, trim the user input string, and replace spaces and commas with no spaces ("")  and compare it to the converted into string List of int (numbers)
}
