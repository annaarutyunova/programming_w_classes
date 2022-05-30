public class Director {

    Word word;
    Jumper jumper;
    List<char> guesses = new List<char>();
    int fails = 0;

    public Director() {
        word = new Word();
        jumper = new Jumper();
        
        
    }

    public void StartGame() {
        Console.WriteLine("Welcome to Jumper game");
        jumper.DisplayJumper();
        word.DisplayDashes();
        Guess();
    }

    public void Guess() {
        while(fails < 6) {
            Console.WriteLine();
            Console.WriteLine("Pick any letter from a to z ");
            char guess = char.Parse(Console.ReadLine());
            if(guesses.Contains(guess)) {
                Console.WriteLine("You've used that letter before. Try a different one. ");
            }
            else {
                guesses.Add(guess);
                HandleGuess(guess);
                jumper.DisplayJumper();
                word.DisplayDashes();
            }
        }
    }

    public void HandleGuess(char guess) {
        if(word.chars.Contains(guess)) {
            int index = word.chars.IndexOf(guess);
            Console.WriteLine(index);
            word.dashes[index] = guess;
        }
        else {
            jumper.UpdateJumper();
            fails += 1;
        }
    }

    public void FailMessage() {
        Console.WriteLine($"The word does not contain {guesses[guesses.Count-1]}. Try again. ");
    }

}