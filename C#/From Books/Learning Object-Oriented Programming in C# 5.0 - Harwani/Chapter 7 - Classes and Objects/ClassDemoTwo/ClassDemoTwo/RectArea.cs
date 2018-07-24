using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoTwo
{
    public class RectArea
    {
        private int l, b;
        
        public void SetData(int x,int y)
        {
            l = x;
            b = y;
        }

        public int GetRect()
        {
            return l * b;
        }
    }
}
