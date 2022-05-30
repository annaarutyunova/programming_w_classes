using hilo.Game;


namespace hilo
{

    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>


        static int Main(string[] args)
        {
            Deck deck = new Deck();
            bool playing = true;

            Player player = new Player(); 
            while(playing){ 
                player.Guess(deck);
                playing = KeepPlaying(player);
                deck.UpdateCard();
            }

            return 0;          
        }
        static bool KeepPlaying(Player player) {
            if(player.score <= 0) {
                Console.WriteLine("You lost.");
                Console.WriteLine("Would you like to continue playing? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y") {
                    player.score = 300;
                    return true;
                }
                return false;
            }
            if (player.score >= 700) {
                Console.WriteLine("Would you like to continue playing? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y") {
                    return true;
                }
                return false;
            }
            return true;
            // if (score >= 500) {
            //         Console.WriteLine("Would you like to continue playing? y/n");
            //         string answer = Console.ReadLine();
            //     }
        
        // }
        }


    }      
}




