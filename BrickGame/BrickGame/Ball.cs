using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Ball
    {
        BallData m_tBall = new BallData();

        //C# 공의 방향을 배열로 정의
        int[,] g_WallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1,  4},
            { -1, -1, -1, -1,  2,  1},
            { -1,  5,  4, -1, -1, -1},
            { -1, -1,  1,  0,  5, -1}
        };

        //움직이는 bar
        Bar m_pBar;
        public void SetBar(Bar bar) { m_pBar = bar; }

        //block

        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 1; i < 23; i++)
            {
                Program.gotoxy(0, i);
                Console.Write("┃                                                                             ┃");
            }
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public int Collision(int x, int y)
        {
            //벽충돌
            if (y == 0)
            {
                m_tBall.nDirect = g_WallCollision[0, m_tBall.nDirect];
                return 1; //공의 방향이 바뀌면 1 리턴
            }
            if (x == 1)
            {
                m_tBall.nDirect = g_WallCollision[1, m_tBall.nDirect];
                return 1;
            }
            if (x == 78)
            {
                m_tBall.nDirect = g_WallCollision[2, m_tBall.nDirect];
                return 1;
            }
            if (y == 23)
            {
                m_tBall.nDirect = g_WallCollision[3, m_tBall.nDirect];
                return 1;
            }
            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[2] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }
            return 0;

        }

        public BallData GetBall() { return m_tBall; }
        public void SetX(int x) { m_tBall.nX += x; }
        public void SetY(int y) { m_tBall.nY += y; }
        public void SetBall(BallData tBall) { m_tBall = tBall; }
        public void SetReady(int Ready) { m_tBall.nReady = Ready; }

        public void Initialize()
        {
            m_tBall.nReady = 0;
            m_tBall.nDirect = 1;
            m_tBall.nX = 30;
            m_tBall.nY = 10;

            Console.CursorVisible = false;
        }

        public void Progress()
        {
            if (m_tBall.nReady == 0) //0 움직임
            {
                //공의 방향에 따른 스위치 문
                switch (m_tBall.nDirect)
                {
                    case 0: //위
                        if (Collision(m_tBall.nX, m_tBall.nY - 1) == 0) m_tBall.nY--;
                        break;
                    case 1: //오른쪽 위
                        if (Collision(m_tBall.nX + 1, m_tBall.nY - 1) == 0) { m_tBall.nX++; m_tBall.nY--; }
                        break;
                    case 2: //오른쪽 아래
                        if (Collision(m_tBall.nX + 1, m_tBall.nY + 1) == 0) { m_tBall.nX++; m_tBall.nY++; }
                        break;
                    case 3: //아래
                        if (Collision(m_tBall.nX, m_tBall.nY + 1) == 0) m_tBall.nY++;
                        break;
                    case 4: //왼쪽 아래
                        if (Collision(m_tBall.nX - 1, m_tBall.nY + 1) == 0) { m_tBall.nX--; m_tBall.nY++; }
                        break;
                    case 5: //왼쪽 위
                        if (Collision(m_tBall.nX - 1, m_tBall.nY - 1) == 0) { m_tBall.nX--; m_tBall.nY--; }
                        break;


                }
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(m_tBall.nX, m_tBall.nY);
            Console.Write("●");
            
        }

        public void Release() { }



    }
}
