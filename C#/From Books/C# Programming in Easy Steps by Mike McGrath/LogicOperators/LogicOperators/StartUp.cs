using System;

namespace LogicOperators
{
    public class StartUp
    {
        public static void Main()
        {
            bool yes = true;
            bool no = false;

            Console.WriteLine("AND Logic:");
            Console.WriteLine("(yes && yes ) : " + (yes && yes));
            Console.WriteLine("(yes && no) : " + (yes && no));
            Console.WriteLine("(no && no ) : " + (no && no));

            Console.WriteLine("OR Logic : ");
            Console.WriteLine("(yes || yes) : " + (yes || yes));
            Console.WriteLine("(yes || no ) : " + (yes || no));
            Console.WriteLine("(no || no ) : " + (no || no));


            Console.WriteLine("NOT Logic: ");
            Console.WriteLine("yes = " + yes);
            Console.WriteLine("!yes = " + !yes);
            Console.WriteLine("no = " + no);
            Console.WriteLine("!no = " + !no);
        }
    }
}
