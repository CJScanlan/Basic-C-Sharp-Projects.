using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game //inheritance
    {
        public override void Play() //use override keyword to implement method
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
    }
}
