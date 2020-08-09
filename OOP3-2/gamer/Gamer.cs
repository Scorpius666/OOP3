using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_2.gamer
{
    class Gamer : IGamercheck,IPlay,IWork
    {
        private string Name;
        private int Money;
        private int Feeling;
        private string[] Owngame;

        public void Feelingcheck()
        {
            
            if(Feeling<=0)
            {
                Console.WriteLine("Your charater is dead. Game is over.");   
                System.Environment.Exit(0);
            }

        }

        public void GameCheck()
        {
            int i = Owngame.Length.Toint()  ;

            if ( != 0)
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        void IGamercheck.Feelingcheck()
        {
            throw new NotImplementedException();
        }

        void IPlay.GameCheck()
        {
            throw new NotImplementedException();
        }
    }
}
