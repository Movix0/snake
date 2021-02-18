using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x1;
        int y1;
        char sym1;

        public Point()
        {

        }
       public Point(int x, int y, char sym)
        {
            x1 = x;
            y1 = y;
            sym1 = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
        }

        public void HDraw()
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
        }
    }
}
