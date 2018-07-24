using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    public class RectArea
    {
        private int length;
        private int breadth;
        private int a;

        public void SetRect(int length,int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int GetRect()
        {
            return this.length * this.breadth;
        }
    }
}
