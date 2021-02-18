using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HLine
    {
        int xLeft;
        int xRight;
        int y;
        char sym;

        List<Point> pList = new List<Point>();

        public HLine(int xLeft_, int xRight_, int y_, char sym_)
        {
            xLeft = xLeft_;
            xRight = xRight_;
            y = y_;
            sym = sym_;
        }

        public void CalcLine()
        {
           for(int x=xLeft; x<=xRight; x++)
            {
                Point p1 = new Point(x, y, sym);
                pList.Add( p1 );
      /*          Console.WriteLine("\n{0}, {1}, {2} ", x, y, sym); */
            }
        }
        public void Draw()
        {
            CalcLine();
            foreach(Point p in pList)
            {
                p.HDraw();
            }

        }
    }
}
