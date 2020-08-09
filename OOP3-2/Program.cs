using OOP3_2.gamer;
using System;

namespace OOP3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Hello\nWellcome to play this game The Gamer");
            Console.WriteLine("Name pless name your charater: ");
            name =  Console.ReadLine();
            Gamer gamer1 = new Gamer();
            gamer1.Born();
            gamer1.Nameing(name);
            gamer1.Gamercheck();
        }
    }
}
