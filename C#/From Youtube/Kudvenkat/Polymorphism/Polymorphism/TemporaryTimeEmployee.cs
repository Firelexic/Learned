using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class TemporaryTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("{0} {1} Temporary Time",firstName,lastName);
        }
    }
}
