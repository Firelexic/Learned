using System;
using System.Collections.Generic;
using System.Text;

namespace ThisKeyword
{
    public class RectArea
    {
        private int l, b;
        public RectArea(int x, int y)
        {
            this.l = x;
            this.b = y;
        }

        public int GetRect()
        {
            return this.l * this.b;
        }
    }
}
