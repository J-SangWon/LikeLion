using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion23
{

    //C# 인터페이스(Interface)란?
    //인터페이스는 클래스나 구조체에서 구현해야하는 메서드, 속성 등을 정의하는 추상적인 개념입니다.
    //즉, 어떤 기능을 반드시 포함하도록 강제하는 역할을 합니다.

    //인터페이스의특징
    //interface 키워드를 사용해서 정의
    //추상 메서드만 포함(구현X)-> 인터페이스를 구현하는 클래스에서 반드시 구현해야함.
    //다중 상속 가능(C#에서는 클래스 다중상속이 불가능하지만, 인터페이스는 여러개 구현 가능)
    //객체를 생성할수없음(추상 클래스와 유사).

    //인터페이스를 활용하면 객체가 어떤 특정한 동작을 보장하면서도 다양한 형태로 사용

    //인터페이스
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("댕");
        }
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("냥");
        }
    }

    //Train(IAnimal animal) 메서드는 Dog, Cat 모두를 받을 수 있음 → 코드 재사용성 증가
    // 추가적인 IAnimal을 구현한 새로운 동물이 생기더라도 Train() 메서드는 변경할 필요 없음 → 유지보수 용이
    class AnimalTrainer
    {
        public void Train(IAnimal iAnimal)
        {
            Console.WriteLine("동물들이 소리를 냅니다");
            iAnimal.Speak();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalTrainer trainer = new AnimalTrainer();
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            //dog.Speak();
            //cat.Speak();
            trainer.Train(dog);
            trainer.Train(cat);


        }
    }
}
