using System.Collections.Generic;

namespace deckofcards
{
    public class Player
    {
        public string Name {get;set;}
        public List<Card> Hand {get;set;}

        
        public void Draw(Deck deck)
        {
            Hand.Add(deck.Deal());
        }
        public Card Discard(int idx)
        {
            Card removedCard = Hand[idx -1];
            Hand.RemoveAt(idx-1);
            return removedCard;
        }
        public Player(string name)
        {
            Name = name;
            Hand = new List <Card>();
        }
    }
}