using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6T3
{
    class Card
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
    class DeckOfCards
    {
        private List<Card> cards;

        public DeckOfCards()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public override string ToString()
        {
            string temp = "";
            int count = 1;
            foreach (Card card in cards)
            {
                temp += count + " card is: " + card + "\n";
                count++;
            }
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = CreateDeck();
            Console.WriteLine(deck.ToString());

        }
        static DeckOfCards CreateDeck()
        {
            DeckOfCards deck = new DeckOfCards();
            string cards = "";

            for (int x = 0; x < 4; x++)
            {
                switch (x)
                {
                    case 0:
                        cards = "Diamond#";
                        break;
                    case 1:
                        cards = "Club#";
                        break;
                    case 2:
                        cards = "Spade#";
                        break;
                    case 3:
                        cards = "Heart#";
                        break;
                }
                for (int y = 1; y < 14; y++)
                {
                    Card a = new Card();
                    a.Value = cards + y;
                    deck.AddCard(a);
                }
            }
            return deck;
        }
    }
}
