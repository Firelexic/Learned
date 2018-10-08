using System;

namespace StringSimpleExample
{
    public class StartUp
    {
        public static void Main()
        {
            string message = "Stand up, stand up, Balkan superman.";

            Console.WriteLine("Message = {0}",message);
            Console.WriteLine("Message.Length = {0}",message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("Message[{0}] = {1}", i, message[i]);
            }
        }
    }
}
