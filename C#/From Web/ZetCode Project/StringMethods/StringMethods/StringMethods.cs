using System;

namespace StringMethods
{
    class StringMethods
    {
        static void Main()
        {
            string[] items = new string[] {"C#","Visual Basic",
          "Java","Perl"};

            //Create one string from the array
            string langs = string.Join(",", items);
            Console.WriteLine(langs);

            //Create four strings from one string
            string[] ls = langs.Split(',');
            foreach (string lang in ls)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
