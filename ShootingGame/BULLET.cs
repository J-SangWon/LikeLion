using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame_2
{
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;
        public int playerY;
        public BULLET[] playerBullet = new BULLET[20];

        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET(); // 인스턴스 생성
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }
        }

        public void GameMain()
        {
            KeyControl();
            BulletDraw();
            playerDraw();
        }

        public void KeyControl()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (playerX > 0) playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (playerX < Console.WindowWidth - 1) playerX++;
                        break;
                    case ConsoleKey.Spacebar:
                        FireBullet();
                        break;
                }
            }
        }

        public void FireBullet()
        {
            for (int i = 0; i < playerBullet.Length; i++)
            {
                if (!playerBullet[i].fire)
                {
                    playerBullet[i].x = playerX;
                    playerBullet[i].y = playerY - 1;
                    playerBullet[i].fire = true;
                    break;
                }
            }
        }

        // 미사일 그리기
        public void BulletDraw()
        {
            for (int i = 0; i < playerBullet.Length; i++)
            {
                if (playerBullet[i].fire)
                {
                    Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                    Console.Write("|");
                    playerBullet[i].y--;

                    if (playerBullet[i].y < 0)
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }

        public void playerDraw()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("^");
        }

        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < playerBullet.Length; i++)
            {
                if (playerBullet[i].fire && playerBullet[i].x == enemy.enemyX && playerBullet[i].y == enemy.enemyY)
                {
                    playerBullet[i].fire = false;
                    enemy.enemyX = -1; // 적을 화면 밖으로 이동
                    enemy.enemyY = -1;
                }
            }
        }
    }

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            if (enemyX >= 0 && enemyY >= 0)
            {
                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write("E");
            }
        }

        public void EnemyMove()
        {
            enemyX--;
            if (enemyX < 0)
            {
                enemyX = Console.WindowWidth - 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 플레이어 생성
            Player player = new Player();

            // 적 생성
            Enemy enemy = new Enemy();

            // 유니티처럼 프레임속도
            int dwTime = Environment.TickCount; // 1/1000초 계산값이 들어옴

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    // 현재시간을 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    // 플레이어
                    player.GameMain();

                    // 적
                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    // 충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
