using System;
using System.Collections.Generic;
using System.Text;

namespace OOPInheritance
{
    public class Polygon
    {
        protected int width;
        protected int height;
        
        public void SetValue(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
