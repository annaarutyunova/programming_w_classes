class Program{
    static void Main()
    {
        Player player1 = new Player("player1");
        char userInput = player1.GetInputs();
        Console.WriteLine(userInput);
    }
}