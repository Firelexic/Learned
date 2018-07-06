using System;

namespace StringsAreObjects
{
    class StringsAreObjects
    {
        static void Main()
        {
            string lang = "Java";

            string bclass = lang.GetType().Name;
            Console.WriteLine(bclass);

            string parclass = lang.GetType().BaseType.Name;
            Console.WriteLine(parclass);

            if (lang.Equals(String.Empty))
            {
                Console.WriteLine("The string is empty");
            }
            else
            {
                Console.WriteLine("The string is not empty");
            }

            int l = lang.Length;
            Console.WriteLine("The string has " + l + " characters");
        }
    }
}
