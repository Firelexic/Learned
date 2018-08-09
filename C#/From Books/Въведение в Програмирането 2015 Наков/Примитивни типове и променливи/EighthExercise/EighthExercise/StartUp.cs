using System;

namespace EighthExercise
{
    public class StartUp
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string strHelloWorld = (string)helloWorld;
            Console.WriteLine(strHelloWorld);
            Console.WriteLine(helloWorld);

        }
    }
}
