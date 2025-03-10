using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion25
{
    //이벤트(Event)
    //이벤트는 델리게이트의 특수한 형태로, 객체 간의 통신을 위해 사용됩니다.
    //보통 클래스 내부에서 특정 조건이 발생할 때 외부에서 처리할 수 있도록 하는 기능입니다
    class Character
    {
        public string Name {  get; private set; }
        public int Health { get; private set; }

        //EventHanler는 C#에서 제공하는 기본 델리게이트 타입
        //직접 호출 할 수 없고 += 와 -= 연산자로만 접근가능
        public event EventHandler onDamaged;
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{amount} 데미지!");

            //이벤트 발생
            //? 연산자는 OnDamaged가 null이 아닐 떄만 Invoke 메서드 호출
            //EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자
            onDamaged?.Invoke(this, EventArgs.Empty);
        }

        
    class Program
    {
        delegate void MessageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드 형식과 타입이 일치해야함
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void DisplayMessageToUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
        }

        //이벤트 핸들러 메서드
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //Sender를 Character타입으로 형변환
            Character character = (Character)sender;
            Console.WriteLine(character.Name);
            Console.WriteLine(character.Health);
        }

        //Action
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static void ShowNotification()
        {
            Console.WriteLine("알림!");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            //델리게이트 - 메시지 출력을 위한 메서드 참조
            //string 매개변수를 받고 반환값이 없는 (void)메서드를 참조할 수 있는 타입
            //델리게이트  변수 선언 및 메서드 연결
            //여러개의 메서드 연결 가능, 등록된 모든 메서드가 순서대로 호출됨
            //MessageHandler messageHandler = DisplayMessage;
            //messageHandler += DisplayMessageToUpper;
            //messageHandler("Hello");

            //Character hero = new Character("용사", 100);
            //hero.onDamaged += Hero_OnDamaged;
            //hero.TakeDamage(20);
            //hero.onDamaged -= Hero_OnDamaged;
            //hero.TakeDamage(20);

            //Action은 매개변수가 없고 반환값이 없는 메서드를 참조
            //메서드 이름을 변수에 저장한다고 생각하면 쉬움
            Action sayHello = SayHello;
            sayHello();
            sayHello += ShowNotification;
            sayHello?.Invoke();
            
            Action<string> helloWorld = HelloWorld;
            helloWorld?.Invoke("Action!");

            Action noti = null;
            noti += () => Console.WriteLine("람다!");
            noti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number*number);
            Square(5);

        }
    }
}
