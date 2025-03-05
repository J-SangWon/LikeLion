using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LikeLion21
{

    //부모클래스 (기본유닛)
    class Champion
    {
        public string Name;
        public int Health, Mana, ManaRegen, Atk, AP, Armor, Resist, AtkRange, MoveSpeed, AbilityHaste;
        public double AtkSpeed;
        public int QCoolDown, QManaCost, WCoolDown, WManaCost, ECoolDown, EManaCost, RCoolDown, RManaCost;
        private int lastTick;
        private int qRemainingCoolDown, wRemainingCoolDown, eRemainingCoolDown, rRemainingCoolDown;

        public Champion() { }
        public virtual void Move() { }
        public virtual void Atack() { }
        public virtual void UseSkills()
        {
            Console.Write("사용할 스킬을 고르십시오 : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "q":
                    if (qRemainingCoolDown > 0)
                    {
                        Console.WriteLine("Q스킬 쿨타임 중입니다.");
                    }
                    else if (Mana < QManaCost)
                    {
                        Console.WriteLine("마나 부족");
                    }
                    else
                    {
                        Mana -= QManaCost;
                        qRemainingCoolDown = QCoolDown;
                        Console.WriteLine("Q스킬을 사용했습니다.");
                    }
                    break;
                case "w":
                    if (wRemainingCoolDown > 0)
                    {
                        Console.WriteLine("W스킬 쿨타임 중입니다.");
                    }
                    else if (Mana < WManaCost)
                    {
                        Console.WriteLine("마나 부족");
                    }
                    else
                    {
                        Mana -= WManaCost;
                        wRemainingCoolDown = WCoolDown;
                        Console.WriteLine("W스킬을 사용했습니다.");
                    }
                    break;
                case "e":
                    if (eRemainingCoolDown > 0)
                    {
                        Console.WriteLine("E스킬 쿨타임 중입니다.");
                    }
                    else if (Mana < EManaCost)
                    {
                        Console.WriteLine("마나 부족");
                    }
                    else
                    {
                        Mana -= EManaCost;
                        eRemainingCoolDown = ECoolDown;
                        Console.WriteLine("E스킬을 사용했습니다.");
                    }
                    break;
                case "r":
                    if (rRemainingCoolDown > 0)
                    {
                        Console.WriteLine("R스킬 쿨타임 중입니다.");
                    }
                    else if (Mana < RManaCost)
                    {
                        Console.WriteLine("마나 부족");
                    }
                    else
                    {
                        Mana -= RManaCost;
                        rRemainingCoolDown = RCoolDown;
                        Console.WriteLine("R스킬을 사용했습니다.");
                    }
                    break;
                default: Console.WriteLine("잘못된 입력"); break;
            }
        }
        public virtual void ManaReg()
        {
            if (Environment.TickCount - lastTick >= 1000) // 1초마다 마나 회복
            {
                Mana += ManaRegen;
                if (qRemainingCoolDown > 0) qRemainingCoolDown--;
                if (wRemainingCoolDown > 0) wRemainingCoolDown--;
                if (eRemainingCoolDown > 0) eRemainingCoolDown--;
                if (rRemainingCoolDown > 0) rRemainingCoolDown--;

                lastTick = Environment.TickCount;
            }
        }
        public virtual void PrintInfo()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"Atk: {Atk}");
            Console.WriteLine($"AtkSpeed: {AtkSpeed}");
            Console.WriteLine($"AP: {AP}");
            Console.WriteLine($"Armor: {Armor}");
            Console.WriteLine($"Resist: {Resist}");
            Console.WriteLine($"AtkRange: {AtkRange}");
            Console.WriteLine($"MoveSpeed: {MoveSpeed}");
            Console.WriteLine($"Q: Cost : {QManaCost}  Cooldown : {QCoolDown}  RemainCool : {qRemainingCoolDown}" );
            Console.WriteLine($"W: Cost : {WManaCost}  Cooldown : {WCoolDown}  RemainCool : {wRemainingCoolDown}");
            Console.WriteLine($"E: Cost : {EManaCost}  Cooldown : {ECoolDown}  RemainCool : {eRemainingCoolDown}");
            Console.WriteLine($"R: Cost : {RManaCost}  Cooldown : {RCoolDown}  RemainCool : {rRemainingCoolDown}");
        }
    }

class chogath : Champion
    {
        public chogath()
        {
            Name = "chogath";
            Health = 644;
            Mana = 270;
            ManaRegen = 10;
            Atk = 69;
            AtkSpeed = 0.625;
            AP = 0;
            Armor = 38;
            Resist = 32;
            AtkRange = 125;
            MoveSpeed = 345;
            AbilityHaste = 0;
            QCoolDown = 6;
            QManaCost = 60;
            WCoolDown = 11;
            WManaCost = 70;
            ECoolDown = 8;
            EManaCost = 50;
            RCoolDown = 80;
            RManaCost = 100;
        }

        public override void Move()
        {
            Console.WriteLine("Cho'Gath is moving");
        }
        public override void Atack()
        {
            Console.WriteLine("Cho'Gath is attacking.");
        }
        public override void ManaReg()
        {
            base.ManaReg();
        }
        public override void UseSkills()
        {
            base.UseSkills();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }




class Program
    {
        static void Main(string[] args)
        {
            Champion champion = new chogath();

            while (true)
            {
                Console.Clear();
                champion.PrintInfo();
                champion.ManaReg();
                champion.UseSkills();
                Thread.Sleep(500); // 0.5초마다 갱신
            }
        }
    }
}