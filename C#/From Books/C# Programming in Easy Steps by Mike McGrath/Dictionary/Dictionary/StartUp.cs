using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    public class StartUp
    {
        public static void Main()
        {
            int dictLeng = int.Parse(Console.ReadLine());
            Dictionary<string, string> BookList =
                 new Dictionary<string, string>();


            for (int i = 0; i < dictLeng; i++)
            {
                
            }

            foreach (KeyValuePair<string,string> book in BookList)
            {
                Console.WriteLine($"Key :{book.Key} Value : {book.Value} in easy steps");
            }
        }
    }
}
