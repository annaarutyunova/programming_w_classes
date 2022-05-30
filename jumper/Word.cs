public class Word {
    List<string> words = new List<string>();
    public List<char> chars = new List<char>();
    public List<char> dashes = new List<char>();
    public Word(){
        GetWordList();
        GetWord();
        SetDashes(); 
    }
    public void GetWordList(){
        var reader = new StreamReader(File.OpenRead(@"C:\Git_GitHub\programming_w_classes\jumper\nouns-with-7-letters.csv")); 
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(';');

            words.Add(values[0]);
        }
    }
    public void GetWord() {
        Random random = new Random();
        int randomIndex = random.Next(words.Count);
        string randomWord = words[randomIndex];
        Console.WriteLine(randomWord);
        chars.AddRange(randomWord);
        Console.WriteLine(String.Join(", ", chars));
    }
    
    public void SetDashes() {
        foreach(char character in chars) {
            dashes.Add('_');
        }
    }
    public void DisplayDashes() {
        foreach(char character in dashes) {
            Console.Write($"{character} ");
        }
        Console.WriteLine();
    }



}    

