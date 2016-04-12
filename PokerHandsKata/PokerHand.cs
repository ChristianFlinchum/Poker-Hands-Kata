using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsKata
{
    public class PokerHand
    {
        private List<string> _userInput = new List<string>();
        private Dictionary<int, List<string>> _hands = new Dictionary<int, List<string>>();

        public PokerHand(List<string> userInput)
        {
            _userInput = userInput;
        }

        //public Dictionary<int, List<string>
        //    get {return GetHands}

        //private void GetHands();
        //{
        //    _hand
        //}
    } 
}
