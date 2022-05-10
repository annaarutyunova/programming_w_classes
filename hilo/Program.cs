public class Deck {
    // Trying to define all the attributes and methods in the Deck class
    public int currentCard;
    public int nextCard;
    
    public int GenerateRandomNumber()
    {
        Random randomNumber = new Random();
        return value = randomNumber.Next(1,14);
    }
    public void UpdateCard() 
    {
        currentCard = nextCard;
        int nextCardUpdated = GenerateRandomNumber();
        if (nextCardUpdated == currentCard)
        {
            
        }
    
    }
    public Deck()
    {
    
    }
}

public class Player {
    public int score = 300;

    public void Guess() {
        Deck deck = new Deck();
        Console.WriteLine(deck.currentCard = GenerateRandomNumber());
        Console.WriteLine("lower or higher? Type l/h? ");
        string guess = Console.Readline();
        if (guess == l)
        {

        }
    }
}


