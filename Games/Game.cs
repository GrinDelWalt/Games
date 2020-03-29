using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
    class Game
    {
        
        public static void game()
        {
            Console.Write("Введите имя первго игрока ");
            string user_1 = Console.ReadLine();

            Console.Write("Введите имя второго игрока ");
            string user_2 = Console.ReadLine();

            int lvl;
            Console.WriteLine("Приветствую вас игроки!" +
                    "\nВ данной игре вам нужно обхитрить своего соперника и первым достич 0." +
                    "\nВам будет доступны 3 уровня сложности" +
                    "\n1 уровень - числа от 7 до 20 и вычитаемые числа от 1 до 4" +
                    "\n2 уровень - числа от 10 до 50 и вычитаемые числа от 1 до 6" +
                    "\n3 уровень - числа от 14 до 120 и вычитаемые числа от 1 до 10" +
                    "\nДа прибудет с вами сила!!!" +
                    "\nДля продолжения нажмите Enter");
            while (Console.ReadLine() != "n")
            {
                Console.WriteLine("Выберите уровень сложности: \nЛегкий - введите число 1 \nСредний - введите число 2 \nСложный - введите число 3");
                lvl = Convert.ToInt32(Console.ReadLine());
                if (lvl == 1)
                {
                    Console.WriteLine("Вы выбрали Легкий уровень сложности");

                    LVL1 lvl1 = new LVL1(user_1, user_2);

                    lvl1.DoGame1();
                    Console.WriteLine("Хотите реванш? (y/n)");
                }

                else if (lvl == 2)
                {
                    Console.WriteLine("Вы выбрали средний уровень сложности");

                    LVL2 lvl2 = new LVL2(user_1, user_2);

                    lvl2.DoGame2();
                    Console.WriteLine("Хотите реванш? (y/n)");
                }

                else if (lvl == 3)
                {
                    LVL3 lvl3 = new LVL3(user_1, user_2);

                    Console.WriteLine("Вы выбрали Высокий уровень сложности");

                    lvl3.DoGame3();
                    Console.WriteLine("Хотите реванш? (y/n)");
                }
                else
                {
                    Console.WriteLine("Вы выбрали несуществующий уровень сложности, повоторите выбор!");
                    continue;
                }

            }
        }
    }
}
