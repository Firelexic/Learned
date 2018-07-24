using System;

namespace ClassDemoProperty
{
    public class StartUp
    {
        public static void Main()
        {
            Rect r = new Rect();
            r.Length = 5;
            Console.WriteLine("Length is {0}",r.Length);
           
        }
    }
}
