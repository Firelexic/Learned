using System;

namespace MethodHiding
{
    public class StartUp
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Georgi";
            FTE.lastName = "Ivanov";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Ivan";
            PTE.lastName = "Georgiev";
            PTE.PrintFullName();
        }
    }
}
