using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class PartTimeEmployee : Employee
    {

        public override void PrintFullName()
        {
            Console.WriteLine("{0} {1} Part Time",firstName,lastName);
        }
    }

    
}
