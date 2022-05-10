
//list of 1-9
//function that print the grid (void type)
//main with while loop
//function end game (if statements. return boolean)

// activePlayer, place, how the board looks like after each turn

string[] startingPositions = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
List<string> positions = new List<string>(startingPositions);
string activePlayer = "X";
bool playing = true;

void ShowBoard()  
{
    Console.WriteLine($"|{positions[0]}||{positions[1]}||{positions[2]}|");
    Console.WriteLine($"|{positions[3]}||{positions[4]}||{positions[5]}|");
    Console.WriteLine($"|{positions[6]}||{positions[7]}||{positions[8]}|");
}

bool IsWinner()
{
    string win = $"{activePlayer}{activePlayer}{activePlayer}";
    if($"{positions[0]}{positions[1]}{positions[2]}" == win) return true;
    if($"{positions[3]}{positions[4]}{positions[5]}" == win) return true;
    if($"{positions[6]}{positions[7]}{positions[8]}" == win) return true;
    if($"{positions[0]}{positions[3]}{positions[6]}" == win) return true;
    if($"{positions[1]}{positions[4]}{positions[7]}" == win) return true;
    if($"{positions[2]}{positions[5]}{positions[8]}" == win) return true;
    if($"{positions[0]}{positions[4]}{positions[8]}" == win) return true;
    if($"{positions[2]}{positions[4]}{positions[6]}" == win) return true;
    
    return false;

}
void Play()
{
    int turn = 0;
    while (playing)
    {
        Console.WriteLine($"Where do you want to place {activePlayer}");
        int position = int.Parse(Console.ReadLine());
        // Check if position is available
        string positionRequested = positions[position - 1];
        if (positionRequested == "O" || positionRequested == "X")
        {
            Console.WriteLine("The spot is taken. Pick a different number.");
            continue;
        }
        positions[position - 1] = activePlayer;
        ShowBoard();
        if (IsWinner())
        {
            Console.WriteLine($"The game is over. {activePlayer} won!");
            playing = false;
        }
        turn ++;
        if (turn == 9) 
        {
            Console.WriteLine("The game is over. It's a draw");
            playing = false;
        }
        activePlayer = activePlayer == "X" ? "O" : "X"; //inline if statement.
    }
}

void Main()
{
    ShowBoard();   
    Play();
    Console.WriteLine("Would you like to play again? y/n");
    string again = Console.ReadLine();
    if (again == "y") {
        Play();
    }
    else
    {
        Console.WriteLine("See ya!");
    }

}

Main();


    
        