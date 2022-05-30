using System;
using System.Collections.Generic;


namespace hilo.Game
{
    public class Player {
        public int score = 300;

        public void Guess(Deck deck) {
            Console.WriteLine(deck.currentCard);
            Console.WriteLine("lower or higher? Type l/h? ");
            string guess = Console.ReadLine();
            if (guess == "l")
            {
                if(deck.currentCard > deck.nextCard){
                    Console.WriteLine("Good job");
                    score += 100;
                }
                else {
                    Console.WriteLine("Try again");
                    score -=75;
                }
                Console.WriteLine($"Your score is: {score}");
            }
            else if (guess == "h") {
                if(deck.currentCard < deck.nextCard) {
                    Console.WriteLine("Well done");
                    score +=100;
                }
                else {
                    Console.WriteLine("Try again");
                    score -=75;
                }
                Console.WriteLine($"Your score is: {score}");
            }
            
            else {
                Console.WriteLine("Please enter l or h");
                Guess(deck);
            }

            

        }
    }
}