using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class FullTimeEmployee : Employee
    {

        public override void PrintFullName()
        {
            Console.WriteLine("{0} {1} Full Time",firstName,lastName);
        }
    }
}
