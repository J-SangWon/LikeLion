using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//네임스페이스
//1.클래스의 이름이 중복되는 것을 방지
//2.클래스를 논리적으로 그룹화
//3.네임스페이스를 사용하면 클래스의 이름을 짧게 사용할 수 있음

//using System; //네임스페이스를 사용하겠다는 선언

namespace dev1{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("dev1 Hello");
        }
    }
}


namespace LikeLion12
{
    class Program
    {
        ////전역변수
        //static int num2 = 20;


        ////1.매개변수도 반환값도 없는 함수
        //static void PrintHello()
        //{
        //    Console.WriteLine("안녕하세요");

        //}
        ////2.매개변수만 있는 함수
        //static void PrintMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}

        ////3.반환값만 있는 함수
        //static int GetNumber()
        //{

        //    return 42;
        //}

        ////4.매개변수와 반환값이 있는 함수
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}


        //6.함수 오버로딩(Overloading)

        /// <summary>
        /// 두수를 곱하는 함수
        /// </summary>
        /// <param name="a">int,double 오버로딩해놈</param>
        /// <param name="b">int,double 오버로딩해놈</param>
        /// <returns></returns>
        //static int Multiply(int a, int b)
        //{
        //    return a * b;
        //}

        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}

        ////5.기본값을 가진 매개변수 (디폴트 매개변수)
        //static void Greet(string name = "손님")
        //{
        //    Console.WriteLine($"안녕하세요, {name}");
        //}

        ////out 키워드
        //static void Divide(int a, int b, out int result, out int remainder)
        //{
        //    result = a / b;
        //    remainder = a % b;
        //}

        //params 키워드
        //static int Sum(params int[] values)
        //{
        //    int sum = 0;
        //    foreach (int value in values)
        //    {
        //        sum += value;
        //    }
        //    return sum;
        //}

        //재귀 함수
        static int Factorial(int n)
        {
            if (n == 0) 
            {
                return 1;   //출력겸 탈출
            }
            return n * Factorial(n - 1);    
        }

        public static void SayHello()
        {
            Console.WriteLine("dev2 Hello");
        }

        //C#화살표 함수
        //'=>' 람다 표현식이라고도 하며 간결한 방식으로 함수 정의 가능
        static int AddArrow(int a, int b) => a + b;
        


        static void Main(string[] args)
        {

            // PrintHello(); //출력
            // PrintMessage("반갑습니다.");
            //로컬변수
            //int num = GetNumber();
            //Console.WriteLine(num);

            //Console.WriteLine(Add(3, 5));


            //Greet();
            //Greet("철수");

            //Console.WriteLine(Multiply(3, 4));
            //Console.WriteLine(Multiply(2.5, 3.5));

            //Console.WriteLine(Sum(1, 2, 3));   //출력 6

            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //Console.WriteLine(Factorial(5));

            //SayHello();
            //dev1.MyClass.SayHello();

            Console.WriteLine(AddArrow(3, 5));

        }


    }
}
