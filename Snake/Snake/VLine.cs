using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine
    {
        int x;
        int yTop;
        int yDown;
        char sym;

        List<Point> plist = new List<Point>();
        public VLine(int x_, int yTop_, int yDown_, char sym_)
        {
            x = x_;
            yTop = yTop_;
            yDown = yDown_;
            sym = sym_;
        }
        public void CalcLine()
        {
            for(int y = yTop; y<=yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public void Draw()
        {
            CalcLine();
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
