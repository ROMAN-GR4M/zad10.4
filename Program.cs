using System;

namespace ZadLos5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź miasta: ");
            string f = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            Console.WriteLine("Wprowadź ilość magazynów: ");
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();
            string l3 = Console.ReadLine();
            string l4 = Console.ReadLine();
            string l5 = Console.ReadLine();
            string[,] miasta = { { f, l1 }, { b, l2 }, { c, l3 }, { d, l4 }, { e, l5 } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0,6}", miasta[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
