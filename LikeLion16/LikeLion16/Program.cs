using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion16
{

    //Generics - 특정 타입에 종속되지 않는 범용 클래스를 만들수 있음.
    class Cup<T> 
    {
        public T Content { get; set; }
    }
    class SimpleCollection : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


    //클래스시그니처 기본구성
    //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

    //[접근 지정자] [수정자] class 클래스이름  : 부모클래스 , 인터페이스
    //public       abstract                  : BaseClass  ,IComparable
    //private      sealed
    //protected    static
    //             partial

    //기본클래스
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    //상속하는 클래스
    public class Warrior : Player
    {
        public int Strength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    //public class Enemy: IAttackable, IMovable
    //{
    //    public void Attack() { }
    //    public void Move() { }

    //}

    //추상 클래스 (abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램 종료");
            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0);

            //int randomNumber = random.Next(1, 101); // 1부터 100까지
            //Console.WriteLine("랜덤 숫자 : " + randomNumber);

            //Stopwatch stopwatch = Stopwatch.StartNew();

            // Random random = new Random();


            ////실행코드
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1);
            //}
            ////0.001

            //stopwatch.Stop();

            //Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");

            //문자열 형식 확인 및 비교
            //string input = "Hello, my phone number is 010-1234-5678.";
            //string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴

            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

            //int valueType = 10;
            //object referenceType = valueType;

            //valueType = 20;

            //Console.WriteLine($"ValueType : {valueType}"); //20
            //Console.WriteLine($"ReferenceType: {referenceType}");

            ////박싱 언박싱
            ////값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)

            //int value = 42;
            //object boxed = value; //박싱
            //int unboxed = (int)boxed; //언방식

            //Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");

            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할수 있다.

            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); //false

            //as  연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다.

            //object obj = "Hello";

            //string str = obj as string;

            //Console.WriteLine(str is string);

            //object obj = 42;


            //if (obj is int number)
            //{
            //    Console.WriteLine($"Number : {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}

            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); //Hello,Alice

            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열

            //string 다양한 메서드
            //string text = "C# is awesome";

            //Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //예외 처리하기
            //모든예외의 기본 클래스입니다.
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[6]);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("항상실행");
            //}

            //throw 로 예외 발생시키기
            //try
            //{
            //    int age = -5;
            //    if (age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}


            //배열과 컬렉션
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////배열과 비슷하지만  동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> list = new List<string> { };
            //list.Add("a");
            //list.Add("c");
            //list.Add("b");
            //list.ForEach(x => Console.WriteLine(x));

            //list.Sort();
            //list.ForEach(x => Console.WriteLine(x));

            //Console.WriteLine(list.Count());
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");


            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Stack
            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Console.WriteLine(queue.Count);

            //ArrayList - 크기가 동적으로 변하는 배열
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);

            //foreach(var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.Remove("Hello");
            //Console.WriteLine();
            //foreach(var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Hashtable 클래스 키-값 쌍을 저장하는 컬렉션
            //Hashtable hashtable = new Hashtable();
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;

            //hashtable.Remove("Bob");

            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            //}

            //Console.WriteLine(hashtable["Alice"]);

            //Cup<string> CupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> CupOfInt = new Cup<int> { Content = 1 };

            //Console.WriteLine(CupOfString.Content);
            //Console.WriteLine(CupOfInt.Content);

            //IEnumerator - C#컬렉션 순회 반복할 수 있는 인터페이스
            //IEnumerator를 사용하는 이유
            //✔ 컬렉션을 직접 제어하며 순회할 수 있음
            //✔ foreach 없이도 컬렉션 순회 가능
            //✔ LINQ나 커스텀 컬렉션을 만들 때 유용함

            //ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
            //IEnumerator enumerator = list.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //var collection = new SimpleCollection();

            //foreach (var i in collection)
            //{
            //    Console.WriteLine(i);
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach (var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

            //NULL 값 확인
            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //string str = null;
            //if (str == null)
            //{
            //    Console.WriteLine("DefaultValue");
            //}
            //Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value

            //LINQ는 확장메서드 형태로 제공된다. 
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };
            var enenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var n in enenNumbers) 
            { 
                Console.WriteLine(n);
            }


        }

    }
}
