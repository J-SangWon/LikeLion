using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LikeLion19
{
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모");
        }
    }
    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식");
            base.ShowMessage();
        }
    }

    class Player
    {
        protected string Name;
        public Player()
        {
            Name = "player";
            Console.WriteLine("생성자");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizard : Player
    {
        public Wizard()
        {
            Name = "Wizard";
            Console.WriteLine("자식 생성자");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Child child = new Child();
            //child.ShowMessage();

            //Player player = new Player();
            //player.Show();

            Wizard wizard = new Wizard();
            wizard.Show();

        }
    }
}
