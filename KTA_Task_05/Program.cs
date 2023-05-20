using System;
using System.IO;

class GameMap
{
    static void Main()
    { }



    private char[,] map;
    private int playerX;
    private int playerY;

    public GameMap(string filename)
    {
        try
        {
            filename = "X:/TrainingPractice_01-main/KTA_Task_05/level01.txt";
            string[] lines = File.ReadAllLines("filename");

            int height = lines.Length;
            int width = lines[0].Length;
            map = new char[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j] = lines[i][j];
                    if (map[i, j] == '■')
                    {
                        playerX = j;
                        playerY = i;
                        map[i, j] = ' ';
                    }
                }
            }
        }
        catch(Exception e) { }


        void Draw()
        {
            Console.Clear();
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

         bool MovePlayer(int dx, int dy)
        {
            int newX = playerX + dx;
            int newY = playerY + dy;
            if (newX >= 0 && newX < map.GetLength(1) && newY >= 0 && newY < map.GetLength(0))
            {
                if (map[newY, newX] != '#')
                {
                    playerX = newX;
                    playerY = newY;
                    return true;
                }
            }
            return false;
        }

         void PlaceEnemies()
        {
            Random random = new Random();
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] == ' ')
                    {
                        if (random.NextDouble() < 0.1)
                        {
                            map[i, j] = 'E';
                        }
                    }
                }
            }
        }

        void MoveEnemies()
        {
            Random random = new Random();
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] == 'E')
                    {
                        int dx = random.Next(-1, 2);
                        int dy = random.Next(-1, 2);
                        int newX = j + dx;
                        int newY = i + dy;
                        if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                        {
                            if (map[newY, newX] == ' ')
                            {
                                map[i, j] = ' ';
                                map[newY, newX] = 'E';
                            }
                        }
                    }
                }
            }
        }

        void ShowPath()
        {
            // TODO: implement pathfinding algorithm
        }

        void DrawBar(int percent, int length, int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write("[");
            int numFilled = (int)Math.Round(percent / 100.0 * length);
            for (int i = 0; i < length; i++)
            {
                if (i < numFilled)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.Write("]");
        }
    }
}