using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExample
{
    abstract class Shape
    {
        protected float x, y;

        public void SetValue(float a, float b)
        {
            x = a;
            y = b;
        }

        public abstract float Area();
    }
}
