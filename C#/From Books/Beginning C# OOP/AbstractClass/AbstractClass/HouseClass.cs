using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class HouseClass : GuestVist
    {
        public override void PurposeOfVisit()
        {
            Console.WriteLine("Abstract just came for a meetup and sped some time");
        }
    }
}
