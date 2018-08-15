using System;

namespace ThirdExercise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Add company name : ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Add company addres : ");
            string companyAddres = Console.ReadLine();
            Console.WriteLine("Add company phone");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.WriteLine("Add company faks");
            int companyFaks = int.Parse(Console.ReadLine());
            Console.WriteLine("Add company website");
            string companyWebSite = Console.ReadLine();

            Console.WriteLine("Add manager name : ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Add manager last name : ");
            string managerSecondName = Console.ReadLine();
            Console.WriteLine("Add manager phone : ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.WriteLine("Company {0} , with addres {1} and phone number {2},faks {3} and website {4},have " +
                "manager {5} {6} ,manager phone number {7}",companyName,companyAddres,companyPhone,companyFaks,companyWebSite,managerFirstName,
                managerSecondName,managerPhone);
        }
    }
}
