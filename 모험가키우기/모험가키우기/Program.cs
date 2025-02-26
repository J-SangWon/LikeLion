using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 모험가키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine("모험가 키우기 게임에 오신 것을 환영합니다!");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($" 현재 상태: 체력 {health}. 골드 : {gold}, 공격력 : {power}");
                Console.WriteLine("1.모험하기 \t2.장비 뽑기 (1000) \t3.휴식하기 (체력 +20) \t4.게임 종료");
                Console.Write("선택 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("모험을 떠납니다."); Thread.Sleep(200);
                    Console.WriteLine("모험을 떠납니다.."); Thread.Sleep(200);
                    Console.WriteLine("모험을 떠납니다..."); Thread.Sleep(200);

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"몬스터를 만났습니다! -{damage}의 데미지를 입었습니다.");
                        health -= damage;
                        Thread.Sleep(500);
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 1001);
                        Console.WriteLine($"보물상자를 찾았습니다! {reward}의 골드를 획득했습니다.");
                        gold += reward;
                        Thread.Sleep(500);
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($"회복의 성소를 발견했습니다. {heal}의 체력을 회복했습니다.");
                        health += heal;
                        Thread.Sleep(500);
                    }
                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("장비를 뽑습니다.");
                        Thread.Sleep(500);

                        int rnd = rand.Next(1, 100);
                        if (rnd == 1)
                        {
                            Console.WriteLine("태초 아이템을 획득했습니다. 공격력 +100");
                            power += 100;
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("에픽 아이템을 획득했습니다. 공격력 +60");
                            power += 60;
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("레전더리 아이템을 획득했습니다. 공격력 +40");
                            power += 40;
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 70)
                        {
                            Console.WriteLine("유니크 아이템을 획득했습니다. 공격력 +20");
                            power += 20;
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Console.WriteLine("레어 아이템을 획득했습니다. 공격력 +10");
                            power += 10;
                            Thread.Sleep(500);
                        }
                    }
                    else {
                        Console.WriteLine("골드가 부족합니다.");

                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다.");
                    health += 20;
                    Thread.Sleep(500);
                }
                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Thread.Sleep(500);
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다.");
                    Thread.Sleep(500);
                }

                if (health <= 0)
                {
                    Console.WriteLine("체력이 0이 되어 사망하였습니다.");
                    isAlive = false;
                    Thread.Sleep(500);
                }

            }

        }
    }
}
