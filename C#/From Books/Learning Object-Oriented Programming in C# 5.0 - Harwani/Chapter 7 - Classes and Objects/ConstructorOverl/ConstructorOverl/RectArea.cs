using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorOverl
{
    public class RectArea
    {
        private int length;
        private int breadth;
        public RectArea()
        {
            this.length = 3;
            this.length = 6;
        }

        public RectArea(int length)
        {
            this.length = length;
            this.breadth = 7;
        }

        public RectArea(int length,int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public RectArea(float length,int breadth)
        {
            this.length = (int)length;
            this.breadth = breadth;
        }
        public RectArea(int length,float breadth)
        {
            this.length = length;
            this.length = (int)breadth;
        }
        public RectArea(float length,float breadth)
        {
            this.length = (int)length;
            this.breadth = (int)breadth;
        }

        public int GetRect()
        {
            return this.length * this.breadth;
        }
    }
}
