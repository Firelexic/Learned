using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethods
{
    public class AbstractHouseClass : GuestVist
    {
        public override void PurposeOfVisit()
        {
            Console.WriteLine("Abstract just for a Meetup and spend some time");
        }

        public override void NoOfGuestWillVisit()
        {
            Console.WriteLine("Total 20 Guest Visied our Home");
        }
    }
}
