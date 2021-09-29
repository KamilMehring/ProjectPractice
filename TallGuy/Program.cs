using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallGuy
{
    class Program
    {
        static void Main(string[] args)
        {

            TallGuy tallGuy = new TallGuy() { Height = 174, Name = "Adam" };
            tallGuy.TalkAboutYourself();
            ScaryScary fingersTheClown = new ScaryScary("duze buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }
    }
}
