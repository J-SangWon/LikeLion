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
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;

        public Player()
        {
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) //총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }


        public void GameMain()
        {
            KeyControl();
            playerDraw();

            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        public void KeyControl()
        {
            int pressKey;
            if (Console.KeyAvailable)
            {
                pressKey = _getch();
                switch (pressKey)
                {
                    case 72: //위쪽
                        playerY--;
                        if (playerY < 1) playerY = 1;
                        break;
                    case 75: //왼쪽
                        playerX--;
                        if (playerX < 0) playerX = 0;
                        break;
                    case 77: //오른쪽
                        playerX++;
                        if (playerX > 75) playerX = 75;
                        break;
                    case 80: //아래쪽
                        playerY++;
                        if (playerY > 21) playerY = 21;
                        break;
                    case 32:
                        for (int i = 0; i < 20; i++) //총알 발사
                        {
                            //미사일1이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //총 쏘기
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                //한발씩 
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++) //총알 발사
                        {
                            //미사일2이 false 발사가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //총 쏘기
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++) //총알 발사
                        {
                            //미사일3이 false 발사가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //총 쏘기
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 
                                break;
                            }
                        }

                        break;

                }
            }
        }
        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //좌표 설정
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.WriteLine(bullet);
                    playerBullet[i].x++; //미사일 오른쪽으로 이동

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;

                    }
                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //좌표 설정
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    Console.WriteLine(bullet);
                    playerBullet2[i].x++; //미사일 오른쪽으로 이동

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;

                    }
                }
            }
        }
        public void BulletDraw3()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //좌표 설정
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    Console.WriteLine(bullet);
                    playerBullet3[i].x++; //미사일 오른쪽으로 이동

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;

                    }
                }
            }
        }

        public void playerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 1
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) && playerBullet[i].x <= (enemy.enemyX + 1))
                        {

                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; // 미사일 준비 상태로 만들기

                            Score += 100;
                        }
                    }
                }
            }
            //미사일 2
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1) && playerBullet2[i].x <= (enemy.enemyX + 1))
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; // 미사일 준비 상태로 만들기

                            Score += 100;
                        }
                    }
                }
            }
            //미사일 3
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1) && playerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false; // 미사일 준비 상태로 만들기

                            Score += 100;
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3) itemCount++;
                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;


                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
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
        public void EnemyDarw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }
        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--; //왼쪽으로 움직임
            if (enemyX < 2) //왼쪽으로 넘어가면 다시 등장
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22);
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item";
            Console.Write(ItemSprite);

        }

        public void ItemMove()
        {
            //if(itemX <= 1 || itemY <\1){
            //    ItemLife = false;
            //}
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //플레이어 생성
            Player player = new Player();

            //적 생성
            Enemy enemy = new Enemy();

            //유니티처럼 프레임속도
            int dwTime = Environment.TickCount; // 1/1000초 계산값이 들어옴

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간을 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어 
                    player.GameMain();

                    //총알
                    player.BulletDraw();

                    //총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    //적
                    enemy.EnemyMove();
                    enemy.EnemyDarw();

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }



        }


    }
}


