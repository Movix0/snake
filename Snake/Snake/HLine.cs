using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine : Figure
    {
        int xLeft;
        int xRight;
        int y;
        char sym;

        public HLine(int xLeft_, int xRight_, int y_, char sym_)
        {
            xLeft = xLeft_;
            xRight = xRight_;
            y = y_;
            sym = sym_;

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p1 = new Point(x, y, sym);
                pList.Add(p1);
            }
    }
    }
}
