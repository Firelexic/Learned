using System;

namespace VirtualMethods
{
    public class StartUp
    {
        public static void Main()
        {
            AbstractHouseClass house = new AbstractHouseClass();
            house.PurposeOfVisit();
            house.NoOfGuestWillVisit();
        }
    }
}
