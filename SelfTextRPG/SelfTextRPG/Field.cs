using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTextRPG
{
    class Field
    {
        Player player = null;
        Monster monster = new Monster();
        public void SetPlayer(Player player) { this.player = player; }
        public void ChooseMonster()
        {
            Console.WriteLine("=================");
            Console.WriteLine("1. 하급");
            Console.WriteLine("2. 중급");
            Console.WriteLine("3. 상급");
            Console.WriteLine("4. 돌아가기");
            Console.WriteLine("=================");
            Console.Write("입력 : ");
        }

        public void GoField()
        {
            int input = 0;
            while (true) 
            {
                Console.Clear();
                player.Render();
                ChooseMonster();
                input = int.Parse(Console.ReadLine());

                if (input == 4) break;
                else if(input <= 4)
                {
                    CreateMonster(input, out monster);
                    Fight();
                }
            }
        }

        public void CreateMonster(int input, out Monster monster)
        {
            monster = new Monster();
            switch (input)
            {
                case 1:
                    monster.IName = "저렙몹";
                    monster.IAttack = 2;
                    monster.IHp = 40;
                    break;
                case 2:
                    monster.IName = "중급몹";
                    monster.IAttack = 5;
                    monster.IHp = 100;
                    break;
                case 3:
                    monster.IName = "상급몹";
                    monster.IAttack = 10;
                    monster.IHp = 200;
                    break;

            }
        }

        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();
                Console.Write("1.공격 2.도망 : ");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    player.SetDamage(player.IAttack, monster);
                    monster.SetDamage(monster.IAttack, player);
                    if (player.IHp <= 0) { player.IHp = 150; break; }
                    if(monster.IHp <= 0) { break; }
                }
                else if (input == 2 || monster.IHp <= 0)
                {
                    monster = null;
                    break;
                }
            }





        }


    }


}
