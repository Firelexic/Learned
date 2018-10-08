using System;
using System.Collections.Generic;
using System.Text;

namespace CoordianteExample
{
    public class Point
    {
        private double[] coordinates;
        
        public Point(int xCoord, int yCoord)
        {
            this.coordinates = new double[2];

            coordinates[0] = xCoord;

            coordinates[1] = yCoord;
        }
        public double X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public double Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }
    }
}
