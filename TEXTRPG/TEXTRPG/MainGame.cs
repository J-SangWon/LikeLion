using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class MainGame
    {
        public Player m_pPlayer = null;
        //필드객체
        public Field m_pField = null;
        //초기화 해주는 함수
        public void initiallize()
        {
            //플레이어 생성 및 직업 선택 1회
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
        }

        //게임 전체 진행
        public void Progress()
        {
            int iInput = 0;
            while(true)
            {
                Console.Clear();
                m_pPlayer.Render();
                Console.WriteLine("1.사냥터 2.종료");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2) break;
                else if(iInput == 1)
                {
                    //사냥터
                    if(m_pField == null)
                    {
                        m_pField = new Field();
                        m_pField.SetPlayer(ref m_pPlayer);
                    }
                    m_pField.Progress();

                }
            }
        }
        public MainGame() { }
        ~MainGame() { }




    }
}
