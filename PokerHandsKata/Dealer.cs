using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsKata
{
    class Dealer
    {
        //public Dictionary<int, List<string>> DealCards()
        //{
        //    var PlayerHands = new Dictionary<int, List<string>>();

        //    Playerhands.Add();

        //    for (int c = 0; c < 10; c++)
        //    {
   
        //    } 
        //}

        private List<string> GetCards()
        {
            var cards = new List<string>()
            {
                "C2","C3","C4","C5","C6","C7","C8","C9","CT","CJ","CQ","CK","CA",
                "D2","D3","D4","D5","D6","D7","D8","D9","DT","DJ","DQ","DK","DA",
                "H2","H3","H4","H5","H6","H7","H8","H9","HT","HJ","HQ","HK","HA",
                "S2","S3","S4","S5","S6","S7","S8","S9","ST","SJ","SQ","SK","SA"
            };

            Shuffle(cards);
            return cards;
        }

        private void Shuffle(List<string> cards)
        {
            Random rand = new Random();

            for (var c = cards.Count; c > 0; c--)
            {
                Swap(cards, c - 1, rand.Next(c));
            }
        }

        private void Swap(List<string> cards, int counter, int random)
        {
            var temp = cards[counter];
            cards[counter] = cards[random];
            cards[random] = temp;
        }
    }
}
