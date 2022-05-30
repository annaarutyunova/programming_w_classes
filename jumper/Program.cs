// Question. I want to have a separate funtion that reads a csv file into an list. And a function that picks a random word from that list. But my list is local. It doesn't work when I create it outside of my function for some reason. Maybe I am doing it wrong. What if I return a list in that function? Could I pass it to my GetRandomWord() function then? Would I pass GetWordList() function to it?
// Also why wouldn't it let me insert a the path to my file in quotes if I want to reuse the function and pass a string filename into GetWordList function


// GetWordList();
// Player player = new Player();
// List<string> words = new List<string>();
// player.Guess(words);
// Jumper jumper = new Jumper();
// jumper.UpdateJumper2();

public class Program {
    static void Main(string[] arg) {
        Director newGame = new Director();
        newGame.StartGame();
    }
}




    
