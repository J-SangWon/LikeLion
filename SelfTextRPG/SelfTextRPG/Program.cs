using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();

            mainGame.First_time_Setup();
            mainGame.Progress();
        }

    }
}
