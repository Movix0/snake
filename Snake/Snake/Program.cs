using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HLine hl = new HLine(0, 119, 0, '#') ;
            hl.Draw();
            VLine vl = new VLine(119, 1, 29, '#');
            vl.Draw();
            HLine hl1 = new HLine(0, 119, 29, '#');
            hl1.Draw();
            VLine vl1 = new VLine(0, 1, 29, '#');
            vl1.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake= new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            Console.ReadLine();
        }
    }
}
