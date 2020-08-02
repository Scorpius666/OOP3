using System;
using System.Collections.Generic;

namespace OOP3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            var a = 10;
            var xiaomingCasio = new CASIO();
            var xiaohongCitzen = new CITZEN();
            xiaohongCitzen.Name = "xiaohiong's Citzen";

            var xiaobaiIWC = new IWC();
            xiaobaiIWC.Name = "xiaobai's IWC";

            var xiaolanOmege = new OMEAG();
            xiaolanOmege.Name = "xiaolan's Omege";

            //Tell story
            var watches = new List<Watch>
            {
                new CASIO() { Name = "xiaoming's Casio" },
                new CITZEN() { Name = "xiaoming's Casio" },
                new CASIO() { Name = "xiaoming's Casio" }
            };// 范型约束

        }
    }
}
