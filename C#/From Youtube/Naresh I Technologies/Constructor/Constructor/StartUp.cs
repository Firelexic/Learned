using System;

namespace Constructor
{
    public class StartUp
    {
        int i;
        bool b;

        public static void Main()
        {
            StartUp start = new StartUp();
            Console.WriteLine(start.i);
            Console.WriteLine(start.b);

            ExplicitCon expcon = new ExplicitCon();
            
        }
    }
}
