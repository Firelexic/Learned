using System;

namespace SwitchStatement
{
    class SwitchStatement
    {
        static void Main()
        {
            string domain = Console.ReadLine();
            domain = domain.Trim().ToLower();

            switch (domain)
            {
                case "us":
                    Console.WriteLine("United States");
                    break;
                case "de":
                    Console.WriteLine("Germany");
                    break;
                case "sk":
                    Console.WriteLine("Slovakia");
                    break;
                case "hu":
                    Console.WriteLine("Hungary");
                    break;
                    
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
