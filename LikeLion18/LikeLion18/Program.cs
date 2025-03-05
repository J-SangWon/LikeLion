using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion18
{
    //부모 클래스(상속1, 3, 4)
    class Animal 
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}를 먹기");
        }
        public virtual void Speak()
        {
            Console.WriteLine("소리");
        }
    }

    //자식 클래스
    class Dog : Animal
    {
        public int Id { get; set; }
        public void Bark()
        {
            Console.WriteLine($"{Name}이 깨물기");
        }
        public override void Speak() //override
        {
            Console.WriteLine("오버라이드 소리");
        }
    }

    //상속2
    class Player
    {
        public string Name { get; set; }
        public void Render()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizard : Player
    {
        public string job = "Wizard";
        public void Render2()
        {
            Console.WriteLine($"직업은 {job}입니다");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedName = names.OrderBy(x => x);

            //foreach(var name in sortedName)
            //{
            //    Console.WriteLine(name);
            //}

            //var firstName = names.First(n => n.StartsWith("A"));
            //Console.WriteLine(firstName);

            //int[] nums = { 5, 3, 8, 1 };

            //var sortedMeshod = nums.OrderByDescending(x => x);
            //var sortedQuery = from n in nums
            //                   orderby n
            //                   select n; ;

            //foreach (var n in sortedMeshod)
            //{
            //    Console.WriteLine(n);
            //}

            //foreach (var n in sortedQuery)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] words = { "apple", "banana", "cherry" };

            //Select()로 길이 추출
            //var lengths = words.Select(w => w.Length);
            //foreach (var word in lengths) 
            //{
            //    Console.WriteLine(word);
            //}

            //Select 개념
            //Linq 쿼리 연산자중 하나
            //각 요소를 변환하여 새로운 컬렉션 생성
            //var upperWords = words.Select(w => w.ToUpper());
            //foreach (var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}


            int[] data = { 1, 2, 3, 4, 5 };
            //Sum() 알고리즘
            //int sum = 0;
            //sum = data.Sum();
            //Console.WriteLine(sum);

            //average
            //double avg = data.Average();
            //Console.WriteLine(avg);

            //MAX
            //int[] data2 = { 55, 76, 65 };
            //int max = data.Max();
            //Console.WriteLine($"Max :  {max}");

            //MIN
            //int[] data3 = { 55, 76, 45 };
            //int min = data.Min();
            //Console.WriteLine($"Min : {min}");

            //NEAR 근삿값
            //int[] data4 = { 10, 12, 20, 25, 30 };
            //int target = 22;
            //int nearest = data4[0];
            //foreach(var d in data4)
            //{
            //    if (Math.Abs(d - nearest) < Math.Abs(nearest - target)) nearest = d;
            //}
            //Console.WriteLine(nearest);

            //Rank
            //int[] Scores = { 90, 70, 50, 70, 60 };
            //for (int i = 0; i < Scores.Length; i++) {
            //    int rank = 1;
            //    for (int j = 0; j < Scores.Length; j++) {
            //        if (Scores[j] > Scores[i]) { 
            //            rank++;
            //        }
            //    }
            //    Console.WriteLine($"{Scores[i]} : {rank}");
            //}

            //Array.Sort
            //int[] data5 = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);
            //foreach (var d in data)
            //    Console.WriteLine(d);

            //특정값 검색
            //int[] data6 = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;
            //for (int i = 0; i < data6.Length; i++)
            //{
            //    if (data6[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index);

            //그룹화하기 : GROUP
            //데이터를 특정 기준으로 그룹화하기
            //string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            //// LINQ의 GroupBy()를 사용하여 첫 글자를 기준으로 그룹화
            //var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화
            //                                        // 각 그룹을 순회하며 출력
            //foreach (var group in groups)
            //{
            //    // 그룹의 Key (첫 글자) 출력
            //    Console.WriteLine($"Key : {group.Key}");
            //    // 해당 그룹에 속한 모든 요소 출력
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($" {item}");
            //    }
            //}

            //상속
            //Dog dog = new Dog();
            //dog.Name = "개1";
            //dog.Eat();
            //dog.Bark();

            //상속2
            //Player P = new Player();
            //P.Name = "이름";
            //P.Render();
            //Wizard wiz = new Wizard();
            //wiz.Name = "법";
            //wiz.Render();
            //wiz.Render2();

            //상속3 (오버라이드)
            //Animal animal = new Animal();
            //Dog dog = new Dog();
            //animal.Speak();
            //dog.Speak();

            //상속4 (업캐스팅) : 자식 클래스 -> 부모클래스로 변환
            //암시적 변환
            //Dog myDog = new Dog();
            //Animal myAnimal = myDog; //Dog를 부모 클래스인 Animal로 업캐스팅
            //myAnimal.Speak();
            Animal myAnimal = new Dog(); //업캐스팅
            Dog myDog = (Dog)myAnimal; //다운캐스팅(명시적 변환)



        }
    }
}
