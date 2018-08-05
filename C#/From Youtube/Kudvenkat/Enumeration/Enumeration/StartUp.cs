using System;

namespace Enumeration
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class StartUp
    {
        public static void Main()
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));

            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
