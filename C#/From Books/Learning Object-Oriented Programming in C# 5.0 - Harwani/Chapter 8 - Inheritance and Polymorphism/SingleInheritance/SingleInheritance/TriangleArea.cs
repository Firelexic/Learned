using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    public class TriangleArea : RectArea
    {
        private int breadth;
        private float high;
        private float a;
        public void SetTrg(int breadth,int high)
        {
            this.breadth = breadth;
            this.high = high;
        }

        public float GetTrg()
        {
            this.a = (float)1 / 2 * breadth * high;
            return this.a;
        }
    }
}
