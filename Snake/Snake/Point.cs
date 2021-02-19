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

        public Point(Point tail)
        {
            x1 = tail.x1;
            y1 = tail.y1;
            sym1 = tail.sym1;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.DOWN)
            {
                y1+=offset;
            }else if(direction == Direction.UP)
            {
                y1 -= offset;
            }else if(direction == Direction.RIGHT)
            {
                x1 += offset;
            }
            else
            {
                x1 -= offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
        }

        public void Clear()
        {
            sym1 = ' ';
            Draw();
        }
        public int getX()
        {
            int x = x1;
            return x;
        }

        public int gety()
        {
            int y = y1;
            return y;
        }

        public char getSym()
        {
            char sym = sym1;
            return sym;
        }
    }
}
