namespace deckofcards
{

    public class Card
    {
        public string  StringVal {get;set;}
        public string  Suits {get;set;}
        public int Val {get;set;}
    
        public Card (string strval, string suits, int val)
        {
            StringVal = strval;
            Suits = suits;
            Val = val;
        }

    }

}