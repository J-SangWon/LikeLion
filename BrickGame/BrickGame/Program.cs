using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();

        public static void gotoxy(int x , int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            GameManager GM = new GameManager();
            GM.Initialize();


            int Current = Environment.TickCount;
            while (true) 
            {
                if (Current + 50 < Environment.TickCount) 
                {
                    GM.Progress();
                    GM.Render();
                    Current = Environment.TickCount;
                }
            }
            
        }
    }
}
