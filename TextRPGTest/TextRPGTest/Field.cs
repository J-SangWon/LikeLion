using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGTest
{
    class Field
    {
        Player player = null;
        Monster monster = new Monster();

        public void SetPlayer(Player player) { this.player = player; }
        public void Render()
        {
            player.Render();
            monster.Render();
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
                else if (input < 4)
                {
                    CreateMonster(input, out monster);
                    Fight();
                }
            }


        }

        private void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();
                Console.WriteLine("==================================");
                Console.WriteLine("1.공격하기\t2.도망치기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 2) break;
                else if (input == 1)
                {
                    player.SetDamage(player.IAttack, monster);
                    monster.SetDamage(monster.IAttack, player);
                }
                if (player.IHp <= 0)
                {
                    if (player.IName == "기사") { player.IHp = 150; }
                    else if (player.IName == "마법사") { player.IHp = 100; }
                    else if (player.IName == "궁수") { player.IHp = 125; }
                    break;
                }
                if (monster.IHp <= 0)
                {
                    monster = null;
                    break;
                }
            }

        }

        private void CreateMonster(int input, out Monster monster)
        {
            monster = new Monster();
            if (input == 1)
            {
                monster.IName = "저렙 몬스터";
                monster.IAttack = 2;
                monster.IHp = 50;
            }
            else if (input == 2)
            {
                monster.IName = "중렙 몬스터";
                monster.IAttack = 4;
                monster.IHp = 75;
            }
            else if (input == 3)
            {
                monster.IName = "고렙 몬스터";
                monster.IAttack = 6;
                monster.IHp = 100;
            }

        }

        public void ChooseMonster()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("1. 저렙 몬스터");
            Console.WriteLine("2. 중렙 몬스터");
            Console.WriteLine("3. 고렙 몬스터");
            Console.WriteLine("4. 돌아가기");
            Console.WriteLine("==================================");
            Console.Write("입력 : ");
        }

    }





}
