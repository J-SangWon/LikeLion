using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion06
{
    class Program
    {
        static void Main(string[] args)
        {
            ////입력
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();
            //Console.Write("나이을 입력하세요 : ");
            //String input = Console.ReadLine();
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"안녕하세요. {userName}님 \n나이 : {age}");
            //Console.WriteLine("나이 : {0}",age);

            string[] strL = {
                "루인 스킬 피해",
                "카드 게이지 획득량",
                "각성기 피해",
                "최대 마나",
                "전투 중 마나 회복량",
                "비전투 중 마나 회복량",
                "이동 속도",
                "탈 것 속도",
                "운반 속도",
                "스킬 재사용 대기시간 감소"
            };
            //4.5% 3.2% 6.5% 2827 101 101 102.6% 100.0% 100.0% 3.3%

            //for (int i = 0; i < strL.Length; i++)
            //{
            //    Console.WriteLine($"{strL[i]}");

            //}
            //Console.Write("위 내용을 순서대로 입력하세요 : ");
            //string[] values = Console.ReadLine().Split(' ');
            //if (values.Length != strL.Length)
            //{
            //    Console.WriteLine("입력된 값의 개수가 항목 수와 일치하지 않습니다.");
            //    return;
            //}
            //Console.WriteLine();
            //for (int i = 0; i < strL.Length; i++)
            //{
            //    Console.WriteLine($"{strL[i]}: {values[i]}");
            //}

            string[] inputValues = new string[strL.Length];
            for (int i = 0; i < strL.Length; i++)
            {
                Console.Write($"{strL[i]}: ");
                inputValues[i] = Console.ReadLine();
            }
            for (int i = 0; i < strL.Length; i++)
            {
                Console.WriteLine($"{strL[i]}: {inputValues[i]}");
            
            }

        }

    }
 }

