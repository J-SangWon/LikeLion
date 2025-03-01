using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion14
{
    class Program
    {
        //클래스
        //class Person
        //{
        //    public string Name;
        //    public int Age;

        //    //기본 생성자
        //    //클래스가 객체로 생성될 떄 자동으로 실행되는 특별한 메서드
        //    //클래스와 같은 이름, 반환명이 없음(void도 없음)
        //    //객체를 만들떄 필요한 초기값 설정할때 사용
        //    //public Person() {
        //    //    Name = "이름 없음";
        //    //    Age = 1;
        //    //    Console.WriteLine("기본 생성자 실행");
        //    //}

        //    //매개변수를 받는 생성자
        //    public Person() { }
        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }

        //    public void ShowInfo()
        //    {
        //        Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        //    }
        //}

        //문제 1
        //마린 클래스
        class Marine
        {
            public string Name;
            public int Mineral;

            public Marine()
            {
                Name = "Marine";
                Mineral = 50;
            }

            public Marine(string name, int mineral)
            {
                Name = name;
                Mineral = mineral;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"{Name} : {Mineral}");
            }
        }
        //SCV 클래스
        class SCV 
        {
            public string Name;
            public int Mineral;

            public SCV()
            {
                Name = "SCV";
                Mineral = 50;
            }
            public SCV(string name, int mineral)
            {
                Name = name;
                Mineral = mineral;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"{Name} : {Mineral}");
            }

        }
        //Barrack 클래스
        //this 키워드
        //this는 자기 자신을 가르킨다
        class Barrack 
        {
            public string Name;
            public int Mineral;

            public Barrack()
            {
                Name = "Barrack";
                Mineral = 150;

            }
            public Barrack(string Name, int Mineral)
            {
                this.Name = Name;
                this.Mineral = Mineral;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"{Name} : {Mineral}");
            }

        }
        //Mineral 클래스
        class Mineral
        {
            public string Name;
            public int mineral;
            public int mineralCount;

            public Mineral()
            {
                Name = "Mineral";
                mineral = 1500;
                ++mineralCount;
            }
            public Mineral(string name, int mineral, int mineralCount)
            {
                this.Name = name;
                this.mineral = mineral;
                this.mineralCount = mineralCount;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"{Name} : {mineral} : {mineralCount}");
            } 

        }

        class Game
        {
            //static 키워드
            //하나를 공유해서 사용함
            public static int Mineral;
            public static int Gas;
            public static int PopCount;
            public static int MaxCount;

            public static void ShowInfo()
            {
                Console.WriteLine($"{Mineral} : {Gas} : {PopCount}/{MaxCount}");
            }

        }


        static void Main(string[] args)
        {

            //시간
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now); //현재 날짜 및 시간

            //TimeSpan duration = new TimeSpan(1, 30, 0);
            //Console.WriteLine(duration); //01 : 30 : 00

            //클래스, 메서드
            //Person p1 = new Person();
            //p1.Name = "사람1";
            //p1.ShowInfo();

            //Person p2 = new Person("영희", 30);
            //p2.ShowInfo();


            SCV scv = new SCV();
            Marine marine = new Marine();
            Barrack barrack = new Barrack();
            //Mineral mineral = new Mineral();
            //클래스 배열 생성
            Mineral[] mineral = new Mineral[7]; 
            //각 배열에 new 객체화
            for(int i = 0; i < 7; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }
            

            scv.ShowInfo();
            marine.ShowInfo();
            barrack.ShowInfo();
            
            Game.Mineral = 50;
            Game.Gas = 0;
            Game.PopCount = 4;
            Game.MaxCount = 10;
            Game.ShowInfo();



        }
    }
}
