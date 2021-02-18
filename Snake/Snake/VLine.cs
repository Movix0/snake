using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine : Figure
    {
        int x;
        int yTop;
        int yDown;
        char sym;

        public VLine(int x_, int yTop_, int yDown_, char sym_)
        {
            x = x_;
            yTop = yTop_;
            yDown = yDown_;
            sym = sym_;

            for (int y = yTop; y <= yDown; y++)
                {
                    Point p = new Point(x, y, sym);
                    pList.Add(p);
                }
        }
    }
}
