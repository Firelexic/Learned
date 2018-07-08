using System;

namespace SwitchFirstExample
{
    class SwitchFirstExample
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    Console.WriteLine("Two");
                    break;
                    
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
