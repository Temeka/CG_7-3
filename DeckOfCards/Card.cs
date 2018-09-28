using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Card

        //this class of Metods is telling console to print 
        //the value and suit that was randomly drawn
    {
        public string FaceValue { get; set; }

        public string CardSuit { get; set; }

        public string CardName
        {
            get {return $"{FaceValue} of {CardSuit}"; }
        }

    }
     
}
