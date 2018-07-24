using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoFourth
{
    public class Passing
    {
        public void MethodRef(ref int x)
        {
            x = x + 5;
        }

        public void MethodVal(int y)
        {
            y = y - 10;
        }
    }
}
