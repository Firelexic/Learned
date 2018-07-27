using System;
using System.Collections;

namespace Collections
{
    public class StartUp
    {
        public static void Main()
        {
            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine(aList.Count);
            
        }
    }
}
