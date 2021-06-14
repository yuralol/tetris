﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.SetCursorPosition(0, 0);
        }

        public void HidePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(0, 0);
        }

        private void WriteGameOver()
        {
            Console.SetCursorPosition(Field.Width / 2 - 8, Field.Height / 2);
            Console.WriteLine("G A M E  O V E R");
        }

        public void InitField()
        {
            Console.SetWindowSize(Field.Width, Field.Height);
            Console.SetBufferSize(Field.Width, Field.Height);
        }

        void IDrawer.WriteGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
