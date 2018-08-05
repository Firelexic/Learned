using System;
using System.Collections.Generic;
using System.Text;

namespace StaticAndInstanceClassMembers
{
    public class Circle
    {
        private static float PI = 3.141f;
        private int radius;

        public Circle(int Radius)
        {
            this.radius = Radius;
        }

        public float CalculateArea()
        {
            return PI * this.radius * this.radius;
        }

        

        public static void Print()
        {

        }

    }
}
