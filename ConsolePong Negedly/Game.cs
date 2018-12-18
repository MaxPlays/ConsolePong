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

        public Game()
        {
            Field.Draw(fieldSize, foreColor, backColor);
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
                    Field.DrawCenterLine();

                }
            }
        }
    }
}
