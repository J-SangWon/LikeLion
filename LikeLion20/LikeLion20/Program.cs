using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion20
{
    class Unit
    {
        public string Name;
        public int Health;
        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다. ");
        }
        public virtual void Move() 
        {
            Console.WriteLine($"{Name}이 이동합니다. ");
        }
        public virtual void Heal(Unit target) 
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다. ");
        }

    }
    class SCV : Unit 
    {
        public SCV() 
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다! (공격력이 약함)");
        }
    }

    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 50;
        }
        public override void Attack()
        {
            Console.WriteLine("소총으로 Marine이 공격합니다");
        }
    }
    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 60;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic 이 {target.Name}을 치료합니다");
        }
    }

    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }
        public override void Attack()
        {
            Console.WriteLine("Tank가 공격합니다");
        }
        public override void Move()
        {
            Console.WriteLine("Tank가 이동합니다");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());
            

            foreach(var unit in units)
            {
                unit.Move();
                unit.Attack();
                Console.WriteLine();
            }
            
            SCV scv = new SCV();
            scv.Heal(units[3]);
            Medic medic = new Medic();
            medic.Heal(units[1]);



        }
    }
}
