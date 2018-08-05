using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine("{0} {1}",this.firstName,this.lastName);
        }
    }
}
