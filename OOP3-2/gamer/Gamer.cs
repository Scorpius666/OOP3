using OOP3_2.gamer.@interface;
using System;

namespace OOP3_2.gamer
{
    class Gamer : IFeelingcheck, IGamecheck, IPlay, IWork, IName, IBorn, IGamercheck
    {
        private string Name;
        private int Money;
        private int Feeling;
        private string[] Owngame = new string[5];

        public void Feelingcheck()
        {
            if(Feeling<=0)
            {
                Console.WriteLine("Your charater is dead. Game is over.");   
                System.Environment.Exit(0);
            }
        }

        public int Feelingfeedback()
        {
            return Feeling;
        }

        public void Gamecheck()
        {
            string i = Owngame.Length.ToString();
            int j = int.Parse(i);
            if(j==0)
            {
                Console.WriteLine("Sorry you has not own any games.");//应考虑无游戏时如何退回主程序
            }
        }

        public string[] Gamefeedback()
        {
            return Owngame;
        }

        public void Play()
        {
            Feeling += 10;
        }

        public void Work()
        {
            Money += 40;
            Feeling -= 10;
        }

        public void Nameing(string name)
        {
            Name = name;
        }

        public void Born()
        {
            Money = 0;
            Feeling = 20;
            Owngame[0]= {"nogame"};
        }

        public void Gamercheck()
        {
            Console.WriteLine("{0} your charater has be created", Name);
            Console.WriteLine("Now your feeling is {0}", Feeling);
            Console.WriteLine("Now your the game you own is {0}", Owngame[0]);
        }
    }
}
