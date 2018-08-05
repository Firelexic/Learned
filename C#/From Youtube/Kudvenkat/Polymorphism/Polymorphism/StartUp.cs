using System;

namespace Polymorphism
{
    public class StartUp
    {
        public static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryTimeEmployee();

            foreach (Employee employe in employees)
            {
                employe.PrintFullName();
            }
        }
    }
}
