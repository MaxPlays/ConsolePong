using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong_Negedly
{
    class Ball
    {
        private char character;
        private ConsoleColor color;
        private Vector fieldSize, positionNew, positionOld, positionStart, velocity;

        public Ball(char character, ConsoleColor color, Vector fieldSize)
        {
            this.character = character;
            this.color = color;
            this.fieldSize = fieldSize;

            positionStart = new Vector(fieldSize.X / 2, fieldSize.Y / 2 - 1);
            positionNew = positionStart;
            positionOld = positionStart;

            velocity = new Vector(4, 2);
        }

        public void Update()
        {
            positionNew = positionOld + velocity;

            if(positionNew.X < 0)
            {
                positionNew.X = 0;
                velocity.X *= -1;
            }
            if(positionNew.X > fieldSize.X - 1)
            {
                positionNew.X = fieldSize.X - 1;
                velocity.X *= -1;
            }
            if(positionNew.Y < 0)
            {
                positionNew.Y = 0;
                velocity.Y *= -1;
            }
            if(positionNew.Y > fieldSize.Y - 1)
            {
                positionNew.Y = fieldSize.Y - 1;
                velocity.Y *= -1;
            }

            if(positionNew.X == fieldSize.X - 1 && positionNew.Y == fieldSize.Y - 1)
            {
                positionNew.Y = fieldSize.Y - 2;
                positionNew.X = fieldSize.X - 2;
                velocity.X *= -1;
                velocity.Y *= -1;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(positionOld.X, positionOld.Y);
            Console.Write(" ");
            Console.SetCursorPosition(positionNew.X, positionNew.Y);
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(character);
            Console.ForegroundColor = foregroundColor;
            positionOld = positionNew;
        }
    }
}
