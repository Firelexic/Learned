using System;

namespace Coffee
{
    public class StartUp
    {
        public static void Main()
        {
            Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

            Console.WriteLine("The {0} coffee is {1} ml",normalCoffee.Size,(int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml",doubleCoffee.Size,(int)doubleCoffee.Size);
        }
    }
}
