using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion07
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("■");
                }
                for (int k = 9 - i; k > 0; k--)
                {
                    Console.Write("□");
                }
                Thread.Sleep(100);
                Console.Clear();

            }
            Console.WriteLine("Loading Complete\n");
            Thread.Sleep(100);


            Console.WriteLine("주어진 상황에서 당신은 생존하셔야 합니다");
            Console.WriteLine("<생존하거나 죽거나>");
            Console.WriteLine("Enter 입력하시면 시작됩니다");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("당신은 조용한 숲속에서 눈을 뜹니다." +
                            "\n그런데 갑자기 눈앞에 곰이 나왔습니다." +
                            "\n당신이 살아남기 위한 선택은?" +
                            "\n[1]죽은 척하기\t[2]나무 위로 올라가기");
            String input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                Console.WriteLine("곰은 매우 허기진 상태였기 때문에 당신은 온전하지 못했습니다");
                System.Environment.Exit(0);
            }else if(input == "2")
            {
                Console.WriteLine("축하드립니다. 곰은 매우 허기진 상태였기 때문에 당신을 쫒아 나무위로 올라오지 못했습니다.");
            }

            Console.WriteLine("살아 남은 당신은 식량을 해결해야한다." +
                "\n 지금당장 눈에 보이는 것은 괴상하게 생긴 나무 열매와 밑에 있는 평범하게 생긴 버섯이 있다." +
                "\n 어떤걸 섭취 할 것인가?" +
                "\n[1]괴상하게 생긴 나무 열매\t[2]평범하게 생긴 버섯\t[3]그냥 굶어");
            input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                Console.WriteLine("생김새와 다르게 맛은 훌륭했고 몸에 문제도 발생하지 않았습니다. 생존?한 것 같습니다.");
                System.Environment.Exit(0);
            }else if (input == "2")
            {
                Console.WriteLine("축하드립니다. 버섯은 당신의 소화기관부터 고통을 주기 시작했고 그 고통속에서 몸부림치다 탈진하셨습니다.");
                System.Environment.Exit(0);
            }
            else if (input == "3")
            {
                Console.WriteLine("그냥 굶어 죽었습니다.");
                System.Environment.Exit(0);
            }

        }
    }
}
