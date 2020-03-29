using System;
using System.Collections.Generic;
using System.Text;

namespace Games
{
    class II
    {
        private string user_1;
        public II(string user1)
        {
            user_1 = user1;
        }
        public  void iigame()
        {
            Random rand = new Random();
            int iiNumber = rand.Next(14, 121);
            int gameNumber1;
            int gameii;




            Console.WriteLine($"Число = {iiNumber}");

            for (int i = 1; ; i++)
                {
                    

                    if (i % 2 != 0)
                    {
                        while (gameNumber1 > 0 )
                        Console.WriteLine($"Ходит игрок {user_1}");

                        gameNumber1 = Convert.ToInt32(Console.ReadLine());
                        if (gameNumber1 > 10)
                        {
                            Console.WriteLine("Число больше 10");
                            
                        }
                        else if (gameNumber1 < 1)
                        {
                            Console.WriteLine("Число меньше 1");
                            
                        }

                        else
                        {
                            iiNumber = iiNumber - gameNumber1;
                            Console.WriteLine($"Число = {iiNumber}");

                            if (iiNumber > 0)
                            {
                                continue;
                            }
                            else if (iiNumber < 0)
                            {
                                Console.WriteLine("Вы перешли рубеж =(");
                                Console.WriteLine($"Компьютер выйграл!!!");
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
                        Console.WriteLine($"Ходит Компьютер");
                        


                        if (iiNumber > 10)
                        {
                            
                            iiNumber = iiNumber - 10;
                            Console.WriteLine($"Число = {iiNumber}");
                            continue;
                        }

                        else
                        {
                            iiNumber = iiNumber - iiNumber;
                            Console.WriteLine($"Число = {iiNumber}");

                            if (iiNumber > 0)
                            {
                                continue;
                            }

                            else
                            {
                                Console.WriteLine($"Компьютер выйграл!!!");
                                break;
                            }
                        }


                }
            }
        }
    }
}

