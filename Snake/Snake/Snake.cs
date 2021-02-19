using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int lenght, Direction direction)
        {
            this.direction = direction;
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }


        }
             internal void Move() 
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point getNextPoint()
        {   
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void Handler()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Write("\b \b");
                    if (key.Key == ConsoleKey.D)
                        direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.A)
                        direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.W)
                        direction = Direction.UP;
                    else if (key.Key == ConsoleKey.S)
                        direction = Direction.DOWN;
                }
                Thread.Sleep(100);
                Move();
            }
        }
    }
}
