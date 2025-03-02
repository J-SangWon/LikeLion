using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.CoreAudioApi;

//길 건너 친구들

//1.플레이어
//2.콘솔 중앙 도로 3개 (세로)
//3. 방향키 입력받아서 플레이어 이동
//4. 도로에는 네모 박스모양이 1번줄은 위로 2번줄은 아래로 3번줄은 위로 한 방향으로 이동함
//5. 도로 3줄을 다 지나가면 성공

namespace CrossyRoad
{
    class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); 

        Goal goal = new Goal();
        public int PlayerX;
        public int PlayerY;
        string player = "▲";
        Stopwatch stopwatch = new Stopwatch();

        public Player()
        {
            PlayerX = 1;
            PlayerY = 12;
            stopwatch.Start();
        }

        public void ClearTime()
        {
            TimeSpan ClearTime = stopwatch.Elapsed;
            string ClearTimeFormat = ClearTime.ToString(@"hh\:mm\:ss");
            Console.SetCursorPosition(goal.GoalX - 7, goal.GoalY + 1);
            Console.WriteLine($"클리어 성공");
            Console.SetCursorPosition(goal.GoalX - 7, goal.GoalY + 2);
            Console.Write(ClearTimeFormat);
            stopwatch.Stop(); 
        }

        public void GameMain()
        {
            ConsoleSize();
            KeyControl();
            DrawPlayer();
            goal.GoalDraw();

        }
        public static void ConsoleSize()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
        }
        public void DrawPlayer()
        {
            for(int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(PlayerX, PlayerY);
                Console.WriteLine(player);
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
                    case 72: PlayerY--; if (PlayerY < 1) PlayerY = 1; break; //위
                    case 75: PlayerX--; if (PlayerX < 1) PlayerX = 1; break; //왼
                    case 77: PlayerX++; if (PlayerX > 75) PlayerX = 75; break; //오
                    case 80: PlayerY++; if (PlayerY > 23) PlayerY = 23; break; //아래
                    // case 32: break; //스페이스
                }
            }
        }

        public void ClashSquare(Square square)
        {
            for(int i = 0; i < 8; i++)
            {
                if (square.SquareX + i == PlayerX)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(square.SquareY + i == PlayerY)
                        {
                            PlayerX = square.SquareX - 10;
                        }

                    }
                }
            }
            
        }

        public void Goal()
        {
            if(PlayerY == goal.GoalY && PlayerX == goal.GoalX)
            {
                ClearTime();
            }
        }



    }

    class Goal
    {
        public int GoalX;
        public int GoalY;
        string GoalShape;

        public Goal()
        {
            GoalX = 72;
            GoalY = 12;
            GoalShape = "★";
        }

        public void GoalDraw()
        {
            Console.SetCursorPosition(GoalX, GoalY);
            Console.WriteLine(GoalShape);
        }
    }

    class Square
    {
        public int SquareX, SquareY, Direction;
        public int Xrange, Yrange;
        public bool LShape;
        private int LDirection = 0; // 0: 오른쪽, 1: 아래, 2: 왼쪽
        private int InitialX, InitialY;

        string[] square = new string[]
        {
            "┏━━━━┓",
            "┃    ┃",
            "┗━━━━┛"
        };

        public Square()
        {
            SquareX = 30;
            SquareY = 20;
            Direction = 1;
            LShape = false;
        }
        public Square(int x, int y, int direction)
        {
            SquareX = x;
            SquareY = y;
            Direction = direction;
        }
        public Square(int x, int y, int direction, bool Lshape, int Xrange, int Yrange)
        {
            SquareX = x;
            SquareY = y;
            InitialX = x;
            InitialY = y;
            Direction = direction;
            LShape = Lshape;
            this.Xrange = Xrange;
            this.Yrange = Yrange;
            
        }

        public void DrawSquare()
        {
            Console.SetCursorPosition(SquareX, SquareY);
            for (int i = 0; i < square.Length; i++)
            {
                Console.SetCursorPosition(SquareX, SquareY + i);
                Console.WriteLine(square[i]);
            }

        }
        public void MoveSquare()
        {
            if (LShape)
            {
                switch (LDirection)
                {
                    case 0: // 오른쪽
                        SquareX++;
                        if (SquareX >= Xrange)
                        {
                            LDirection = 1;
                            SquareX = Xrange; // 정확한 위치 설정
                        }
                        break;
                    case 1: // 아래
                        SquareY++;
                        if (SquareY >= Yrange)
                        {
                            LDirection = 2;
                            SquareY = Yrange; // 정확한 위치 설정
                        }
                        break;
                    case 2: // 왼쪽
                        SquareX--;
                        if (SquareX <= InitialX)
                        {
                            LDirection = 3;
                            SquareX = InitialX; // 정확한 위치 설정
                        }
                        break;
                    case 3: // 위
                        SquareY--;
                        if (SquareY <= InitialY)
                        {
                            LDirection = 0;
                            SquareY = InitialY; // 정확한 위치 설정
                        }
                        break;
                }
                
                if (SquareX < 0 || SquareX > 75 || SquareY < 0 || SquareY > 20)
                {
                    SquareX = InitialX;
                    SquareY = InitialY;
                    LDirection = 0; // 방향 초기화
                }

            }
            else
            {
                SquareY += Direction;
                if (SquareY < 1 || SquareY > 21)
                {
                    SquareY = Direction == 1 ? 1 : 20;
                }
            }

                

        }


    }

    class Program
    {
        static async Task PlayBackgroundMusicAsync(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                audioFile.Volume = 0.2f;

                outputDevice.Init(audioFile);
                outputDevice.Play();

                // 루프 재생을 원할 경우
                outputDevice.PlaybackStopped += (sender, e) => outputDevice.Play();

                // 음악이 끝날 때까지 대기
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(1000);
                }
            }
        }
        static async Task Main(string[] args)
        {
            var audioTask = PlayBackgroundMusicAsync("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\CrossyRoad\\303PM_230312.wav");

            Player player = new Player();
            Square square = new Square();
            Square square2 = new Square(45, 1, -1);
            Square square3 = new Square(60, 1, 1, true, 73, 20);

            int dwTime = Environment.TickCount; // 1/1000초 계산값이 들어옴

            while (true)
            {
                if(dwTime + 50 < Environment.TickCount)
                {
                    //시간
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //사각형
                    square.DrawSquare();
                    square.MoveSquare();
                    square2.DrawSquare();
                    square2.MoveSquare();
                    square3.DrawSquare();
                    square3.MoveSquare();

                    //충돌
                    player.ClashSquare(square);
                    player.ClashSquare(square2);
                    player.ClashSquare(square3);

                    //클리어
                    player.Goal();
                } 

            }

            


        }
    }
}
