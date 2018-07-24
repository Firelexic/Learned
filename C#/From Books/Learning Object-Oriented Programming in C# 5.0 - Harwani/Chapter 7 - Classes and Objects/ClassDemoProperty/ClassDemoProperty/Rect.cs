using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoProperty
{
    public class Rect
    {
        private int leng;

        public int Length
        {
            get { return leng; }
            set { leng = value; }
        }
    }
}
