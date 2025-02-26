using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion11
{
    class Program
    {
        //static void Loading()
        //{

        //    Console.WriteLine("로딩중.");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("로딩중..");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("로딩중...");
        //    Thread.Sleep(1000);
        //}
        ////입력
        //static void AttackFunction(int Attack)
        //{
        //    Console.WriteLine("공격력은 : " + Attack);
        //}

        ////출력
        //static int BaseAttak()
        //{
        //    int attack = 10;

        //    return attack;
        //}

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int maxNum(int[] ary)
        {
            int max = 0;
            foreach(int i in ary)
            {
                if (max < i) max = i;
            }
            return max;
        }

        static void Main(string[] args)
        {
            //int Attack = 0;
            //int bAttack = 0;

            //Console.Write("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본 공격력
            //bAttack = BaseAttak();

            //AttackFunction(bAttack + Attack);

            //int result = Add(10, 20);
            //Console.WriteLine(result);

            //배열 1번 문제
            //int[] ary1 = new int[5] { 10, 20, 30, 40, 50 };
            //foreach (int i in ary1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            ////배열 2번 문제
            //int sum = 0;

            //Console.Write("정수 5개를 입력하세요(공백으로 구분) : ");
            //string input1 = Console.ReadLine();
            //int[] numbers = input1.Split(' ').Select(int.Parse).ToArray();

            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("합계 : " + sum);
            //Console.WriteLine();

            ////배열 3번 문제
            //int max = 0;
            //int[] ary2 = new int[5] { 3, 8, 15, 6, 2 };
            //foreach (int i in ary2)
            //{
            //    Console.Write($"{i} ");
            //    if (max < i) max = i;
            //}
            //Console.WriteLine("최대값 : " + max);
            //Console.WriteLine();

            ////반복문 1번 문제
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            ////반복문 2번 문제
            //int num = 1;
            //while (true)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.Write($"{num} ");
            //    }
            //    num++;
            //    if (num == 11) break;
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //반복문 3번 문제
            //int[] ary3 = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (int i in ary3)
            //{
            //    Console.Write($"{i} ");
            //}

            //함수 1번 문제
            //Console.Write("정수 2개를 입력하세요(공백으로 구분) : ");
            //string input2 = Console.ReadLine();
            //int[] numbers2 = input2.Split(' ').Select(int.Parse).ToArray();
            //Console.WriteLine($"합 : {Add(numbers2[0], numbers2[1])}");

            //함수 2번 문제
            //Console.Write("문자열을 입력하세요 : ");
            //string input3 = Console.ReadLine();
            //Console.WriteLine($"문자열의 길이 : {input3.Length}");

            //함수 3번 문제
            Console.Write("정수 3개를 입력하세요(공백으로 구분) : ");
            string input4 = Console.ReadLine();
            int[] numbers3 = input4.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"최대값 : {maxNum(numbers3)}");

            }
    }
}
