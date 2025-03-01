using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion15
{

    //class Person
    //{
    //    private string Name;
    //    //private 일때 값 설정하기(Setter)
    //    public void SetName(string Name) {
    //        this.Name = Name;
    //    }
    //    //private 일때 값 가져오기(Getter)
    //    public string GetName()
    //    {
    //        return this.Name;
    //    }
    //}

    //class Person
    //{
    //    private string name;
    //    public string Name { 
    //        get { return name; } 
    //        set { name = value; } 
    //    }
    //}

    class Person
    {
        private string name;
        private int count = 100;
        private int balance;
        
        public string Name { get; set; }
        public int Count { get { return count; } }
        public float Balance { get; private set; }


    }

    //프로퍼티를 이용해서 마린 클래스 만들기
    class Marine
    {
        public string Name { get; private set; } = "Marine";
        public int Mineral { get; private set; } = 50;
        public int Pop { get; private set; } = 1;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "gildong";
            Console.WriteLine($"{person.Name} : {person.Count}");

            Marine marine = new Marine();
            Console.WriteLine($"{marine.Name} + {marine.Mineral} + {marine.Pop}");

        }
    }
}
