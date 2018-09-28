using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck

        //this class is setting the array and telling the system
        //to return a random card each go round
    {
       public Card[] Cards { get; set; }

        public Deck()
        {
            Cards = new Card[52];
        }

        public Card Deal()
        {
            Random random = new Random();
            Card rndCard = Cards[random.Next(Cards.Length)];

            return rndCard;
        }
    }
}
   


        
    
    

        

