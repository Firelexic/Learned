using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //Console.WriteLine("{0} {1} !",firstName,lastName);
            base.PrintFullName();
        }
    }
}
