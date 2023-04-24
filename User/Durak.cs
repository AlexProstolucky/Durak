using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Durak
{
    class Player
    {
        public string name { get; }
        public List<Card> koloda = new ();
        public List<SpecialAbilities> sa = new();
        public bool IsPlaying { get; set; }
    }
    class Game
    {
        List<Player> p = new();
        List<Card> koloda = new();
        List<Card> rebound = new();
        bool trase;

        public Game(List<Card> buff, List<Player> p_buff, bool transefeble) { }
        public void give_cards() { }
        public void mixing() 
        {
            
        }
    }
}
