using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;
        List<Block> m_Blocks = new List<Block>();

        public void Initialize()
        {
            if (m_pBall == null) 
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }
            if (m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();
            }
            m_pBall.SetBar(m_pBar);

            //Block
            Random rand = new Random();
            for(int i = 0; i < 20; i++)
            {
                int x = rand.Next(1, 77);
                int y = rand.Next(1, 22);
                m_Blocks.Add(new Block(x, y));
            }

        }
        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);

            // 공과 블록의 충돌 판정
            foreach (var block in m_Blocks)
            {
                if (block.IsVisible && m_pBall.GetBall().nX == block.x && m_pBall.GetBall().nY == block.y)
                {
                    block.IsVisible = false; // 블록을 보이지 않게 설정
                }
            }
        }

        public void Render()
        {
            m_pBall.Render();
            m_pBar.Render();
            // 블록 렌더링
            foreach (var block in m_Blocks)
            {
                block.Render();
            }
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
        }

    }
}
