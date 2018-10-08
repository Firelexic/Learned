using System;
using System.Collections.Generic;
using System.Text;

namespace PointExample
{
    public class Point
    {
        private double x;
        private double y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
