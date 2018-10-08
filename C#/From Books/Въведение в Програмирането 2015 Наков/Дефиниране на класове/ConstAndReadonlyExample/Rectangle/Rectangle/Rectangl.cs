using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Rectangl
    {
        private float height;
        private float width;

        public Rectangl(float height,float width)
        {
            this.height = height;
            this.width = width;
        }

        //Obtaining the value of the property area
        public float Area
        {
            get { return this.height * this.width; }
        }
    }
}
