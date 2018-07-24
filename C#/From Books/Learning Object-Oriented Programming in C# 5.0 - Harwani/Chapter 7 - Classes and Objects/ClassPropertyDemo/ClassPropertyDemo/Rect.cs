using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPropertyDemo
{
    public class Rect
    {
        private int l, b;
        public Rect()
        {
            l = 0;
            b = 0;
        }
        public int Length
        {
            get { return l; }
            set
            {
                if (value >= 0 )
                {
                    l = value;
                }
            }
        }

        public int Breadth
        {
            get { return b; }
            set
            {
                if (b >= 0)
                {
                    b = value;
                }
            }
        }
    }
}
