using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion13
{
    class Program
    {
        //열거형
        //Enumeration - enum
        //열거형은 서로 관련된 상수들의 집합을 정의할 때 사용
        //열거형은 정수형 데이터를 저장하며, 열거형의 각 상수는 0부터 시작하는 정수값을 가진다.
        //열거형은 기본적으로 int형으로 선언되지만, 다른 정수형으로 선언할 수도 있다.
        //열거형은 상수의 이름을 사용하여 상수의 값을 지정할 수 있다.

        enum DayOfWeek
        {
            Sunday, //0
            Monday, //1
            Tuesday, //2
            Wednesday, //3
            Thursday, //4
            Friday, //5
            Saturday //6
        }

        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }

        enum Weapontype
        {
            Sword,
            Bow,
            staff
            
        }

        static void ChooseWeapon(Weapontype weapon)
        {
            //switch(weapon)
            //{
            //    case Weapontype.Sword:
            //        Console.WriteLine("검을 선택했습니다.");
            //        break;
            //    case Weapontype.Bow:
            //        Console.WriteLine("활을 선택했습니다.");
            //        break;
            //    case Weapontype.staff:
            //        Console.WriteLine("지팡이를 선택했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("무기를 선택하지 않았습니다.");
            //        break;
            //}
            switch ((int)weapon)
            {
                case 0:
                    Console.WriteLine("검을 선택했습니다.");
                    break;
                case 1:
                    Console.WriteLine("활을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("지팡이를 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("무기를 선택하지 않았습니다.");
                    break;
            }
        }

        //구조체
        //Structure - struct
        //구조체는 클래스와 유사한 데이터 구조를 정의할 때 사용
        //구조체는 클래스와 달리 상속이나 인터페이스를 구현할 수 없다.
        public struct Point
        {
            public int X;
            public int Y;

            public void Print()
            {
               Console.WriteLine($"X : {X}, Y : {Y}");
            }
        }

        public struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        public struct Students
        {
            public string Name;
            public int kor;
            public int eng;
            public int math;
        }


        static void Main(string[] args)
        {
            //Math 클래스
            //Math 클래스는 수학적인 연산을 수행하는 메서드를 제공하는 클래스
            //Math 클래스의 메서드는 모두 정적 메서드이므로 Math 클래스의 인스턴스를 생성하지 않고도 사용할 수 있다.
            //Console.WriteLine($"PI : {Math.PI}"); //원주율
            //Console.WriteLine($"Abs(-123) : {Math.Abs(-123)}"); //절대값
            //Console.WriteLine($"Ceiling(123.45) : {Math.Ceiling(123.45)}"); //소수점 이하를 올림
            //Console.WriteLine($"Floor(123.45) : {Math.Floor(123.45)}"); //소수점 이하를 버림
            //Console.WriteLine($"Max(123, 456) : {Math.Max(123, 456)}"); //최대값
            //Console.WriteLine($"Min(123, 456) : {Math.Min(123, 456)}"); //최소값
            //Console.WriteLine($"Pow(2, 10) : {Math.Pow(2, 10)}"); //2의 10승
            //Console.WriteLine($"Round(123.45) : {Math.Round(123.45)}"); //반올림
            //Console.WriteLine($"Sqrt(123.45) : {Math.Sqrt(123.45)}"); //제곱근
            //Console.WriteLine($"Truncate(123.45) : {Math.Truncate(123.45)}"); //소수점 이하를 버림

            //DayOfWeek day = DayOfWeek.Wednesday;
            //Console.WriteLine(day); //Wednesday
            //Console.WriteLine((int)day); //3

            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status); //NotFound
            //Console.WriteLine((int)status); //404

            //문제
            //열거형과 함수를 이용하여 풀기
            //Weapontype.Sword 경우 검을 선택했습니다.
            //Weapontype.Bow 경우 활을 선택했습니다.
            //Weapontype.Staff 경우 지팡이를 선택했습니다.

            //ChooseWeapon(Weapontype.Bow);

            //Point p = new Point();
            //p.X = 10;
            //p.Y = 20;
            //p.Print();

            //var rect = new Rectangle { Width = 10, Height = 20 };
            //Console.WriteLine($"Area : {rect.GetArea()}");

            //Point[] points = new Point[2];
            //points[0].X = 10;
            //points[0].Y = 10;
            //points[1].X = 20;
            //points[1].Y = 20;

            //points[0].Print();
            //points[1].Print();

            //구조체 이용해서 학생 3명의 성적을 받고 출력하기
            //학생의 이름
            //받을 과목 점수 : 국어, 영어, 수학
            //출력 형식 : 이름, 국어, 영어, 수학

            Students[] student = new Students[3];

            student[0] = new Students { Name = "홍길동", kor = 100, eng = 80, math = 70 };
            student[1] = new Students { Name = "홍길란", kor = 90, eng = 10, math = 20 };
            student[2] = new Students { Name = "홍길순", kor = 20, eng = 55, math = 70 };

            foreach(var s in student)
            {
                Console.WriteLine($"{s.Name} {s.kor} {s.eng} {s.math}");
            }

        }
    }
}
