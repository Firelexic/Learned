using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Customer : ICustomer,ITwo
    {
        public void Print()
        {
            Console.WriteLine("Interface Print Methods");
        }

        public void iTwoMethod()
        {
            Console.WriteLine("I Two Method");
        }
    }
}
