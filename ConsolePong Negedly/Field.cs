using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong_Negedly
{
    /*
       Copyright 2018 Maximilian Negedly

       Licensed under the Apache License, Version 2.0 (the "License");
       you may not use this file except in compliance with the License.
       You may obtain a copy of the License at

           http://www.apache.org/licenses/LICENSE-2.0

       Unless required by applicable law or agreed to in writing, software
       distributed under the License is distributed on an "AS IS" BASIS,
       WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
       See the License for the specific language governing permissions and
       limitations under the License.
     */

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
        private static void DrawCenterLine()
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
