using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethods
{
    public abstract class GuestVist
    {
        public abstract void PurposeOfVisit(); //Abstract Method

        public virtual void NoOfGuestWillVisit()
        {
            Console.WriteLine("Total 5 Guest will Visit your Home");
        }
    }
}
