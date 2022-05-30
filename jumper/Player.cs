public class Player {
    List<string> guesses = new List<string>();

    public Player() {

    }

    public void Guess() {
        for(int i = 0; i < 5; i++) {
            Console.WriteLine("Pick any letter from a to z ");
            string guess = Console.ReadLine();
            guesses.Add(guess);
        }
        foreach(var item in guesses)
        {
            Console.WriteLine(item);
        }
        
    }
    
}