using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoFifth
{
    public class Passing
    {
        int a, b;
        public int AddMult(int x, int y, out int z)
        {
            a = x;
            b = y;
            z = a * b;
            return a + b;
        }
    }
}
