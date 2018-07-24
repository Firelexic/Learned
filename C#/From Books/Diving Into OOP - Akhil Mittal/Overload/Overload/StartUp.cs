using System;

namespace Overload
{
    public class StartUp
    {
        public static void Main()
        {
            Overload overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("Method overloading");
            overload.DisplayOverload("Method overloading", 100);

        }
    }
}
