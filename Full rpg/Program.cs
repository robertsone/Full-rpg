using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_rpg
{
    class Program 
    {

        static void Main(string[] args)
        {
            int left = 1;
            int up = 1;
            while (true)//Game Loop
            {
                Console.SetCursorPosition(left, up);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo KeyPressed = Console.ReadKey();

                    if (KeyPressed.Key == ConsoleKey.LeftArrow)
                        left--;
                    if (KeyPressed.Key == ConsoleKey.RightArrow)
                        left++;
                    if (KeyPressed.Key == ConsoleKey.DownArrow)
                        up++;
                    if (KeyPressed.Key == ConsoleKey.UpArrow)
                        up--;
                }
                Console.Clear();

                if (up <= 0)
                    up = 0;
                if (left <= 0)
                    left = 0;
                if (up >= 21)
                    up = 21;
                if (left >= 75)
                    left = 75;


                Console.SetCursorPosition(left, up);
                System.Console.WriteLine("   o"); Console.SetCursorPosition(left, up+1);
                System.Console.WriteLine("  -|-"); Console.SetCursorPosition(left, up+2);
                System.Console.WriteLine("  / \\");

            }
        }
    }
}
