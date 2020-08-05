using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2
{
    class Game :IRelax
    {
        private string Name;

        public void Relax()
        {
            Console.Write("Now you are relaxed.");
        }
    }
}
