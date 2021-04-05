using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class Gambler
    {
        public static void ReadStakeAmountAndGoal()
        {
            int wons = 0;
            int loose = 0;
            Console.WriteLine("Enter stake amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            //int randomValue = random.Next(0, 2);
            //Console.WriteLine("Generated random value" + randomValue);

            for (int i = 1; i > 0; i++)
            {
                if (amount > 0)
                {
                    int randomValue = random.Next(0, 2);

                    if (randomValue == 1)
                    {
                        amount = amount + 1;
                        wons++;

                        if (amount == goal)
                        {
                            Console.WriteLine("Number of bets played in the game=" + i);
                            Console.WriteLine("Nu,ber of wons=" + wons);
                            Console.WriteLine("Nuber of loose=" + loose);
                            break;
                        }
                    }
                    else
                    {
                        if (amount > 0)
                        {
                            amount = amount - 1;
                            loose++;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Game broken that means amount is not sufficient");
                    break;
                }
                }
                Console.WriteLine("final amount either iit may reach to goal or break the game" + amount);
            }
        }
    }
