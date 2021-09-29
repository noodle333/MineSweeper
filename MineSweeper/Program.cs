using System;
using System.Collections.Generic;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid g = new SweeperGrid();

            g.Draw();

            int playerX = 0;
            int playerY = 0;

            while (g.isAlive)
            {
                Console.WriteLine("Write a X position");
                playerX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write a Y position");
                playerY = Convert.ToInt32(Console.ReadLine());
                if (g.CheckPosition(playerX, playerY))
                {
                    Console.WriteLine("That was a mine!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Nothing dangerous here!");
                }

                
            }
            
        }
    }
}
