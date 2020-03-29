using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int user;
            Console.Write("Выберите количество игроков: ");
            user = Convert.ToInt32(Console.ReadLine());
            
            

            if (user == 2)
            {               
                Game.game();
            }
            else
            {
                Console.Write("Введите имя игрока ");
                string user_1 = Console.ReadLine();
                Console.WriteLine($"Приветствую тебя {user_1}!" +
                    "\nВ данной игре тебе нужно обхитрить Компьютер и первым достич 0." +              
                    "\nДа прибудет с тобой сила!!!" +
                    "\nДля продолжения нажмите Enter");
                while (Console.ReadLine() != "n")
                {
                    II iigame = new II(user_1);
                    iigame.iigame();
                    Console.WriteLine("Хотите повторить? (y/n)");
                }
            }
        }
    }
}
