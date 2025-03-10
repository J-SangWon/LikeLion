using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTextRPG
{
    class MainGame
    {
        Player player = new Player();
        Info monster = null;
        Field field = null;

        public void First_time_Setup()
        {
            player.SelectJob();

        }

        public void Progress()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();

                Console.WriteLine("1. 사냥 2. 종료");
                input = int.Parse(Console.ReadLine());

                if (input == 2) { break; }
                else if(input == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.SetPlayer(player);
                    }
                    field.GoField();
                }

            }
        }
    }

    

}
