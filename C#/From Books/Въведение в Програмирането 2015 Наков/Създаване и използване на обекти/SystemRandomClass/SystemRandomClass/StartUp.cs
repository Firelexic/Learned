using System;

namespace SystemRandomClass
{
    public class StartUp
    {
        public static void Main()
        {
            Random rand = new Random();

            for (int i = 1; i <= 6; i++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.WriteLine("{0} ",randomNumber);
            }
        }
    }
}
