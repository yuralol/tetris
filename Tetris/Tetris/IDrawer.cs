﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    interface IDrawer
    {
        void DrawPoint(int x, int y);
        void HidePoint(int x, int y);
    }
}
