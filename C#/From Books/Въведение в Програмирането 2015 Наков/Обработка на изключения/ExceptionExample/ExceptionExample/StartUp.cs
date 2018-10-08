using System;

namespace ExceptionExample
{
    public class StartUp
    {
        public static void Main()
        {
            Exception e = new Exception("There was a problem");
            throw e;
        }
    }
}
