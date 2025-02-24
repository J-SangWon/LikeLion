using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion08
{
    class Program
    {
        static void Main(string[] args)
        {
            //2진수 변환
            //Console.Write("2진수 입력 :");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"십진수 출력 : {decimalValue}");
            //Console.WriteLine($"이진수 출력 : {binaryOutput}");

            //var 변수 선언 - 추론형 변수
            //var name = "Alice";
            //var age = 25;
            //var isStudent = true;

            //Console.WriteLine($"이름 : {name} \n나이 : {age} \n학생 : {isStudent}");

            //default 키워드
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($" 정수 기본값 : {defaultInt}");
            //Console.WriteLine($" 문자열 기본값 : {defaultString}");
            //Console.WriteLine($" 논리값 기본값 : {defaultBool}");

            //연산자 
            //int a = 3, b = 5;
            //int sum = a + b;
            //bool isEqual = (a == b);

            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"곱 : {a*b}");
            //Console.WriteLine($"나누기 : {b / a}");
            //Console.WriteLine($"나머지 : {b % a}");
            //Console.WriteLine($"논리 연산 : {isEqual}");

            //bool isEquql = false;

            //int a = 5;
            //int b = 5;

            //if((a == b))
            //{
            //    isEquql = (a == b);
            //    Console.WriteLine(isEquql);
            //}

            //단항 연산자, 증감 연산자
            //int a = 5;
            //int b = 5;
            //bool flag = false;

            //Console.WriteLine($"a : {a}");
            //Console.WriteLine($"b : {b}");
            //Console.WriteLine($"-a : {-a}");
            //Console.WriteLine($"++a : {++a}");
            //Console.WriteLine($"b++ : {b++}");
            //Console.WriteLine(flag = !flag);

            //~ 비트 연산자
            //10 : 0000 1010
            //int a = 10;
            //int result = ~a;
            //Console.WriteLine(result);

            //변환 연산자
            //double pi = 3.14;
            //int integerPi = (int)pi; // 실수를 정수로 변환

            //Console.WriteLine($"pi 정수변환 : {pi}");

            //int kor = 90;
            //int eng = 75;
            //int math = 58;

            //int sum = kor + eng + math;
            //float avg = sum / 3.0f;

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {avg}");

            //문자열 연결 연산자
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine($"이름 : {firstName} {lastName}");

            //할당    연산자
            //int a = 5;
            //a += 5; // a = a + 5
            //Console.WriteLine(a);
            //a -= 5;
            //Console.WriteLine(a);
            //a *= 5;
            //Console.WriteLine(a);
            //a /= 5;
            //Console.WriteLine(a);


            //문제 1
            //int kor, eng, math;

            //Console.Write("국어 점수 입력 : ");
            //kor = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수 입력 : ");
            //eng = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수 입력 : ");
            //math = int.Parse(Console.ReadLine());

            //int sum = kor + eng + math;
            //float avg = sum / 3.0f;

            //Console.WriteLine($"총점 : {sum}");
            //Console.WriteLine($"평균 : {avg:F2}");


            ////문제 2
            //Console.Write("정수를 입력하세요 : ");
            //int num = int.Parse(Console.ReadLine());


            //Console.WriteLine($"입력한 값 : {num}\n비트 반전 : {~num}");

            //관계 연산자
            //int x = 10;
            //int y = 20;

            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  //true  

            //논리 연산자
            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            //Console.WriteLine(a || b);
            //Console.WriteLine(a ^ b);
            //Console.WriteLine(!a);

            //비트 연산자,시프트 연산자
            //int x = 5;
            //int y = 3;

            //Console.WriteLine(x & y);
            //Console.WriteLine(x | y);
            //Console.WriteLine(x ^ y);
            //Console.WriteLine(~x);
            //Console.WriteLine(x << 1);
            //Console.WriteLine(x >> 1);

            //삼항 연산자
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;

            //Console.WriteLine(max);

            //if문
            //int score = 85;

            //if(score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}

            ////if문 예제 실습
            ////1번 문제
            //Console.Write("소지금를 입력하세요 : ");
            //int money = int.Parse(Console.ReadLine());

            //int atkValue = 100;

            //if (0 < money && money <= 100)
            //{
            //    Console.WriteLine("무한의 대검");
            //    atkValue += 1;
            //}
            //else if (100 < money && money <= 200)
            //{
            //    Console.WriteLine("카타나");
            //    atkValue += 2;
            //}
            //else if (200 < money && money <= 300)
            //{
            //    Console.WriteLine("진은검");
            //    atkValue += 3;
            //}
            //else if (300 < money && money <= 400)
            //{
            //    Console.WriteLine("집판검");
            //    atkValue += 4;
            //}
            //else if (400 < money && money <= 500)
            //{
            //    Console.WriteLine("엑스칼리버");
            //    atkValue += 5;
            //}
            //else if (500 < money && money <= 600)
            //{
            //    Console.WriteLine("유령검");
            //    atkValue += 6;
            //}
            //else if (600 < money)
            //{
            //    Console.WriteLine("전설의 검");
            //    atkValue += 7;
            //}
            //else
            //{
            //    Console.WriteLine("구매 불가");
            //}

            ////2번 문제
            //Console.WriteLine($"캐릭터 이름 : 테스트캐릭터01 \n공격력 : {atkValue}");


            //회고 시간 문제 풀이
            ////1번
            //Console.Write("정수 3개를 입력하세요 (공백을 이용하여 구분) : ");
            //string[] input = Console.ReadLine().Split(' ');
            //int num1 = int.Parse(input[0]);
            //int num2 = int.Parse(input[1]);
            //int num3 = int.Parse(input[2]);
            //int max = default;

            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        max = num1;
            //    }
            //    else
            //    {
            //        max = num3;
            //    }
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        max = num2;
            //    }
            //    else
            //    {
            //        max = num3;
            //    }
            //}

            //Console.WriteLine($"가장 큰 수 : {max}");

            ////2번
            //Console.Write("점수를 입력하세요 : ");
            //int score = int.Parse(Console.ReadLine());

            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}

            //3번
            Console.Write("정수를 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요 : ");
            string oper = Console.ReadLine();
            Console.Write("정수를 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (oper == "+"){
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (oper == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (oper == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (oper == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("잘못된 연산자입니다.");
            }
        }
    }
}
