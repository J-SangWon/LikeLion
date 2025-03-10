using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Player
    {
        public INFO m_tInfo;

        //데미지
        public void SetDamage(int iAttack) { m_tInfo.iHP -= iAttack; }
        //플레이어 정보를 외부에서 볼 수 있는 함수
        public INFO GetInfo() { return m_tInfo; }
        //hp 설정
        public void SetHp(int iHP) { m_tInfo.iHP = iHP; }
        public void SelectJob()
        {
            m_tInfo = new INFO();
            Console.WriteLine("직업 선택 1.기사 2. 마법사 3.도적");
            int iInput = int.Parse(Console.ReadLine());


            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHP = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHP = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도적";
                    m_tInfo.iHP = 95;
                    m_tInfo.iAttack = 13;
                    break;
            }

        }

        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"직업 이름 : {m_tInfo.strName}");
            Console.WriteLine($"체력 : {m_tInfo.iHP}\t공격력 : {m_tInfo.iAttack}");
        }
        //생성 소멸
        public Player() { }
        ~Player() { }


    }
}
