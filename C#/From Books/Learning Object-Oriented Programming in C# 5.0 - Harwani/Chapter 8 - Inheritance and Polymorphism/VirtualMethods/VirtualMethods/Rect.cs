using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethods
{
    public class Rect
    {
        protected float x, y;

        public void SetValue(float a, float b)
        {
            x = a;
            y = b;
        }

        public virtual float Area()
        {
            return x * y;
        }
    }
}
