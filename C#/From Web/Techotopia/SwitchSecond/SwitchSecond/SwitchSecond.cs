using System;

namespace SwitchSecond
{
    class SwitchSecond
    {
        static void Main()
        {
            string carModel;
            string carManufacturer;

            Console.WriteLine("Please Enter Your Vehicle Model: ");

            carModel = Console.ReadLine().Trim().ToLower();

            switch (carModel)
            {
                case "patriot":
                case "liberty":
                case "wrangler":
                    carManufacturer = "jeep";
                    break;
                case "focus":
                    carManufacturer = "ford";
                    break;
                case "corolla":
                    carManufacturer = "toyota";
                    break;
                    
                default:
                    carManufacturer = "Unknown";
                    break;
            }
            Console.WriteLine("ManuFacturer is : " + carManufacturer);
        }
    }
}
