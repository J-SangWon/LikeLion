using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello; //using 키워드를 이용하여 다른 네임스페이스를 이용가능

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("HELLO");

        }
    }
}

namespace LikeLion22
{
    class Program
    {
        class Person
        {
            public string Name;
            public int Age;
            public Person() //생성자
            {
                Name = "Unknown";
                Age = 0;
            }

            public Person(string name)
            {
                Name = name;
                Age = 0;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

        }
        //ref 포인터개념 참조
        //메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }
        //out - 반환이 여러개일 경우에 유용
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        //추상 클래스
        abstract class Animal 
        {
            //추상 메서드(구현X , 상속받은 클래스가 구현)
            public abstract void MakeSound();

            //일반 메서드
            public void Sleep()
            {
                Console.WriteLine("잠");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("wal wal");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("meow");
            }
        }

        //부모클래스의 생성자 호출
        class Parent
        {
            protected string name;
            //public Parent(string message)
            //{
            //    Console.WriteLine("부모생성자" + message); // 2실행
            //}
            public Parent(string name)
            {
                this.name = name;
            }
        }

        class Child : Parent
        {
            private int age;
            //public Child() : base("하하하하성공")  //부모생성자 호출  1
            //{
            //    Console.WriteLine("자식 생성자 호출"); //3
            //}
            public Child(string name, int age) : base(name)
            {
                this.age = age;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"이름 : {name}, 나이 {age}");
            }

        }

        static void Main(string[] args)
        {
            //Say say = new Say();
            //say.SayHello();

            //Person p = new Person(); //생성자 호출
            //Person p1 = new Person("Bob");//1개짜리 매개변수있는 생성자
            //Person p2 = new Person("카타리나", 20); //2개짜리 매개변수있는 생성자
            //Console.WriteLine(p.Name + "," + p.Age);
            //Console.WriteLine(p1.Name + "," + p1.Age);
            //Console.WriteLine(p2.Name + "," + p2.Age);

            //int a = 10;
            //int b = 20;
            //int x, y;

            //Increase(ref a);
            //Console.WriteLine("A의 값 : " + a);

            //OutFunc(a, b, out x, out y);
            //Console.WriteLine(x + ", " + y);

            //Animal dog = new Dog();
            //Cat cat = new Cat();
            //dog.MakeSound();
            //cat.MakeSound();

            //Child child = new Child("홍길동", 25); //0 객체 생성 시작
            //child.ShowInfo();


            //추상클래스 외부 파일꺼 사용
            GameCharacter warrior = new Warrior("전사");
            GameCharacter mage = new Mage("마법사");

            Console.WriteLine("시작");

            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);

            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("종료");
            Console.WriteLine($"전사 HP : {warrior.Health}");
            Console.WriteLine($"마법사 HP : {mage.Health}");

        }
    }
}


