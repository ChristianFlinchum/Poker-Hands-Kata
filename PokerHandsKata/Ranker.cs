using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsKata
{
    public class Ranker
    {
        private Dictionary<int, List<string>> _hands = new Dictionary<int, List<string>>();

        public Ranker (Dictionary<int, List<string>> hands)
        {
            _hands = hands;
        }

        private void HandSort()
        {
            //_hands
        }
    }
}
