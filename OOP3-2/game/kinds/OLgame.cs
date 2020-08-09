using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2.kinds
{
    class OLgame : Game, IOnline
    {
        public void PlayOnline()
        {
            Console.WriteLine("Now you play on line.");
        }
    }
}
