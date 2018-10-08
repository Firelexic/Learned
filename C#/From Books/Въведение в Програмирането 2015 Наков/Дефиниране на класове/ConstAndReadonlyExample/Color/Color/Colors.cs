using System;
using System.Collections.Generic;
using System.Text;

namespace Color
{
    public class Colors
    {
        public static readonly Colors Black = new Colors(0, 0, 0);
        public static readonly Colors White = new Colors(255, 255, 255);

        private int red;
        private int green;
        private int blue;

        public Colors(int red,int green,int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }


    }
}
