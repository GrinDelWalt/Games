using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
    class LVL1
    {

        public static string user_1;
       
        private static string user_2;
            

            Console.Write("Ведите имя второго игрока ");
            user_2 = Console.ReadLine();
        
        public static void DoGame1()
            {
            Random rand = new Random();
            int iiNumber = rand.Next(5, 6);
            int gameNumber1;
            int gameNumber2;
            int count = 0;

            //string user_1;
            //string user_2;
            //Console.Write("Ведите имя первго игрока ");
            //user_1 = Console.ReadLine();

            //Console.Write("Ведите имя второго игрока ");
            //user_2 = Console.ReadLine();

            Console.WriteLine($"Приведствую вас {UserName.user_1} и {user_2}! Пусть победит сильнейший");
            for (int i = 0; ; i++)
            {

                count++;
                if (i % 2 != 0)
                {

                    Console.WriteLine($"Ходит игрок {UserName.user_1}");
                    gameNumber1 = Convert.ToInt32(Console.ReadLine());
                    //iiNumber = iiNumber - gameNumber1;
                    //Console.WriteLine($"Число равно {iiNumber}");
                    if (gameNumber1 > 4)
                    {
                        Console.WriteLine("Число больше 4");
                        continue;
                    }
                    else if (gameNumber1 < 1)
                    {
                        Console.WriteLine("Число меньше 1");
                        continue;
                    }

                    else
                    {
                        iiNumber = iiNumber - gameNumber1;
                        Console.WriteLine($"Число равно {iiNumber}");
                        //continue;

                        if (iiNumber > 0)
                        {
                            continue;
                        }
                        else if (iiNumber < 0)
                        {
                            Console.WriteLine("Вы перешли рубеж =(");
                            Console.WriteLine($"Игрок {User.user_2} выйграл!!!");
                            //Console.WriteLine($"{user_1} Повторим? (n/y)");
                            //ConsoleKeyInfo c = Console.ReadKey();
                            //if (c.KeyChar == 'n') break;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Игрок {User.user_1} выйграл!!!");
                            //Console.WriteLine($"{user_2} Повторим? (n/y)");
                            //ConsoleKeyInfo c = Console.ReadKey();
                            //if (c.KeyChar == 'n') break;
                            break;
                        }
                    }

                }

                else if (i % 2 != 1)
                {
                    Console.WriteLine($"Ходит игрок {User.user_2}");
                    gameNumber2 = Convert.ToInt32(Console.ReadLine());
                    //iiNumber = iiNumber - gameNumber2;
                    //Console.WriteLine($"Число равно {iiNumber}");

                    if (gameNumber2 > 4)
                    {
                        Console.WriteLine("Число больше 4");
                        continue;
                    }
                    else if (gameNumber2 < 1)
                    {
                        Console.WriteLine("Число меньше 1");
                        continue;
                    }
                    else
                    {
                        iiNumber = iiNumber - gameNumber2;
                        Console.WriteLine($"Число равно {iiNumber}");

                        if (iiNumber > 0)
                        {
                            continue;
                        }
                        else if (iiNumber < 0)
                        {
                            Console.WriteLine("Вы перешли рубеж =(");
                            Console.WriteLine($"Игрок {User.user_1} выйграл!!!");
                            //Console.WriteLine($"{user_2} Повторим? (n/y)");
                            //ConsoleKeyInfo c = Console.ReadKey();
                            //if (c.KeyChar == 'n') break;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Игрок {User.user_2} выйграл!!!");
                            //Console.WriteLine($"{user_1} Повторим? (n/y)");
                            //ConsoleKeyInfo c = Console.ReadKey();
                            //if (c.KeyChar == 'n') break;
                            break;
                        }
                    }

                }




            }
        }
        

    }
}
