using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("□□□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("");
            //Console.WriteLine("■□□□□□□□□□");

            for(int i = 0; i<10; i++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("■");
                }
                for(int k = 9-i; k>0; k--)
                {
                    Console.Write("□");
                }
                Thread.Sleep(1000);
                Console.Clear();

            }
            Console.WriteLine("Loading Complete");
            
        }
    }
}
