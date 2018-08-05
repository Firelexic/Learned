using System;

namespace Inheritance
{
    public class StartUp
    {
        public static void Main()
        {
            FullTimeEmployee employeeOne = new FullTimeEmployee();
            employeeOne.firstName = "Ivan";
            employeeOne.lastName = "Georgiev";
            employeeOne.PrintFullName();


            PartTimeEmployee employeeTwo = new PartTimeEmployee();
            employeeTwo.firstName = "Tsvetan";
            employeeTwo.lastName = "Salkin";
            employeeTwo.PrintFullName();
        }
    }
}
