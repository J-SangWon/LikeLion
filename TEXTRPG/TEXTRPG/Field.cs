using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Field
    {
        //player
        Player m_pPlayer = null;
        //monster
        Monster m_pMonster = new Monster();
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }
        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) break;
                else if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }

            }


        }

        public void Create(string _strName, int _iHP, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster(); //몬스터 생성
            INFO tMonster = new INFO(); //몬스터 메모리 주기 객체 생성

            tMonster.strName = _strName;
            tMonster.iHP = _iHP;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);
        }
        public void CreateMonster(int input)
        {
            switch (input) 
            {   
                case 1:
                    Create("저렙몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중렙몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("고렙몹", 90, 9, out m_pMonster);
                    break;
            }

        }
        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.Write("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);
                    if(m_pPlayer.GetInfo().iHP <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }

                }
                if (iInput == 2 || m_pMonster.GetMonster().iHP <= 0)
                {
                    m_pMonster = null;
                    break; //탈출
                }

            }

        }

        public static void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

    }
}
