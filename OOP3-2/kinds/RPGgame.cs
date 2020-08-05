using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2.kinds
{
    class RPGgame : Game,ITouching
    {
        private string LoveStroy;

        public void Touching()
        {
            Console.WriteLine("What a story you be moved.");
        }
    }
}
