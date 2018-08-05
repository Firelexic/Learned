using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideToString
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + " " + this.FirstName;
        }
    }
}
