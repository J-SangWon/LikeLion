using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame
{
    struct Player
    {
        public int playerX;
        public int playerY;
        public string[] player;
        public Player(int x, int y)
        {
            playerX = x; // X 좌표 설정
            playerY = y; // Y 좌표 설정
            player = new string[] // 플레이어의 모양 설정
            {
            "->",
            ">>>",
            "->",
            };
        }

        public void PlayerPrint()
        {
            for (int i = 0; i < player.Length; i++)
            {
                //좌표 설정
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

    }


    class Program
    {
        static void KeyPress(ref Player player)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (player.playerY > 0) player.playerY--; break;
                    case ConsoleKey.DownArrow: if (player.playerY < Console.WindowHeight - 3) player.playerY++; break;
                    case ConsoleKey.LeftArrow: if (player.playerX > 0) player.playerX--; break;
                    case ConsoleKey.RightArrow: if (player.playerX < Console.WindowWidth - 3) player.playerX++; break;
                    case ConsoleKey.Spacebar: Console.SetCursorPosition(player.playerX + 3, player.playerY + 1); Console.Write("===>>>"); break;
                    case ConsoleKey.Escape: Environment.Exit(0); break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000초 단위

            Player player = new Player(0, 10);

            Console.CursorVisible = false;

            while (true)
            {

                player.PlayerPrint();
                KeyPress(ref player);

                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간

                if (currentSecond - prevSecond >= 10)
                {
                    Console.Clear();

                    prevSecond = currentSecond;//이전 시간 업데이트
                }

            }

        }


    }
}
