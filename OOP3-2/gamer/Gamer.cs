using OOP3_2.gamer.@interface;
using OOP3_2.@interface;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace OOP3_2.gamer
{
    class Gamer : IFeelingcheck, IGamecheck, IPlay, IWork, IName, IBorn, IGamercheck, IChoice, IBuy
    {
        private string Name;
        private int Money;
        private int Feeling;
        private string Owngame;

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
            Owngame = "Game Null";
        }

        public void Gamercheck()
        {
            Console.WriteLine("{0} your charater has be created", Name);
            Console.WriteLine("Now your feeling is {0}", Feeling);
            Console.WriteLine("Now your the game you own is {0}", Owngame);
        }

        public void Choice()
        {
            {
                Console.WriteLine("What are you want to do: ");
                Console.WriteLine("[A]Check my status");
                Console.WriteLine("[B]To work");
                Console.WriteLine("[C]To play game");
                Console.WriteLine("[D]To buy game");
                Console.WriteLine("[E]Exit");
                var y = Console.ReadLine();
                char x = y[0];
                switch (x)
                {
                    case 'a':
                    case 'A': Gamercheck(); break;
                    case 'b':
                    case 'B': Work(); break;
                    case 'c':
                    case 'C': Play(); break;
                    case 'd':
                    case 'D': Buy();  break;
                    case 'e':
                    case 'E': System.Environment.Exit(0); break;
                }
            }
        }

        public void Buy()
        {
            Console.WriteLine("Which game you want buy");
            Console.WriteLine("[B]To work");
        }
    }
}
