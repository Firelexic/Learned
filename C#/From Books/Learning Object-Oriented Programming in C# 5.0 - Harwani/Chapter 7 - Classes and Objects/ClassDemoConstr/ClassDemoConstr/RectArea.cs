using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoConstr
{
    public class RectArea
    {
        private int length;
        private int breadth;
        public RectArea()
        {
            this.length = 5;
            this.breadth = 8;
        }

        public int GetRect()
        {
            return length * breadth;
        }
    }
}
