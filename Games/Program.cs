using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя первго игрока ");
            string user_1 = Console.ReadLine();

            Console.Write("Введите имя второго игрока ");
            string user_2 = Console.ReadLine();

            LVL1 lvl1 = new LVL1(user_1, user_2);

            while (Console.ReadLine() != "n")
            {
                lvl1.DoGame1();
                Console.WriteLine("Хотите реванш? (y/n)");
            }
        }
    }
}
