using System;

namespace SwitchString
{
    class SwitchString
    {
        static void Main()
        {
            string commandName = Console.ReadLine();

            switch (commandName)
            {
                case "start":
                    Console.WriteLine("Starting service...");
                    break;
                case "stop":
                    Console.WriteLine("Stopping service...");
                    break;
                default:
                    Console.WriteLine(String.Format("Unknown command: {0}",commandName));
                    break;
            }
        }
    }
}
