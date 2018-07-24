using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoConst
{
    public class RectArea
    {
        private int length;
        private int breadth;

        public RectArea(int x, int y)
        {
            length = x;
            breadth = y;
        }

        public int GetRect()
        {
            return length * breadth;
        }
    }
}
