using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePong_Negedly
{
    class Game
    {
        private Vector fieldSize = new Vector(80, 25);
        private ConsoleColor foreColor = ConsoleColor.White;
        private ConsoleColor backColor = ConsoleColor.Black;
        private int loopTime = 90;

        private Ball ball;
        private char ballCharacter = '■';
        private ConsoleColor ballColor = ConsoleColor.White;

        private char paddleCharacter = '█';
        private int paddleSize = 4, paddleSpeed = 1, paddleOffset = 6;

        private Paddle paddleLeft;
        private ConsoleColor paddleLeftColor = ConsoleColor.White;

        private Paddle paddleRight;
        private ConsoleColor paddleRightColor = ConsoleColor.White;

        public Game()
        {
            Field.Draw(fieldSize, foreColor, backColor);
            ball = new Ball(ballCharacter, ballColor, fieldSize);

            paddleLeft = new Paddle(paddleCharacter, paddleLeftColor, fieldSize, new Vector(paddleOffset - 1, (fieldSize.Y - paddleSize) / 2), paddleSize, paddleSpeed);
            paddleRight = new Paddle(paddleCharacter, paddleRightColor, fieldSize, new Vector(fieldSize.X - paddleOffset, (fieldSize.Y - paddleSize) / 2), paddleSize, paddleSpeed);
        }

        public void Run()
        {
            DateTime t0 = DateTime.Now, t1;
            while (true)
            {
                t1 = DateTime.Now;
                int ms = (t1.Millisecond - t0.Millisecond + 1000) % 1000;
                if(ms > loopTime)
                {
                    t0 = t1;
                    UserInput.GetKeyState(paddleLeft, paddleRight);

                    Field.DrawCenterLine();

                    ball.Update(paddleLeft, paddleRight);
                    ball.Draw();

                    paddleLeft.Draw();
                    paddleRight.Draw();
                }
            }
        }
    }
}
