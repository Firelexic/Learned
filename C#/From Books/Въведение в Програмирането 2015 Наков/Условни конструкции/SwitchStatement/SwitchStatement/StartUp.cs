using System;

namespace SwitchStatement
{
    public class StartUp
    {
        public static void Main()
        {
            int number = 6;
            switch (number)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("Number isnt easy!");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Number is easy!");
                    break;
                default:
                    Console.WriteLine("Unknown number");
                    break;
            }
        }
    }
}
