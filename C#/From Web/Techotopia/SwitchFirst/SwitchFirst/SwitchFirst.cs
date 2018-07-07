using System;

namespace SwitchFirst
{
    class SwitchFirst
    {
        static void Main()
        {
            string carModel;
            string carManufacturer;

            System.Console.Write("Please Enter Your Vehicle Model: ");

            carModel = System.Console.ReadLine();

            if ((String.Compare(carModel, "Patriot") == 0) ||
                (String.Compare(carModel, "Liberty") == 0) ||
                (String.Compare(carModel, "Wrangler") == 0))
            {
                carManufacturer = "Jeep";
            }
            else if (String.Compare(carModel, "Focus") == 0)
            {
                carManufacturer = "Ford";
            }
            else if (String.Compare(carModel, "Corolla") == 0)
            {
                carManufacturer = "Toyota";
            }
            else
            {
                carManufacturer = "unknown";
            }

            System.Console.Write("Manufacturer is " + carManufacturer);
        }
    }
}

