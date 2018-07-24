using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExample
{
    class Rect : Shape
    {
        public void GetRect(float a,float b)
        {
            SetValue(a, b);
        }

        public override float Area()
        {
            return (float)x * y;
        }
    }

}
