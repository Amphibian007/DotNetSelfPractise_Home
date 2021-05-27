using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int a,int b)
        {
            this.x = a;
            this.y = b;
        }
        public void Move(int a,int b)
        {
            this.x = a;
            this.y = b;
        }
        public void Move(Point newPoint)
        {
            if (newPoint == null)
                 throw new NullReferenceException("newPoint");
            Move(newPoint.x, newPoint.y);
        }
    }
}
