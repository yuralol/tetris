﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);
            Draw();
        }
        public override void Rotate(Point[] pList)
        {
            if(pList[0].x == pList[1].x)
            {
                RotateHorizontal(pList);
            }
            else
            {
                RotateVertical(pList);
            }
        }

        private void RotateVertical(Point[] pList)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                pList[i].x = pList[0].x;
                pList[i].y = pList[0].y + i;
            }
        }

        private void RotateHorizontal(Point[] pList)
        {
            for(int i = 0; i < pList.Length; i++)
            {
                pList[i].y = pList[0].y;
                pList[i].x = pList[0].x + i;
            }
        }
    }
}
