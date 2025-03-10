using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTextRPG
{
    class Info
    {
        public string IName;
        public int IAttack;
        public int IHp;

        public void SetDamage(int iAttack, Info target)
        {
            target.IHp -= iAttack;
        }

        public void Render()
        {
            Console.WriteLine("=================");
            Console.WriteLine($"직업 이름 : {IName}");
            Console.WriteLine($"체력 : {IHp}\t공격력 : {IAttack}");
        }



    }

    class Player : Info
    {
        public void SelectJob()
        {
            Console.WriteLine("1.성기사 2.마법사 3.탱커");
            Console.Write("직업 선택 : ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    IName = "성기사";
                    IAttack = 10;
                    IHp = 150;
                    break;
                case 2:
                    IName = "마법사";
                    IAttack = 15;
                    IHp = 100;
                    break;
                case 3:
                    IName = "탱커";
                    IAttack = 5;
                    IHp = 200;
                    break;
            }


        }
    }

    class Monster : Info
    {
        public void MonsterGrade()
        {

        }
    }


}
