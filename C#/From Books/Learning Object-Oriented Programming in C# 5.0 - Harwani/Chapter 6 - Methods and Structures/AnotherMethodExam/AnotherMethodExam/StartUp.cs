using System;

namespace AnotherMethodExam
{
    public class StartUp
    {
        static void DisplayName(params string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("No names provided");
            }
            else
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }


        public static void Main()
        {
            string[] programmers = { "John", "Kelly", "Caroline", "Paula", "David" };
            string[] developers = { "Nancy", "Cynthia", "Mike" };
            Console.WriteLine("List of programmers is : ");
            DisplayName(programmers);
            Console.WriteLine("List of developers is :");
            DisplayName(developers);
        }
    }
}
