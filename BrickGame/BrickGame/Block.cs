using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Block
    {
        public int x {  get; set; }
        public int y { get; set; }
        public bool IsVisible { get; set; }

        public Block(int x, int y)
        {
            this.x = x;
            this.y = y;
            IsVisible = true;
        }

        public void Render()
        {
            if (IsVisible)
            {
                Program.gotoxy(x, y);
                Console.Write("■");
            }
        }

    }
}
