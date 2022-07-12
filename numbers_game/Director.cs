public class Director 
{

    bool ifMatch = true;
    Player player1 = new Player();
    Number number1 = new Number();
    

    public Director()
    {
        StartGame();
        // Player player1 = new Player();
        // Number number1 = new Number(); 
        // number1.MakeNumberList();
        // number1.PrintNumbers();
        // Clear();
        // player1.GetNumbers(GetNumbersSeen());
        // Console.WriteLine();
        // player1.PrintNumbersSeen();
        // number1.PrintTrimmedString();
        // Compare(number1.ConvertToString(), GetNumbersSeen());

    }

    public string GetNumbersEntered()
    {
        string numbersEntered = Console.ReadLine();
        return numbersEntered.ToString();

    }


    public void Compare(string a, string b)
    {
        if (a == b) 
        {
            // return ifMatch;
            Console.WriteLine("You got it right");
        }
        // return ifMatch = false;
        Console.WriteLine("Oops. Try again");
        
    }

    public void StartGame()
    {   
        Console.WriteLine("This is a memory Game");
        Console.WriteLine();
        number1.MakeNumberList();
        number1.PrintNumbers();
        Clear();
        GetNumbersEntered();
        player1.GetNumbers(GetNumbersEntered());
        // Compare(number1.ConvertToString(), GetNumbersEntered());
        Console.WriteLine(GetNumbersEntered());
    }

    public void Clear()
    {
        Thread.Sleep(2000);
        Console.Clear();
       
    }


    
}