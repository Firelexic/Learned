using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine("{0} {1}",firstName,lastName);
        }
    }
}
