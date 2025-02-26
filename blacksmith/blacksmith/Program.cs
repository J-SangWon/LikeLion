using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to the Blacksmith!");

            int playerGold = 100;
            int input = 0;
            int tree = 0;
            int rnd = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기 \t2.나무팔기 \t3. 도끼뽑기 \t4.나가기");
                Console.Write("선택 : ");
                input = int.Parse(Console.ReadLine());


                if (input == 1)
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("현재 나무 갯수 : " + tree);
                        Console.WriteLine("나무캐기 (press enter)\t뒤로가기 x");

                        string str = Console.ReadLine();
                        if (str == "x")
                        {
                            Console.WriteLine("이전으로 돌아갑니다");
                            break;
                        }
                        else
                        {
                            tree++;
                        }
                    }
                }
                else if (input == 2)
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("나무팔기");
                        Console.WriteLine("나무 개수 : " + tree);
                        Console.WriteLine("판매 금액 : 100골드");
                        Console.WriteLine("현재 골드 : " + playerGold);
                        Console.WriteLine("나무 판매 (press enter)\t뒤로가기 x");
                        string str = Console.ReadLine();
                        if (str == "x")
                        {
                            Console.WriteLine("이전으로 돌아갑니다");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("나무를 판매했습니다.");
                            tree--;
                            playerGold += 100;
                        }
                    }


                }
                else if (input == 3)
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("도끼뽑기 (press enter)\t뒤로가기 x");
                        string str = Console.ReadLine();
                        if (str == "x")
                        {
                            Console.WriteLine("이전으로 돌아갑니다");
                            break;
                        }
                        else
                        {
                            if (playerGold < 100)
                            {
                                Console.WriteLine("골드가 부족합니다.");
                                break;
                            }

                            rnd = rand.Next(1, 101);
                            if (rnd <= 10)
                            {
                                Console.WriteLine("도끼를 획득했습니다.");
                                playerGold -= 100;
                            }
                            else
                            {
                                Console.WriteLine("도끼를 획득하지 못했습니다.");
                            }
                        }
                    }
                }
                else if (input == 4)
                {
                    Console.WriteLine("종료합니다.");
                    Thread.Sleep(500);
                    Environment.Exit(0);
                }






            }
        }
    }
}