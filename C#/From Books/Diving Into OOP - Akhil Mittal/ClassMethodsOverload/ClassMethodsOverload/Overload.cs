using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsOverload
{
    public class Overload
    {
            private string name = "Akhil";
            public void Display()
            {
                Display2(ref name, ref name);
                 Console.WriteLine(name);
            }
            private void Display2(ref string x, ref string y)
            {
                Console.WriteLine(name);
                x = "Akhil 1";
                Console.WriteLine(name);
                y = "Akhil 2";
                Console.WriteLine(name);
                name = "Akhil 3";
            }
        


    }
}
