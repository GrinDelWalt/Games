using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            LVL1.user_1();
            Console.Write("Ведите имя первго игрока ");
            user_1 = Console.ReadLine();

            while (Console.ReadLine() != "n")
            {
                LVL1.DoGame1();
                Console.WriteLine("Хотите реванш? (y/n)");
                
            }
            

        }
    }
}
