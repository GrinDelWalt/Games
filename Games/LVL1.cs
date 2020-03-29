﻿using System;

namespace Games
{
    public class LVL1
    {
        private string user_1;

        private string user_2;
        
        public LVL1(string user1, string user2)
        {
            user_1 = user1;
            user_2 = user2;
        }

        public void DoGame1()
        {
            Random rand = new Random();
            int iiNumber = rand.Next(7, 21);
            int gameNumber1;
            int gameNumber2;
            

            Console.WriteLine($"{user_1} VS {user_2} Пусть победит сильнейший");

            for (int i = 0; ; i++)
            {
                Console.WriteLine($"Число равно {iiNumber}");

                if (i % 2 != 0)
                {
                    Console.WriteLine($"Ходит игрок {user_1}");
                    
                    gameNumber1 = Convert.ToInt32(Console.ReadLine());                    
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
                        

                        if (iiNumber > 0)
                        {
                            continue;
                        }
                        else if (iiNumber < 0)
                        {
                            Console.WriteLine("Вы перешли рубеж =(");
                            Console.WriteLine($"Игрок {user_2} выйграл!!!");                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Игрок {user_1} выйграл!!!");                            
                            break;
                        }
                    }

                }

                else if (i % 2 != 1)
                {
                    Console.WriteLine($"Ходит игрок {user_2}");
                    gameNumber2 = Convert.ToInt32(Console.ReadLine());
                    

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
                            Console.WriteLine($"Игрок {user_1} выйграл!!!");                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Игрок {user_2} выйграл!!!");                            
                            break;
                        }
                    }
                }
            }
        }
    }
}
