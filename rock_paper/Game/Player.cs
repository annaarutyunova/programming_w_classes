public class Player {
// decision
// keeps track of score
    public int score;
    private string player;
public char GetInputs() {
    Console.Write($"{player} choose (r)ock, (p)aper, or (s)cissors: ");
    char uI = Console.ReadLine().ToLower()[0];
    if (uI == 'r' || uI == 'p' || uI == 's')
        return uI;
    return GetInputs();
}
    public Player(string playerName) {
        this.player = playerName;
    }
}