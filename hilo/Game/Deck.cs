using System;
using System.Collections.Generic;


namespace hilo.Game
{
    public class Deck {
        // Trying to define all the attributes and methods in the Deck class
        public int currentCard;
        public int nextCard;
        
        public int GenerateRandomNumber()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1,14);
        }
        public void UpdateCard() 
        {
            currentCard = nextCard;
            nextCard = GenerateRandomNumber();
        
        }
        public void showCards(){
           Console.WriteLine("Current Cards: ");
           Console.WriteLine(currentCard);
           Console.WriteLine(nextCard);            
        }
        public Deck()
        {
           currentCard = GenerateRandomNumber();
           nextCard = GenerateRandomNumber(); 

            // showCards();
            // UpdateCard();
            // showCards();
        }
    }
}