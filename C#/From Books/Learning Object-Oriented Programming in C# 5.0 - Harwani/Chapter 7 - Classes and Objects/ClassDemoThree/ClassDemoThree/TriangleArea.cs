using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoThree
{
    public class TriangleArea
    {
        private int b, h;
        public void SetValue(int x, int y)
        {
            b = x;
            h = y;
        }

        public float GetTriangle()
        {
            return (float)1 / 2 * b * h;
        }
    }
}
