using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class BaseClass
    {
        private void PrivateMethod()
        {
            Console.WriteLine("private Method");
        }
        public void publicMethod()
        {
            Console.WriteLine("This Method Shared");
        }
    }
}
