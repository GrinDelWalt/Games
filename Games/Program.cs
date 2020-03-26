using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            LVL1 lvl1 = new LVL1();

            while (Console.ReadLine() != "n")
            {
                lvl1.DoGame1();
                Console.WriteLine("Хотите реванш? (y/n)");
            }
        }
    }
}
