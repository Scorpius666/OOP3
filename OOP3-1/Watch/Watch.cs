using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOP3_1
{
    abstract class Watch : IShowTime, IShowAD
    {
        public string Name;
        public string ADDescription;

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
        public void ShowAD()
        {
            Console.WriteLine(this.Name + "在做广告：" + this.ADDescription);
        }
    }
}
