using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating variables
            Deck deck = new Deck();
            Card cards = new Card();

            //setting the interger counter to zero
            int counter = 0;

            for (int i = 2; i <= 14; i++) //loop through the face value 
            {
                string faceValue;
                if (i < 11) faceValue = i.ToString();
                else if (i == 11) faceValue = "Jack";
                else if (i == 12) faceValue = "Queen";
                else if (i == 13) faceValue = "King";
                else faceValue = "Ace";

                for (int j = 1; j <= 4; j++) //looping through the suit...inside a loop
                {
                    string suit;
                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "Spades";
                    else suit = "Clubs";

                    deck.Cards[counter] = new Card
                    {
                        FaceValue = faceValue,
                        CardSuit = suit
                    };
                    counter++;

                   
                }
            }
            
            var card = deck.Deal();

            Console.WriteLine(card.CardName);

            Console.ReadLine();
        }
    }
}
    

    

