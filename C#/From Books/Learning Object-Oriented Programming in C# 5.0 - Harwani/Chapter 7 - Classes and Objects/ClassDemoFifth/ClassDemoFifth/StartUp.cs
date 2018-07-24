using System;

namespace ClassDemoFifth
{
    public class StartUp
    {
        public static void Main()
        {
            Passing p = new Passing();
            int u, v, addn, mult;
            u = 10;
            v = 20;
            addn = p.AddMult(u, v, out mult);
            Console.WriteLine("The addition of the values {0} and {1} equals {2}, and the " +
                "multiplication of those values equals {3}",u,v,addn,mult);
        }
    }
}
