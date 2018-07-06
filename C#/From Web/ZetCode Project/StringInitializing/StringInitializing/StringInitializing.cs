using System;
using System.Text;

namespace StringInitializing
{
    class StringInitializing
    {
        static void Main()
        {
            char[] cdb = { 'M', 'y', 's', 'q', 'l' };

            string lang = "C#";
            String ide = "NetBeans";
            string db = new string(cdb);

            Console.WriteLine(lang);
            Console.WriteLine(ide);
            Console.WriteLine(db);

            StringBuilder sbOne = new StringBuilder(lang);
            StringBuilder sbTwo = new StringBuilder();
            sbTwo.Append("Fields");
            sbTwo.Append(" of ");
            sbTwo.Append("glory");

            Console.WriteLine(sbOne);
            Console.WriteLine(sbTwo);

        }
    }
}
