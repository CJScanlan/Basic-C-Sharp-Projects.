using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } //does not inherit from deck class; dealer is not a type of deck
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //Add first item of list
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); //Remove first item from deck
        }
    }
}
