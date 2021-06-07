﻿using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s = generator.GetNewFigure();

            s.Draw();
            Thread.Sleep(1000);

            s.Hide();
            s.Rotate();
            s.Draw();

            Thread.Sleep(1000);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            Thread.Sleep(1000);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(1000);
            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            s.Hide();
            s.Rotate();
            s.Draw();

            Thread.Sleep(1000);
            s.Hide();
            s.Move(Direction.RIGHT);
            s.Draw();

            //Stick stick = new Stick(6, 6, '*');
            //stick.Draw();

            //Point p1 = new Point(2, 3, '*');
            //p1.Draw();

            Point p2 = new Point()
            {
                x = 4,
                y = 5,
            };

            p2.Draw();


            Console.ReadLine();
        }

    }
}
