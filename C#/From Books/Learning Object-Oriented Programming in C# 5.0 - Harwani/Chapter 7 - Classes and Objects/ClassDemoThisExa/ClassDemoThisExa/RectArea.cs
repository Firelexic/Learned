using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoThisExa
{
    public class RectArea
    {
        private int l, b;
        public void SetData(int l,int b)
        {
            this.l = l;
            this.b = b;
        }

        public int GetRect()
        {
            return this.l * this.b;
        }
    }
}
