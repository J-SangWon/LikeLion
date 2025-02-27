using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    struct inventory
    {
        public const int MAX_ITEMS = 100;
        public string itemNames;
        public int itemCounts;
    }

    class Program
    {
        static inventory[] inven = new inventory[inventory.MAX_ITEMS];

        static void AddItem(string name, int count)
        {
            for (int i = 0; i < inven.Length; i++)
            {
                if (inven[i].itemNames == name)
                {
                    inven[i].itemCounts += count;
                    return;
                }
            }

            for (int i = 0; i < inven.Length; i++)
            {
                if (inven[i].itemNames == null)
                {
                    inven[i].itemNames = name;
                    inven[i].itemCounts = count;
                    return;
                }
            }
        }

        static void RemoveItem(string name, int count)
        {
            for (int i = 0; i < inven.Length; i++)
            {
                if (inven[i].itemNames == name)
                {
                    if (inven[i].itemCounts >= count)
                    {
                        inven[i].itemCounts -= count;
                        if (inven[i].itemCounts == 0)
                        {
                            inven[i].itemNames = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다");
                        return;
                    }
                }
            }
            Console.WriteLine("아이템을 찾을 수 없습니다.");
        }



        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < inven.Length; i++)
            {
                if (inven[i].itemNames != null)
                {
                    Console.WriteLine($"{inven[i].itemNames} (x{inven[i].itemCounts})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            

            while (true)
            {
                string iItem = null;
                int iItemCount = 0;

                Console.WriteLine("1.아이템 보관\t2.아이템 사용\t3.나가기");
                int PChoose = int.Parse(Console.ReadLine());

                ShowInventory();

                switch (PChoose) {
                    case 1:
                        Console.Write("보관하실 아이템 : ");
                        iItem = Console.ReadLine();
                        Console.Write("개수 : ");
                        iItemCount = int.Parse(Console.ReadLine()); ;
                        AddItem(iItem, iItemCount);
                        ShowInventory();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("사용하실 아이템 : ");
                        iItem = Console.ReadLine();
                        Console.Write("개수 : ");
                        iItemCount = int.Parse(Console.ReadLine()); ;
                        RemoveItem(iItem, iItemCount);
                        ShowInventory();
                        Console.WriteLine();
                        break;
                    case 3: return;
                    default: Console.WriteLine("잘못된 입력입니다."); break;
                }

                
                
            }


            

            



        }



    }
}
