using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //base class - never instantiated, only inherited from
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //any inheriting class must implement this method

        public virtual void ListPlayers() //virtual method in abstract class:
                                           // this method gets inherited, but can be overridden
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
