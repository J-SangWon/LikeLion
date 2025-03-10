using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    class Info
    {
        public string IName;
        public int IHp;
        public int IAttack;

        public void Render()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"직업 : {IName}");
            Console.WriteLine($"체력 : {IHp}\t공격력 : {IAttack}" );
        }

        public void SetDamage(int damage, Info target)
        {
            target.IHp -= damage;
        }

    }

    class Player : Info
    {
        int input = 0;
        public void SelectJop()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("1.기사 2.마법사 3.궁수");
            Console.WriteLine("==================================");
            Console.Write("직업을 선택하세요 : ");
            input = int.Parse( Console.ReadLine() );
            switch (input) 
            {
                case 1: IName = "기사"; IAttack = 5; IHp = 150; break;
                case 2: IName = "마법사"; IAttack = 9; IHp = 100; break;
                case 3: IName = "궁수"; IAttack = 7; IHp = 125; break;
            }
        }
    }
    class Monster : Info
    {

    }

}
