using System;

namespace ClassDemoFourth
{
    public class StartUp
    {
        public static void Main()
        {
            Passing p = new Passing();
            int a, b;
            a = b = 10;
            Console.WriteLine("Value of a before method call : {0}",a);
            p.MethodRef(ref a);
            Console.WriteLine("Value of a after method call : {0}",a);
            a = b = 10;
            Console.WriteLine("Value of b before method call : {0}",b);
            p.MethodVal(b);
            Console.WriteLine("Value of b after method call : {0}",b);
        }
    }
}
