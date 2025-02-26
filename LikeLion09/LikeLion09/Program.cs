using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion09
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 6;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;
            //}

            //Console.WriteLine("1. 검사 2. 마법사 3. 도적");
            //Console.Write("직업을 선택해주세요 : ");
            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1: Console.WriteLine("직업 | 검사\n공격력 | 100\n방어력 | 90");
            //        break;
            //    case 2: Console.WriteLine("직업 | 마법사\n공격력 | 110\n방어력 | 80");
            //        break;
            //    case 3: Console.WriteLine("직업 | 도적\n공격력 | 115\n방어력 | 70");
            //        break;
            //    default: Console.WriteLine("잘못된 선택입니다.");
            //        break;
            //}

            //for 문
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int sum = 0;
            //for(int i = 1; i<=10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //while 문
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //    if (count == 3)
            //    {
            //        Console.WriteLine("탈출");
            //        break;
            //    }
            //}

            //랜덤
            //Random rand = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int randNum = rand.Next(0, 10); // 0 ~ 9
            //    Console.WriteLine($"랜덤 수 : {randNum}");
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    double randNum = rand.NextDouble() * 10; // 0 ~ 9
            //    Console.WriteLine($"랜덤 실수 : {randNum}");
            //}

            //무기 강화

        //    Console.WriteLine("무기 강화 시스템");
        //    Console.WriteLine("SSS : 10% 확률");
        //    Console.WriteLine("SS : 40% 확률");
        //    Console.WriteLine("S : 50% 확률");
        //    Console.Write("무기 등급을 골르시오 : ");
        //    string grade = Console.ReadLine();
        //    int level = 0;
        //    Random rand = new Random();

        //    for (; ; )
        //    {
        //        string ans = "";
        //        switch (grade)
        //        {
        //            case "SSS":
        //                {
        //                    int randNum = rand.Next(0, 101);
        //                    level = UgradeTry(randNum, level);
        //                    ans = AnsReturn();
        //                    if (ans == "Y")
        //                    {
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            case "SS":
        //                {
        //                    int randNum = rand.Next(0, 101);
        //                    level = UgradeTry(randNum, level);
        //                    ans = AnsReturn();
        //                    if (ans == "Y")
        //                    {
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            case "S":
        //                {
        //                    int randNum = rand.Next(0, 101);
        //                    level = UgradeTry(randNum, level);
        //                    ans = AnsReturn();
        //                    if (ans == "Y")
        //                    {
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            default:
        //                Console.WriteLine("잘못된 등급입니다.");
        //                ans = AnsReturn();
        //                if (ans == "Y")
        //                {
        //                    break;
        //                }
        //                else
        //                {
        //                    continue;
        //                }

        //        }


        //    }
        //}

        //public static string AnsReturn()
        //{
        //    string ans;
        //    Console.Write("계속 강화 하시겠습니까? (Y or N) : ");
        //    ans = Console.ReadLine();
        //    return ans;
        //}

        //public static int UgradeTry(String grade,int randNum, int level) {
        //    if (randNum <= 10)
        //    {
        //        Console.WriteLine("대장장이가 성공적으로 강화하였습니다.");
        //        Console.WriteLine(++level);
        //        return level;
        //    }
        //    else
        //    {
        //        Console.WriteLine("대장장이가 강화에 실패하였습니다.");
        //        return level;
        //    }
        //}






    }
}

