using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    class Monster
    {
        public INFO m_tMonster;
        
        public void SetDamage(int Attack) { m_tMonster.iHP -= Attack; }
        //INFO 클래스 타입 인자로 몬스터 데이터 입력
        public void SetMonster(INFO tMonster) { m_tMonster = tMonster;}
        public INFO GetMonster() { return m_tMonster;}
        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine($"직업 이름 : {m_tMonster.strName}");
            Console.WriteLine($"체력 : {m_tMonster.iHP}\t공격력 : {m_tMonster.iAttack}");
        }

        public Monster() { }
        ~Monster() { }
    }
}
