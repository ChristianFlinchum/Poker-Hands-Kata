using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hands = new Dictionary<int, List<string>>();

            Console.WriteLine("Welcome To Poker Hands");
            Console.WriteLine("Please enter Player One's Hand");
            Hands.Add(1, Console.ReadLine().Split(',').ToList());
            Console.WriteLine("Please enter Player Two's Hand");
            Hands.Add(2, Console.ReadLine().Split(',').ToList());
        }
    }
}
