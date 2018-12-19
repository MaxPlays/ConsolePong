﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong_Negedly
{
    class Paddle
    {
        private char character;
        private ConsoleColor color;
        private Vector fieldSize, positionNew, positionOld, positionStart;
        private int size, speed;

        public int Size {
            get {
                return size;
            }
        }
        public Vector Position {
            get {
                return positionNew;
            }
        }

        public Paddle(char character, ConsoleColor color, Vector fieldSize, Vector positionStart, int size, int speed)
        {
            this.character = character;
            this.color = color;
            this.fieldSize = fieldSize;
            this.positionStart = positionStart;
            this.size = size;
            if (this.size < 3)
                this.size = 3;
            this.speed = speed;

            positionNew = positionStart;
            positionOld = positionStart;
        }

        public void Update(string move)
        {
            switch (move)
            {
                case "up":
                    positionNew = new Vector(positionOld.X, positionOld.Y - speed);
                    if (positionNew.Y < 0)
                        positionNew.Y = 0;
                    break;

                case "down":
                    positionNew = new Vector(positionOld.X, positionOld.Y + speed);
                    if (positionNew.Y > fieldSize.Y - size)
                        positionNew.Y = fieldSize.Y - size;
                    break;
            }
        }

        public void Draw()
        {
            for(int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(positionOld.X, positionOld.Y + i);
                Console.Write(" ");
            }
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for(int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(positionNew.X, positionNew.Y + i);
                Console.Write(character);
            }
            Console.ForegroundColor = foregroundColor;
            positionOld = positionNew;
        }
    }
}
