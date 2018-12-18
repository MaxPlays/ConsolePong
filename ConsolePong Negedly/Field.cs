using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong_Negedly
{
    static class Field
    {
        /// <summary>
        /// Draws the field
        /// </summary>
        /// <param name="size">Size of the field</param>
        /// <param name="f">Foreground colour</param>
        /// <param name="b">Background colour</param>
        public static void Draw(Vector size, ConsoleColor f, ConsoleColor b)
        {
            Console.Title = "Console Pong";
            Console.SetWindowSize(size.X, size.Y);
            Console.SetBufferSize(size.X, size.Y);
            Console.ForegroundColor = f;
            Console.BackgroundColor = b;
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            DrawCenterLine();
        }


        /// <summary>
        /// Draws the center line
        /// </summary>
        public static void DrawCenterLine()
        {
            int w = Console.WindowWidth;
            int h = Console.WindowHeight;

            for(int i = 0; i < h; i += 2)
            {
                Console.SetCursorPosition(w / 2, i);
                Console.Write("|");
            }
        }
    }
}
