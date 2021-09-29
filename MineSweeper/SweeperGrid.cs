using System;

namespace MineSweeper
{
    public class SweeperGrid
    {
        static int gridX = 10;
        static int gridY = 10;

        public bool isAlive = true;

        public int[,] gridArr = new int[gridX, gridY];

        public SweeperGrid()
        {
            Random gen = new Random();
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    gridArr[i,j] = 9;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                int randomI = gen.Next(gridX);
                int randomJ = gen.Next(gridY);

                gridArr[randomI, randomJ] = 10;            
            }    
        } 
        
        public bool CheckPosition(int x, int y)
        {
            if (x >= 0 && x <= gridX-1 && y >= 0 && y <= gridY-1)
            {
                if (gridArr[x, y] == 10)
                {   
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    if (gridArr[i, j] == 10)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("█ ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}