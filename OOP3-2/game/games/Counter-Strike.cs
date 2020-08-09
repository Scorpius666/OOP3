using OOP3_2.kinds;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2.games
{
    class Counter_Strike : MOBAgame, IHoldgame
    {
        public void Preparation()
        {
            Console.WriteLine("Player is coming.");
        }

        public void Showending()
        {
            Random rd = new Random();

            if(rd.Next(1,10)%2==1)
            {
                Console.WriteLine("Team red si winner");
            }
            else
            {
                Console.WriteLine("Team bule is winner");
            }
        }

        public void Startgame()
        {
            throw new NotImplementedException();
        }
    }
}
