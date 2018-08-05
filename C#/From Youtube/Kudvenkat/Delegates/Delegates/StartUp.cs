using System;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);

    public class StartUp
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public static void Main()
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
        }
    }
}
