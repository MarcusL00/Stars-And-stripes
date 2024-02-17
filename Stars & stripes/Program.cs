using System;

namespace StarsAndStripes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var height = 26;
            var width = 38;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < height; i++)
                {
                    if (i % 4 < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }

                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
                Console.BackgroundColor= ConsoleColor.Black;
                break;
            }

            // going back to the first line so i can make the blue part ontop of the background color of red and white
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 11; i++)
            {
                if (i <= 11)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                }
                for (int j = 0; j < 23; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            // going back to line 1 so i can insert the stars
            Console.SetCursorPosition (0, 0); 
            for(int i = 0;i < 9; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine();
                }
                if (i <=8) 
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(" *   *   *   *   *   * ");
                    }
                    else 
                    {
                        Console.WriteLine("   *   *   *   *   *");
                    }
                }
                if (i == 10)
                {
                    Console.BackgroundColor= ConsoleColor.Black;
                    Console.WriteLine();
                }
            }
                while (true) { }
        }
    }
}
