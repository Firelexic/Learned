using System;

namespace BuiltInTypes
{
    public class StartUp
    {
        public static void Main()
        {
            bool truth = true;
            bool falst = false;

            Console.WriteLine(truth);
            Console.WriteLine(falst);

            int i = int.MaxValue;
            int j = int.MinValue;
            
            Console.WriteLine("Max value : {0}",i);
            Console.WriteLine("Min value : {0}",j);
        }
    }
}
