using System;
using System.Text;

namespace StringIntern
{
    public class StartUp
    {
        public static void Main()
        {
            string declared = "Intern pool";
            string built = new StringBuilder("Intern pool").ToString();
            string interned = string.Intern(built);
            Console.WriteLine(object.ReferenceEquals(declared,built));
            Console.WriteLine(object.ReferenceEquals(declared,interned));

        }
    }
}
